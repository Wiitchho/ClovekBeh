using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Clovek karel = new Clovek("Karel Nový", 25);

            // Zde dokonči úlohu svým kódem...
            Console.WriteLine(karel);
            karel.Beh(10);
            karel.Beh(10);
            karel.Spanek(0);
            karel.Beh(10);
            Console.ReadKey();
        }
    }
}
