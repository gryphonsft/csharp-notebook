using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısmaNotlarim
{
    
    internal class Enum
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
            int ayno;
            Console.Write("Ay numarası:");
            ayno = Convert.ToInt32(Console.ReadLine());
            Aylar ay = (Aylar)ayno;
            Console.WriteLine("Girilen değere karşılık gelen ay: "+ay);
            Console.ReadLine();

        }
    }
}
