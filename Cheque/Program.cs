using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheques.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cheque cheque = new Cheque();

            //string msg = cheque.ColocandoOReal("34.50");

            //Console.WriteLine(msg);
            //Console.ReadLine();

            string valor = "12309";
            Console.WriteLine(valor.All(char.IsDigit));

        }
    }
}
