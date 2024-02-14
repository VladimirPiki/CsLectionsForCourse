using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_space;
using first_space;

namespace first_space
{

    class namespace_cl
    {

        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{

    class namespace_cl
    {

        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            namespace_cl fc = new namespace_cl();

            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();
        }
    }
}