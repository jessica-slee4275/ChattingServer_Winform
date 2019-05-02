using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Chatting
{
    public partial class Form1 : Form
    {
        Socket listen_socket;
        Socket client_socket;
        bool isConnected; //server and client

        byte[] bytes = new byte[1024];
        string data; //chat data
        public Form1()
        {
            InitializeComponent();
            isConnected = false; //initialize connection
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            start("127.0.0.1", 7777, 10);
        }

        public void start(string host, int port, int backlog) {
            this.listen_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address;
            if (host == "0.0.0.0"){
                address = IPAddress.Any;
            }
            else {
                address = IPAddress.Parse(host);
            }
            IPEndPoint endPoint = new IPEndPoint(address, port);
            try
            {
                listen_socket.Bind(endPoint);
                listen_socket.Listen(backlog);

                client_socket = listen_socket.Accept();
                lbChatHistory.Items.Add("Start Connection...");
                isConnected = true;
                Thread listen_thread = new Thread(do_receive);
                listen_thread.Start();
            }
            catch (Exception e) { }
        }
        void do_receive() {
            while (isConnected) {
                while (true) {
                    byte[] bytes = new byte[1024];
                    int bytesRec = client_socket.Receive(bytes);
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<eof>") > -1)
                        break;
                }
                data = data.Substring(0, data.Length - 5);
                Invoke((MethodInvoker)delegate {
                    lbChatHistory.Items.Add(data);
                });
                data = "";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
                return;
            byte[] msg = Encoding.UTF8.GetBytes(tbText.Text + "<eof>");
            int bytesSent = client_socket.Send(msg);
            tbText.Clear();
            tbText.Text = "";
        }
    }
}
