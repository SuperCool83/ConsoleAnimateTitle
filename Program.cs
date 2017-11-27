using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {

           
        // can make console window shrink or grow with this.
                //for (int i = 52; i > 40; i--)
                //{
                //    Console.SetWindowSize(i, i);
                //    System.Threading.Thread.Sleep(50);
                //}

            string Progresbar = "SuperCool83 animated title to the console.            ";
            var title = "";
            while (true)
            {
                for (int i = 0; i < Progresbar.Length; i++)
                {
                    title += Progresbar[i];
                    Console.Title = title;
                    Thread.Sleep(100);
                }
                title = "";
            }

             

            
        }
    }
}
