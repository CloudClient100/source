using Wave.Cmr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveClient
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            cmr.EnableVirtualTerminalProcessing();
            Console.Title = "WaveClient";
            WaveClientConsole.Application.InitializeThread();
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
