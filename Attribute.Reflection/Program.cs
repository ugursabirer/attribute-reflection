using System;
using System.Linq;

namespace Attribute.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass));

            Ogrenci o = new Ogrenci();
            o.GetType().GetProperties().ToList().ForEach(p =>
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.PropertyType);
            });

            Ogrenci o1 = new Ogrenci();
            o1.GetType().GetProperties().ToList().ForEach(m =>
            {
                if(m.Name == "MaasHesapla")
                {
                    var sonuc = m.Invoke(o1, new object[] { 3, 5 });
                    Console.WriteLine(sonuc);
                }
            });
        }

        private static void PrintAuthorInfo(System.Type t)
        {
            System.Attribute[] attributes = System.Attribute.GetCustomAttributes(t);

            foreach (System.Attribute attr in attributes)
            {
                if(attr is Author)
                {
                    Author author = (Author)attr;
                    Console.WriteLine("{0}, version {1:f}", author.GetName(), author.Version);
                }
            }
        }
    }
}
