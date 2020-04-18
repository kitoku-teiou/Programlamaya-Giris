using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongu13katlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // i değişken değeri 100 olarak belirledik
            for (int i = 100; i > 0; i--) // 100'den geriye birer birer azalacak
            {
                if (i%13==0) // i değişkeni birer birere azalırken 
                             //13 ile bölümünden kalan 0 ise yazdıracak
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
