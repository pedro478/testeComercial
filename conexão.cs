using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace TESTE_LINHA_COMERCIAL
{
    public class conexão
    {

        private int port, byteCount;

        private string readData, pass;
        private string endereço_ip;


        NetworkStream stream;
        byte[] sendData;

        TcpClient client;

        NetworkStream serverStream = default(NetworkStream);

        public string Port
        {
            set { port = Convert.ToInt32(value); }
            get { return Convert.ToString(port); }

        }
        public string IP
        {
            set { endereço_ip = value; }
            get { return endereço_ip; }

        }



               public conexão()

               {
                   if (!int.TryParse(Convert.ToString(port), out port))

                   {

                       MessageBox.Show("Port não encontrado");
                   }

                   try

                   {

                       client = new TcpClient(endereço_ip, port);

                   }



                   catch (System.Net.Sockets.SocketException)

                   {

                        MessageBox.Show("Conexão não realizada");

                   }
                   Thread ctThred = new Thread(getMessage);
                   ctThred.Start();

               }

               int counter2 = 0;
               private bool InvokeRequired;

               private void getMessage()

               {
                   string returndata;

                   while (client != null && counter2 == 0)
                   {


                       try
                       {
                           serverStream = client.GetStream();

                           var buffsize = client.ReceiveBufferSize;
                           byte[] instream = new byte[buffsize];


                           // serverStream.Read(instream, 0, buffsize);

                           serverStream.Read(instream, 0, buffsize);

                           returndata = System.Text.Encoding.ASCII.GetString(instream);

                           readData = returndata.Trim();

                           msg();

                       }

                       catch
                       {

                           MessageBox.Show("Connection Closed");
                           counter2 = counter2 + 1;


                       }
                   }

               }
               private void msg()

               {


                   if (this.InvokeRequired)

                   {

                       this.Invoke(new MethodInvoker(msg));


                   }


                   else

                   {

                       pass += readData;

                   }


               }

               private void Invoke(MethodInvoker methodInvoker)
               {
                   throw new NotImplementedException();
               }
           }

    }

