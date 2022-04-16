using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute.Reflection
{
    public class Ogrenci
    {
        public string OgrenciNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public double MaasHesapl(int saat, double ucret) => saat * ucret;
    }
}
