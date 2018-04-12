using System;
//using System.Collections.Generic;
//using System.Text;
using Sys = Cosmos.System;

namespace MyFirstOS
{
    public class Kernel: Sys.Kernel
    {
        public bool running = true;
        protected override void BeforeRun()
        {
            Console.WriteLine("SSLOS ver. 0.0.3");
            Console.WriteLine("=================================================");
        }
        
        protected override void Run()
        {
            while (running) {
                Console.Write("$ > ");
                var input = Console.ReadLine();
                
                switch (input)
                {
                    case "/help":
                        Console.Write("/reboot /shutdown /b /c /d /e \n");
                        break;
                    case "/reboot":
                        Cosmos.System.Power.Reboot();
                        break;
                    case "/shutdown":
                        this.Stop();
                        break;
                    case "/b":
                        break;
                    case "/c":
                        break;
                    case "/d":
                        break;
                    case "/e":
                        break;
                    default:
                        Console.Write("\' " + input + "\' is not a recognized command.\n");
                        break;
                }
                //Console.Write("Text typed: ");
                //Console.WriteLine(input);
            }
        }
    }
}
