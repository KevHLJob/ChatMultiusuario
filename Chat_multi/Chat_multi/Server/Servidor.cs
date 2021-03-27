using System;
using System.Collections.Generic;


using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Chat_multi.Server
{
    class Servidor
    {

        private TcpListener serv;
        private TcpClient cli = new TcpClient();
        private IPEndPoint Ipep = new IPEndPoint(IPAddress.Any, 8000);
        private List<Connection> list = new List<Connection>();

        Connection con;

        private struct Connection
        {
            public NetworkStream stre;
            public StreamWriter strW;
            public StreamReader strR;
            public string user;


        }

        public Servidor()
        {
            Iniciar();
        }

        public void Iniciar()
        {
            // El servidor Inicia
            //La variable servidor obtendra el nuevo objeto TCP que es el IP END point..
            //Para asi poder Iniciarlo con el metodo Start...
            Console.WriteLine("Online Server");
            serv = new TcpListener(Ipep);
            serv.Start();

            //Mientras la conexion sea verdadera
            while (true)
            {

                //La variable cliente la igualamos a que el servidor acepte TCP cliente
                cli = serv.AcceptTcpClient();
                con = new Connection(); // se inicializa una conexión
                con.stre = cli.GetStream();// conectamos para recibir los datos del cliente
                con.strR = new StreamReader(con.stre);
                con.strW = new StreamWriter(con.stre);

                // se lee el usuario ingresado parsa luego
                con.user = con.strR.ReadLine();

                //agregarlo al arreglo utilizando la conexion cliente
                list.Add(con);
                //En consola se imprimira el Usuario Ingresado en el cliente
                Console.WriteLine(con.user + " Se a conectado.");

                //Se inicializa un hilo con el metodo, para que se ejecute...
                Thread t = new Thread(ConEs);
                t.Start();
            }



        }
        //Metodo que todo lo que se vaya escribir en el cliente 
        // Se pueda reescribir en el servidor
        void ConEs()
        {
            Connection hcon = con;
            // variable que nos provee la conexión...
            do
            {
                try
                {
                    //En estas dos lineas tendremos
                    // La lectura de lo que escribe el cliente
                    string temp = hcon.strR.ReadLine();
                    //Nombre del cliente y con su respectivo msj...
                    Console.WriteLine(hcon.user + " : " + temp);


                    //mientras haya conexion realizara un ingreso de clientes en el arreglo...
                    foreach (Connection c in list)
                    {
                        try
                        {
                            c.strW.WriteLine(hcon.user + " : " + temp);
                            c.strW.Flush();
                        }
                        catch (Exception i)
                        {
                            throw (i);
                        }
                    }
                }
                catch (Exception e)
                {
                    //Si se sale algun cliente este algoritmo es para eliminarlo...
                    list.Remove(hcon);
                    Console.WriteLine(con.user + " Se ha desconectado. ");
                    throw (e);
                    break;
                }
            } while (true);
        }

    }
}

