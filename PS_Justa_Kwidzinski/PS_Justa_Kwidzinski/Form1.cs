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
using System.IO;

namespace PS_Justa_Kwidzinski
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Random rnd = new Random();
        int licznik, flaga;
        bool BINGO;
        bool fReady = false;
        int[] tablica = new int[75];
        int[] z = new int[25];
        bool[] bing = new bool[25];
        bool flagaClient = false;
        bool flagaSerwer = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bing[1] = checkExist(1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            bing[0] = checkExist(0);
            if (bing[0]) button0.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bing[1] = checkExist(1);
            if (bing[1]) button1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bing[2] = checkExist(2);
            if (bing[2]) button2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bing[3] = checkExist(3);
            if (bing[3]) button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bing[4] = checkExist(4);
            if (bing[4]) button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bing[5] = checkExist(5);
            if (bing[5]) button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bing[6] = checkExist(6);
            if (bing[6]) button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bing[7] = checkExist(7);
            if (bing[7]) button7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bing[8] = checkExist(8);
            if (bing[8]) button8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bing[9] = checkExist(9);
            if (bing[9]) button9.BackColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bing[10] = checkExist(10);
            if (bing[10]) button10.BackColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bing[11] = checkExist(11);
            if (bing[11]) button11.BackColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bing[13] = checkExist(13);
            if (bing[13]) button13.BackColor = Color.Green;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bing[14] = checkExist(14);
            if (bing[14]) button14.BackColor = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bing[15] = checkExist(15);
            if (bing[15]) button15.BackColor = Color.Green;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bing[16] = checkExist(16);
            if (bing[16]) button16.BackColor = Color.Green;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bing[17] = checkExist(17);
            if (bing[17]) button17.BackColor = Color.Green;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bing[18] = checkExist(18);
            if (bing[18]) button18.BackColor = Color.Green;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bing[19] = checkExist(19);
            if (bing[19]) button19.BackColor = Color.Green;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bing[20] = checkExist(20);
            if (bing[20]) button20.BackColor = Color.Green;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bing[21] = checkExist(21);
            if (bing[21]) button21.BackColor = Color.Green;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bing[22] = checkExist(22);
            if (bing[22]) button22.BackColor = Color.Green;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bing[23] = checkExist(23);
            if (bing[23]) button23.BackColor = Color.Green;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bing[24] = checkExist(24);
            if (bing[24]) button24.BackColor = Color.Green;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!flagaClient && !flagaSerwer && fReady)
            {
                try
                {
                    flagaClient = true;
                    flagaSerwer = false;
                    TcpClient tcpclnt = new TcpClient();
                    Console.WriteLine("Connecting.....");

                    tcpclnt.Connect("192.168.0.34", 8001);
                    // use the ipaddress as in the server program

                    Console.WriteLine("Connected");

                    //Console.Write("Enter the string to be transmitted : ");

                    //String str = Console.ReadLine();
                    Stream stm = tcpclnt.GetStream();
                    button25.BackColor = Color.Green;

                    //ASCIIEncoding asen = new ASCIIEncoding();
                    //byte[] ba = asen.GetBytes(str);
                    //Console.WriteLine("Transmitting.....");

                    //stm.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);

                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(bb[i]));

                    tcpclnt.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error..... " + ex.StackTrace);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            
            if ((bing[0] && bing[1] && bing[2] && bing[3] && bing[4])
                || (bing[5] && bing[6] && bing[7] && bing[8] && bing[9])
                || (bing[10] && bing[11] && bing[13] && bing[14])
                || (bing[15] && bing[16] && bing[17] && bing[18] && bing[19])
                || (bing[20] && bing[21] && bing[22] && bing[23] && bing[24])
                || (bing[0] && bing[5] && bing[10] && bing[15] && bing[20])
                || (bing[1] && bing[6] && bing[11] && bing[16] && bing[21])
                || (bing[2] && bing[7] && bing[17] && bing[22])
                || (bing[3] && bing[8] && bing[13] && bing[18] && bing[23])
                || (bing[4] && bing[9] && bing[14] && bing[19] && bing[24])
                || (bing[0] && bing[6] && bing[18] && bing[24])
                || (bing[4] && bing[8] && bing[16] && bing[20]))
            {
                BINGO = true;
                timer1.Enabled = false;
                MessageBox.Show("ZWYCIESTWO!!");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!flagaClient && !flagaSerwer)
            {
                bing[12] = true;
                button12.BackColor = Color.Green;
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 3; j++)
                        tablica[i * 3 + j] = 0;
                    z[i] = 0;
                    if (i != 12) bing[i] = false;
                }
                button0.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;
                button24.BackColor = Color.White;
                int a, b;
                a = 1;
                b = 15;
                z[0] = rnd.Next(a, b);
                do { z[1] = rnd.Next(a, b); } while (z[1] == z[0]);
                do { z[2] = rnd.Next(a, b); } while (z[2] == z[0] || z[2] == z[1]);
                do { z[3] = rnd.Next(a, b); } while (z[3] == z[0] || z[3] == z[1] || z[3] == z[2]);
                do { z[4] = rnd.Next(a, b); } while (z[4] == z[0] || z[4] == z[1] || z[4] == z[2] || z[4] == z[3]);
                button0.Text = Convert.ToString(z[0]);
                button1.Text = Convert.ToString(z[1]);
                button2.Text = Convert.ToString(z[2]);
                button3.Text = Convert.ToString(z[3]);
                button4.Text = Convert.ToString(z[4]);

                a = 16;
                b = 30;
                z[5] = rnd.Next(a, b);
                do { z[6] = rnd.Next(a, b); } while (z[6] == z[5]);
                do { z[7] = rnd.Next(a, b); } while (z[7] == z[5] || z[7] == z[6]);
                do { z[8] = rnd.Next(a, b); } while (z[8] == z[5] || z[8] == z[6] || z[8] == z[7]);
                do { z[9] = rnd.Next(a, b); } while (z[9] == z[5] || z[9] == z[6] || z[9] == z[7] || z[9] == z[8]);
                button5.Text = Convert.ToString(z[5]);
                button6.Text = Convert.ToString(z[6]);
                button7.Text = Convert.ToString(z[7]);
                button8.Text = Convert.ToString(z[8]);
                button9.Text = Convert.ToString(z[9]);

                a = 31;
                b = 45;
                z[10] = rnd.Next(a, b);
                do { z[11] = rnd.Next(a, b); } while (z[11] == z[10]);
                do { z[13] = rnd.Next(a, b); } while (z[13] == z[10] || z[13] == z[11] || z[13] == z[12]);
                do { z[14] = rnd.Next(a, b); } while (z[14] == z[10] || z[14] == z[11] || z[14] == z[12] || z[14] == z[13]);
                button10.Text = Convert.ToString(z[10]);
                button11.Text = Convert.ToString(z[11]);
                button12.Text = "*";
                button13.Text = Convert.ToString(z[13]);
                button14.Text = Convert.ToString(z[14]);

                a = 46;
                b = 60;
                z[15] = rnd.Next(a, b);
                do { z[16] = rnd.Next(a, b); } while (z[16] == z[15]);
                do { z[17] = rnd.Next(a, b); } while (z[17] == z[15] || z[17] == z[16]);
                do { z[18] = rnd.Next(a, b); } while (z[18] == z[15] || z[18] == z[16] || z[18] == z[17]);
                do { z[19] = rnd.Next(a, b); } while (z[19] == z[15] || z[19] == z[16] || z[19] == z[17] || z[19] == z[18]);
                button15.Text = Convert.ToString(z[15]);
                button16.Text = Convert.ToString(z[16]);
                button17.Text = Convert.ToString(z[17]);
                button18.Text = Convert.ToString(z[18]);
                button19.Text = Convert.ToString(z[19]);

                a = 61;
                b = 75;
                z[20] = rnd.Next(a, b);
                do { z[21] = rnd.Next(a, b); } while (z[21] == z[20]);
                do { z[22] = rnd.Next(a, b); } while (z[22] == z[20] || z[22] == z[21]);
                do { z[23] = rnd.Next(a, b); } while (z[23] == z[20] || z[23] == z[21] || z[23] == z[22]);
                do { z[24] = rnd.Next(a, b); } while (z[24] == z[20] || z[24] == z[21] || z[24] == z[22] || z[24] == z[23]);
                button20.Text = Convert.ToString(z[20]);
                button21.Text = Convert.ToString(z[21]);
                button22.Text = Convert.ToString(z[22]);
                button23.Text = Convert.ToString(z[23]);
                button24.Text = Convert.ToString(z[24]);
                //timer1.Enabled = true;
                //licznik = 0;
                //Liczby.Text = " ";
                fReady = true;
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (flagaSerwer == true && flagaClient == false)
            {
                if (Convert.ToInt32(label1.Text) > 1)
                {
                    label1.Text = Convert.ToString(0);

                    do
                    {
                        flaga = 0;
                        tablica[licznik] = rnd.Next(1, 75);
                        for (int i = licznik - 1; i >= 0; i--)
                            if (tablica[i] == tablica[licznik]) flaga = 1;
                    } while (flaga == 1);
                    Liczby.Text = Liczby.Text + Convert.ToString(tablica[licznik]) + ", ";
                    licznik++;



                    try
                    {
                        IPAddress ipAd = IPAddress.Parse("192.168.0.34");
                        TcpListener myList = new TcpListener(ipAd, 8001);

                        /* Start Listeneting at the specified port */
                        myList.Start();

                        Console.WriteLine("The server is running at port 8001...");
                        Console.WriteLine("The local End point is  :" +
                                          myList.LocalEndpoint);
                        Console.WriteLine("Waiting for a connection.....");
                        Socket s = myList.AcceptSocket();
                        Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                        //byte[] b = new byte[100];
                        //int k = s.Receive(b);
                        //Console.WriteLine("Recieved...");
                        //for (int i = 0; i < k; i++)
                        //Console.Write(Convert.ToChar(b[i]));

                        ASCIIEncoding asen = new ASCIIEncoding();
                        s.Send(asen.GetBytes(Convert.ToString(tablica[licznik - 1])));
                        //Console.WriteLine("\nSent Acknowledgement");
                        /* clean up */
                        s.Close();
                        myList.Stop();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error..... " + ex.StackTrace);
                    }
                }
            }
            if (flagaSerwer == false && flagaClient == true)
            {
                try
                {
                    string liczbaBytowa ="";
                    TcpClient tcpclnt = new TcpClient();
                    Console.WriteLine("Connecting.....");

                    tcpclnt.Connect("192.168.0.34", 8001);
                    // use the ipaddress as in the server program

                    Console.WriteLine("Connected");
                    //Console.Write("Enter the string to be transmitted : ");

                    //String str = Console.ReadLine();
                    Stream stm = tcpclnt.GetStream();

                    //ASCIIEncoding asen = new ASCIIEncoding();
                    //byte[] ba = asen.GetBytes(str);
                    //Console.WriteLine("Transmitting.....");

                    //stm.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);
                    
                    for (int i = 0; i < k; i++)
                        liczbaBytowa = liczbaBytowa + Convert.ToChar(bb[i]);
                    //Console.Write(liczbaBytowa);
                    Liczby.Text = Liczby.Text + liczbaBytowa + ", ";
                    tablica[licznik] = Convert.ToInt32(liczbaBytowa);
                    licznik++;

                    tcpclnt.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error..... " + ex.StackTrace);
                }
            
                
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!flagaClient && !flagaSerwer && fReady)
            {
                flagaSerwer = true;
                flagaClient = false;
                button29.BackColor = Color.Yellow;
                try
                {
                    IPAddress ipAd = IPAddress.Parse("192.168.0.34");
                    TcpListener myList = new TcpListener(ipAd, 8001);

                    /* Start Listeneting at the specified port */
                    myList.Start();

                    Console.WriteLine("The server is running at port 8001...");
                    Console.WriteLine("The local End point is  :" +
                                      myList.LocalEndpoint);
                    Console.WriteLine("Waiting for a connection.....");
                    Socket s = myList.AcceptSocket();

                    button29.BackColor = Color.Green;
                    timer1.Enabled = true;
                    licznik = 0;
                    Liczby.Text = " ";

                    Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                    //byte[] b = new byte[100];
                    //int k = s.Receive(b);
                    //Console.WriteLine("Recieved...");
                    //for (int i = 0; i < k; i++)
                        //Console.Write(Convert.ToChar(b[i]));

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("The string was recieved by the server."));
                    //Console.WriteLine("\nSent Acknowledgement");
                    /* clean up */
                    s.Close();
                    myList.Stop();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error..... " + ex.StackTrace);
                }
            }
        }

        private void textBox0_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkExist (int pole)
        {
            bool stan = false;
            for(int i = licznik; i >= 0; i--)
                if(z[pole] == tablica[i]) stan = true;
            return stan;
        }

    }
}
