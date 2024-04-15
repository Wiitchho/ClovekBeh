using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{

    class Clovek
    {
        /// <summary>
        /// Celé jméno
        /// </summary>
        private string jmeno;

        /// <summary>
        /// Věk
        /// </summary>
        private int vek;

        /// <summary>
        /// Únava
        /// </summary>
        private int unava = 0;

        // Zde dokonči úlohu svým kódem...

        public Clovek(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }

        public int Beh(int vzdalenost)
        {
            if(unava < 20)
            {
                return unava += vzdalenost;
            }
            else
            {
                Console.WriteLine("Jsem příliš unavený");
                return unava;
            }
        }
        public int Spanek(int spanek)
        {
            return unava -= spanek;
        }

        public override string ToString()
        {
            return string.Format($"{jmeno}({vek})");
        }
    }

}
