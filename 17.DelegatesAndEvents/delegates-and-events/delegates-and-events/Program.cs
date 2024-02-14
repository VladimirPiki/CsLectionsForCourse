using DelegatesArray;
using DelegatesInvoked;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events
{
    //Pravi varijabila od funkcijata. Делегат е решение за ситуации кога сакате да ги пренесете методите на други методи
    public class Operation
    {
        public static void Add(int a)
        {
            Console.WriteLine("Addition={0}", a + 10);
        }
        public static void Square(int a)
        {
            Console.WriteLine("Multiple={0}", a * a);
        }
    }
    class Program
    {
        //so pomos na delegate
        delegate void DelOp(int x);

        static void Main(string[] args)
        {
            // Delegate instanca
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(2);
            obj(8);

            Console.WriteLine();

            ProgramArray o = new ProgramArray();
            o.DelegateArray();
            Console.WriteLine();

            ProgramInvoked oI = new ProgramInvoked();
            oI.MainInvoked();



        }
    }
}

namespace DelegatesArray
{
    public class OperationArray
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiply={0}", a * b);
        }
    }

    class ProgramArray
    {
        delegate void DelOp(int x, int y);

        public void DelegateArray()
        {
            // Delegate instantiation
            DelOp[] obj =
           {
               new DelOp(OperationArray.Add),
               new DelOp(OperationArray.Multiple)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
            Console.WriteLine();
        }
    }
}

//Повикувањето на повеќе методи од еден делегат може да доведе до проблематична ситуација. Ако еден од методите повикани од делегат фрли исклучок, целосната итерација ќе биде прекината. Можете да избегнете такво сценарио со повторување на списокот за повикување метод. Класата Delegate дефинира метод GetInvocationList кој враќа низа од Delegate објекти.
namespace DelegatesInvoked
{
    public class OperationInvoked
    {
        public static void One()
        {
            Console.WriteLine("one display");
            throw new Exception("Error");
        }
        public static void Two()
        {
            Console.WriteLine("Two display");
        }
    }

  
    class ProgramInvoked
    {
        delegate void DelOp();

        public void MainInvoked()
        {
            // Delegate instantiation
            DelOp obj = OperationInvoked.One;
            obj += OperationInvoked.Two;

            Delegate[] del = obj.GetInvocationList();

            foreach (DelOp d in del)
            {
                try
                {
                    d();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error caught");
                }
            }
            Console.ReadLine();
        }
    }
}
