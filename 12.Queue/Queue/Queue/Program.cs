using System;
using System.Collections;
using System.Collections.Generic;

class Example
{
    
    // Queue pretstavuva kolekcija na FIFO(first-in, first-out) znaci prv vnesen, prv izvlecen od kolekcijata. Vo ova kolekcija sekoj element se dodava na krajot od listata i se brisi prviot vnesen element. Narodski kazano prv dojden prv usluzen.
    static void PrimerZa_EnqueueDequeuePeekClear()
    {
        // Metodata Enqueue sluzi za dodavanje na elemnti na krajot od listata
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        Console.WriteLine("Prikazi ja listata numbers");
        // Prikazi gi stringovite
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        // Metodata Dequeue go brisi  prviot vnesen element vo listata i go vrakja objektot na pocetokot od listata
        Console.WriteLine("\nIzbrisi (Dequeue) go  '{0}'", numbers.Dequeue());

        // Metodata Peek gi prikazva elementite bez da gi izbrisi
        Console.WriteLine("Prikazi (Peek) go sledniot element za brisenje: {0}",
            numbers.Peek());
        Console.WriteLine("Izbrisi (Dequeue)  go '{0}'", numbers.Dequeue());
        Console.WriteLine();    
        // Prikazi gi stringovite
        Console.WriteLine("Prikazi ja listata numbers povtorno");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }


        //Metodata Clear gi brisi site elementi od listata Queue
        Console.WriteLine("\n Metodata Clear() gi brisi site elementi od numbers");
        numbers.Clear();
        Console.WriteLine("\n Listata numbers ima: {0}", numbers.Count + " elementi");
    }

    //Metodata Contains proveruva dali nekoj element go ima vo listata
   static void PrimerZa_Contains()
    {
        Queue<string> iminja = new Queue<string>();
        iminja.Enqueue("Vladimir");
        iminja.Enqueue("Vlade");
        iminja.Enqueue("Vladimir");
        iminja.Enqueue("vlade");
        iminja.Enqueue("vlatko");

        Console.WriteLine("Vnesete ime i proverete dali postoj");
        string ime =Console.ReadLine(); 
        if(iminja.Count > 0)
        {
            if (iminja.Contains(ime))
            {
                Console.WriteLine("Imeto: " + ime + " postoj vo listata.");
            }else { Console.WriteLine("Imeto: " + ime + " nepostoj vo listata"); }
        }
    }

    //CopyTo() - Gi kopira site elementi od kolekcijata Queue. Potoa gi vnesuva site kopirani elementi vo ednodimenzionalna niza pocnuvajki od pozicijata koja ke ja vnesime kako vlezen parametar, vednas do imeto na ednodimenzionalnata niza.
    static void PrimerZa_CopyTo()
    { // Kreirame Queue
        Queue myq = new Queue();

        // Dodavame elements vo Queue
        myq.Enqueue("A");
        myq.Enqueue("B");
        myq.Enqueue("C");
        myq.Enqueue("D");

        // Kreirame eddno dimenzionalna niza so brojot na elementi vo nea.
        string[] arr = new string[6];

        // Dodavame vo nizata 
        arr[0] = "HTML";
        arr[1] = "PHP";
        arr[2] = "Java";
        arr[3] = "Python";
        arr[4] = "C#";
        arr[5] = "OS";

        Console.WriteLine("\n Prikazi gi elementite od Queue : ");

        // Prikazigi elementite od myq
        foreach (string obj in myq)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("\n Prikazi gi elementite od ednodimenzionalnata niza : ");

        // Prikazigi elementite od  arr
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("pozicija: {0}    vrednost: {1}", i, arr[i]);
        }


        // Kopiraj gi site elementi od Queue, vnesi go imeto na nizata kaj so sakas da se kopira i na koja pozicija sakas da se vmetnat kopiranite od queue
        myq.CopyTo(arr, 2);

        Console.WriteLine("\n Prikazi gi elementite od Queue, posle metodata CopyTo :  ");

        // Prikazigi elementite od myq
        foreach (string obj in myq)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("\n Prikazi gi elementite od ednodimenzionalnata niza, posle metodata CopyTo : ");

        // Prikazigi elementite od  arr
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("pozicija: {0}    vrednost: {1}", i, arr[i]);
        }
    }


    // Equals(Object) - dali objektot e ednakov na tekovniot objekt. Vrakja true ili false, ako e ednakov  vrakja true ako ne e vrakja false.
    static void PrimerZa_Equals()
    {
        // Kreirame Queue so ime q1
        Queue q1 = new Queue();

        // Dodavame elementi vo Queue
        q1.Enqueue("C");
        q1.Enqueue("C++");
        q1.Enqueue("Java");
        q1.Enqueue("C#");

        // Kreirame Queue so ime q2
        Queue q2 = new Queue();

        q2.Enqueue("HTML");
        q2.Enqueue("CSS");
        q2.Enqueue("PHP");
        q2.Enqueue("SQL");

        // Provervame dali q1 e ednakva so q2
        Console.WriteLine("Primer 1: "+q1.Equals(q2));

        // Kreirame nova Queue
        Queue q3 = new Queue();

        // Gi dodavame site vrednosti od q3 vo q2
        q3 = q2;

        // Provervame dali e q3 ista so q2
        Console.WriteLine("Primer 2: "+q3.Equals(q2));
    }

    public static void Main()
    {
        //Primer za metodite Enqueue, Dequeue,Peek i Clear
         PrimerZa_EnqueueDequeuePeekClear();

        //Primer za metodata Contains
         PrimerZa_Contains();

        //PrimerZa_CopyTo();
        PrimerZa_Equals();
    }
}
