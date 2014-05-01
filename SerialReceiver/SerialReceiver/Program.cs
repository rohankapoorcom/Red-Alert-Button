using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using WindowsInput;
using WindowsInput.Native;

namespace SerialReceiver
{
    class Program
    {
        static SerialPort serial;
        static StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        static bool running;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: SerialReceiver [port] [baudrate]");
                Environment.Exit(0);
            }

            // Initialization
            serial = new SerialPort(args[0], Convert.ToInt32(args[1]));
            Thread readThread = new Thread(Read);

            serial.ReadTimeout = 500;
            serial.WriteTimeout = 500;

            serial.Open();
            running = true;
            readThread.Start();

            Console.WriteLine("Type QUIT to exit");

            // Allow users to quit the application nicely
            while (running) {
                String message = Console.ReadLine();
                if (stringComparer.Equals("quit", message))
                    running = false;
            }

            // Clean up
            readThread.Join();
            serial.Close();

        }

        public static void Read()
        {
            InputSimulator input = new InputSimulator();
            while (running)
            {
                try
                {
                    string message = serial.ReadLine();

                    if (message.Equals("toggle\r"))
                    {
                        input.Keyboard.KeyPress(VirtualKeyCode.VK_R);
                        Console.WriteLine("Red Alert Toggled");
                    }
                }

                catch(TimeoutException) { }
            }
        }
    }
}
