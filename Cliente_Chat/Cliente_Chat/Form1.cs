using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using Transitions;
namespace Cliente_Chat
{
    public partial class Form1 : Form
    {
        static private NetworkStream str;
        static private StreamWriter strw;
        static private StreamReader strr;
        static private TcpClient client = new TcpClient();
        static private string user = "unknow";
        
        private static object cadena;

        private delegate void PadreItem(String s);



        //metodo para agregar texto en el listbox
        private void AddText(String s)
        {
            listBox1.Items.Add(s);
        }
        public Form1()
        {
            InitializeComponent();
        }


        // Metodo para imprimir en el chat 
        void imprimir()
        {
            //mientras el cliente tenga conexión aplicara lo que este dentro 
            // de la excepción

            while (client.Connected)
            {
                try
                {
                    this.Invoke(new PadreItem(AddText), strr.ReadLine());
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se ha podido conectar...");
                    Application.Exit();
                }
            }


        }

        //metódo conectar el cual nos conectará a el servidor con la 
        // siguiente ip y con su puerto
        void Conectar()
        {
            try
            {
                client.Connect("127.0.0.1", 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(imprimir);
                    str = client.GetStream();
                    strw = new StreamWriter(str);
                    strr = new StreamReader(str);

                    strw.WriteLine(user);
                    strw.Flush();

                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no disponible");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique que el servidor este en linea");
                Application.Exit();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            Conectar();

            Transition tr = new Transition(new TransitionType_EaseInEaseOut(900));
            tr.add(label1, "Left", 555);
            tr.add(txtUser, "Left", 555);
            tr.add(btnconectar, "Left", 555);
            tr.run();

            txtUser.Enabled = false;
            btnconectar.Enabled = false;

        }

        private void btnenviarmsj_Click(object sender, EventArgs e)
        {


            // Mensaje finaliza con @ se manda los caracteres intercalados (hello world@) --> hlowrd
            string msj =txtmjs.Text;

            if (msj.EndsWith("@"))
            {
                string it = msj.Substring(3, 6);
                label2.Text = it;
                strw.WriteLine(msj);
                strw.Flush();
                txtmjs.Clear();
            }
            else
            {
                //Mensaje inicia con # se manda de atrás para adelante (#hello world) --> dlrow olleh
                if (msj.StartsWith("#"))
                {
                    string rv = ReverseString(msj);
                    label1.Text = rv;
                    strw.WriteLine(msj);
                    strw.Flush();
                    txtmjs.Clear();
                }

            }


        }

        static string ReverseString(string s)
        {

            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

    }
}
