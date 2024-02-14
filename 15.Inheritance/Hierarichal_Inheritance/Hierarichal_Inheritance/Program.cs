using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base Class
public class String
{
    public string VlezenString()
    {
        return "Vlezen string";
    }
}

// Derived Class
public class ChString : String
{
    public string PostoiKarakter()
    {
        return "Postoi karakter";
    }
}

// Derived Class
public class SubString : String
{
    public string PostoiString()
    {
        return "Postoi string";
    }
}
namespace HierarhiskoNasleduvanje
{
    class Program
    {
        static void Main(string[] args)
        {
            ChString obj = new ChString();
            SubString obj2 = new SubString();

            Console.WriteLine(obj.PostoiKarakter());
            Console.WriteLine(obj2.PostoiString());
            Console.WriteLine(obj2.VlezenString());

        }
    }
}
