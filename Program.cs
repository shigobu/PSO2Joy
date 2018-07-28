using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PSO2とJoy同時起動
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PSO2とJoyToKeyの同時起動");
            Console.WriteLine("PSO2の起動");

            try
            {
                if (Process.GetProcessesByName("pso2").Length > 0)
                {
                    Console.WriteLine("PSO2はすでに起動しています。");
                }
                else
                {
                    Process p = System.Diagnostics.Process.Start(@"D:\SEGA\PHANTASYSTARONLINE2\pso2_bin\pso2launcher.exe");
                }

                Console.WriteLine("XtoDpadの起動");
                if (Process.GetProcessesByName("XtoDpad").Length > 0)
                {
                    Console.WriteLine("XtoDpadはすでに起動しています。");
                }
                else
                {
                    Process q = System.Diagnostics.Process.Start(@"D:\茂信\Documents\Visual Studio 2017\Projects\XtoDpad\bin\x64\Release\XtoDpad.exe");
                }

                Console.WriteLine("アナログ時計の起動");
                if (Process.GetProcessesByName("アナログ時計だほっとけい").Length > 0)
                {
                    Console.WriteLine("アナログ時計はすでに起動しています。");
                }
                else
                {
                    Process q = Process.Start(@"D:\茂信\Documents\Visual Studio 2015\Projects\アナログ時計だほっとけい\bin\x64\Release\アナログ時計だほっとけい.exe", "/touka /minHand /secHand /date /Opacity 60 /size 400");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("例外がスローされました");
                Console.WriteLine(e.Message);
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
