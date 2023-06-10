using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;


namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Calc c = Calc.GetCalcInstance();
                c.Start();
                Thread.Sleep(5000);
                c.Stop();
                c.GetDuration();
                c.GetDuration();
                c.GetDuration();
                c.Start();
                c.GetDuration();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            

        }
    }
}
