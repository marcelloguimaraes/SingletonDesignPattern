using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Cadeira
    {
        private static Cadeira instance;
        public int Qtd { get; set; }

        public static Cadeira Instance
        {
            get
            {
                if (instance == null)
                    instance = new Cadeira();

                return instance;
            }
        }

        private Cadeira() { }
    }
}
