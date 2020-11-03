using Wave.Cmr;
using Wave.Cmr.Font;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaveClient
{
    public static class WaveClientConsole
    {
        public static void Start(string[] args)
        {
            cmr.MaximizeConsole();
            cmr_font.SetConsoleFont("Cascadia Code", 12, 24);
            Console.WriteLine($"{cmr.cf(89, 122, 255)}Welcome to WaveClient!");
            Console.WriteLine($"{cmr.cf(200, 200, 200)}Thanks for using it :D");
            Thread.Sleep(1000);
            cmr.MinimizeConsole();
            cmr.clogl($"{cmr.cf(100, 108, 143)}WaveClient", "Loading Modules");
            Thread.Sleep(100);
            ModuleManagment.ModuleManager.MemoryUpdate.StartTickThread();
            cmr.clogl($"{cmr.cf(100, 108, 143)}WaveClient", "Being cool");
        }

        public static class Application
        {
            public static Thread ConsoleThread;

            public static string[] args = Environment.GetCommandLineArgs();

            public static void InitializeThread()
            {
                ConsoleThread = new Thread(new ThreadStart(ConsoleMain));
                ConsoleThread.SetApartmentState(ApartmentState.STA);
                ConsoleThread.Start();
            }

            public static void ConsoleMain()
            {
                Start(args);
            }
        }
    }
}
