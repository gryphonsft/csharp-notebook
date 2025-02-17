using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısmaNotlarim
{
    
    internal class Enum101
    {
        enum Aylar
        {
            Ocak,
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }
       public static void Enums()
        {
            foreach (string ayadı in Enum.GetNames(typeof(Aylar)))
            {
                Console.WriteLine(ayadı);
            }
            Console.ReadKey();
        }
    }
}
