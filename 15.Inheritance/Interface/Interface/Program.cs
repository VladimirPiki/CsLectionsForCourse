using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IKarkateri
{
    int BrojNaKarakteri(string str);
}
class Karakteri : IKarkateri
{
    public int BrojNaKarakteri(string str)
    {
        //ovde pisuvate kod
        return 8;
    }
}

interface IStringovi
{
    int Podstringovi(string sstr, string str);
}
class Stringovi : IStringovi
{
    public int Podstringovi(string sstr, string str)
    {
        return 5;
    }
}

class Obrabotka : IStringovi, IKarkateri
{
    Stringovi obj1 = new Stringovi();
    Karakteri obj2 = new Karakteri();

    public int Podstringovi(string sstr, string str)
    {
        return obj1.Podstringovi(sstr, str);
    }

    public int BrojNaKarakteri(string str)
    {
        return obj2.BrojNaKarakteri(str);
    }
}

namespace Nasleduvanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrabotka obj = new Obrabotka();
            Console.WriteLine(obj.BrojNaKarakteri("asdfasdfasdfasd"));
            Console.WriteLine(obj.Podstringovi("asd", "asdasdfasfdasa"));

        }
    }
}
