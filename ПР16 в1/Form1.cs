using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TCPFileReceiver
{
    public partial class Form1 : Form
    {
        private string ipAddress;
        private int port;
        private Socket socket;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartServer()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                socket.Listen(10);
                socket.BeginAccept(AcceptCallback, null);
                richTextBox1.Text += "������ �������� �� " + ipAddress + ":" + port + "\n";
            }
            catch (Exception ex)
            {
                richTextBox1.Text += "������� ��� ������� �������: " + ex.Message + "\n";
            }
        }

        private void StopServer()
        {
            try
            {
                if (socket != null)
                {
                    socket.Close();
                    socket = null;
                    richTextBox1.Text += "������ ��������\n";
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text += "������� ��� ������� �������: " + ex.Message + "\n";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ipAddress = textBox1.Text;
            if (!int.TryParse(textBox2.Text, out port))
            {
                richTextBox1.Text += "�������: ������� ����\n";
                return;
            }

            StartServer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ipAddress = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out port);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket newSocket = socket.EndAccept(ar);
                richTextBox1.Text += "�'������� �������� �� " + newSocket.RemoteEndPoint + "\n";

                byte[] fileNameBytes = new byte[1024];
                int fileNameBytesReceived = newSocket.Receive(fileNameBytes);
                string fileName = Encoding.UTF8.GetString(fileNameBytes, 0, fileNameBytesReceived);
                richTextBox1.Text += "�������� ����� �����: " + fileName + "\n";

                byte[] fileSizeBytes = new byte[4];
                int fileSizeBytesReceived = newSocket.Receive(fileSizeBytes);
                int fileSize = BitConverter.ToInt32(fileSizeBytes, 0);
                richTextBox1.Text += "�������� ����� �����: " + fileSize + " bytes\n";

                if (fileSize > 0)
                {
                    byte[] fileData = new byte[fileSize];
                    int fileDataReceived = 0;
                    while (fileDataReceived < fileSize)
                    {
                        int bytesReceived = newSocket.Receive(fileData, fileDataReceived, fileSize - fileDataReceived, SocketFlags.None);
                        if (bytesReceived == 0)
                        {
                            throw new Exception("������� ��� �������� ����� �����");
                        }
                        fileDataReceived += bytesReceived;
                        richTextBox1.Text += "�������� " + fileDataReceived + " bytes � " + fileSize + " bytes\n";
                    }

                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                    if (File.Exists(filePath))
                    {
                        richTextBox1.Text += "���� " + fileName + " ��� ����\n";
                    }
                    else
                    {
                        File.WriteAllBytes(filePath, fileData);
                        richTextBox1.Text += "���� " + fileName + " ��������� (" + fileSize + " bytes)\n";
                    }
                }
                else
                {
                    richTextBox1.Text += "�������: �������� ����������� ����� �����\n";
                }

                socket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                richTextBox1.Text += "������� ��� �������� �'�������: " + ex.Message + "\n";
            }
        }
    }
}