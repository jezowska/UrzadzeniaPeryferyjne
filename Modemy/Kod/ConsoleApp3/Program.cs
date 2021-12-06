using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
    
    class Program
    {
        static SerialPort _serialPort;
        private static bool _continue;

        static void Main(string[] args)
        {
            string message = "";
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            Thread readThread = new Thread(Read);

            _serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            _serialPort.DtrEnable = true;
            _serialPort.Handshake = Handshake.RequestToSend;

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();
            _continue = true;

            
            readThread.Start();

            //Console.Write("Name: ");
            //name = Console.ReadLine();

            Console.WriteLine("Type QUIT to exit");

            while (_continue)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo sign = Console.ReadKey(false);
                    while (sign.Key != ConsoleKey.Enter)
                    {
                        message += sign.KeyChar;
                        sign = Console.ReadKey(false);
                    }
                    if (stringComparer.Equals("quit", message))
                    {
                        _continue = false;
                    }
                    else
                    {
                        message += "\r";
                        Console.WriteLine(message);
                        _serialPort.WriteLine(message);
                        message = "";
                    }
                }
            }

            readThread.Join();
            _serialPort.Close();
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }

        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }

    }
}
