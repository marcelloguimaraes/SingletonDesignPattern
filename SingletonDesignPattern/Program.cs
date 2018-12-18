using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Cadeira cadeira_1 = Cadeira.Instance;
            cadeira_1.Qtd = 5;

            Cadeira cadeira_2 = Cadeira.Instance;
            cadeira_2.Qtd = 10;

            Console.WriteLine(cadeira_1.Qtd.ToString());
            Console.WriteLine(cadeira_2.Qtd.ToString());

            Console.ReadLine();
        }
    }
}
