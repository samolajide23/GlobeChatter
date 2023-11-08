using Microsoft.Win32.SafeHandles;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using DetectLanguage;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Policy;

namespace GlobeChatter
{
    public partial class Form1 : Form
    {
        string englishLanguage = "EN";
        string spanishLanguage = "ES";
        string frenchLanguage = "FR";
        public string toLanguage = "EN";
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        List<string> allLanguauges = File.ReadAllLines("C:\\Users\\Samuel\\Desktop\\GlobeChatter\\GlobeChatter\\supportedLanguages.txt").ToList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user IP
            textLocalIp.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // bind the socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            socket.Bind(epLocal);
            // connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
            socket.Connect(epRemote);

            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            RemoteLanguageBox.Items.Add(englishLanguage);
            foreach (var s in allLanguauges)
            {
                LanguageBox.Items.Add(s);
            }


        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "Enter IP";
        }
        //send message
        private void buttonSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);
            //send message
            socket.Send(sendingMessage);
            //addig to list box
            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";
        }
        private void changeLanguage_Click(object sender, EventArgs e)
        {
            if (LanguageBox.SelectedItem.ToString() != null)
            {
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] languageChange = new byte[1500];
                languageChange = aEncoding.GetBytes(LanguageBox.SelectedItem.ToString());
                toLanguage = LanguageBox.SelectedItem.ToString();
                // 
                socket.Send(languageChange);
            }
        }
        public string detectLanguage(string x)
        {
            try
            {
                string url = String.Format("https://ws.detectlanguage.com/0.2/detect?q=" + x + "&key=eaffba175158bdfd40517de8313874a5");
                using (var webclient = new WebClient { Encoding = Encoding.UTF8 })
                {
                    var result = webclient.DownloadString(url);
                    result = result.Substring(36, result.IndexOf("\"", 36, StringComparison.Ordinal) - 36);
                    return result;
                }
            }
            catch(Exception ex)
            {
                return "Error";

            }
        }
        public String translate(String input, string to)
        {
            try
            {
                string x = detectLanguage(input);
                string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",x, to, input);
                using (var webclient = new WebClient{Encoding = Encoding.UTF8})
                {
                    var result = webclient.DownloadString(url);

                    result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                    return result;
                }

            }
            catch (Exception e1)
            { 
            return "Error";
            }
        }
        //recieve message
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                bool isLanguageChange = false;
                // convert byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                // Change language from friend
                foreach (var s in allLanguauges)
                {
                    if (String.Compare(receivedMessage, s) == 0)
                    {
                        isLanguageChange = true;
                        RemoteLanguageBox.Items.Clear();
                        RemoteLanguageBox.Items.Add(receivedMessage);
                        //toLanguage = LanguageBox.SelectedItem.ToString();
                        buffer = new byte[1500];
                        socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                        listMessage.Items.Add(translate("Friend Changed Language to : " + receivedMessage, toLanguage));
                    }
                }
                if(!isLanguageChange)
                {
                    //adding message to listbox
                    string translatedMessage = translate(receivedMessage, toLanguage);
                    listMessage.Items.Add("Friend: " + translatedMessage);

                    buffer = new byte[1500];
                    socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                }
            }
            catch (Exception ex)
            {
                listMessage.Items.Add(ex.Message);
            }
        }
    }
}