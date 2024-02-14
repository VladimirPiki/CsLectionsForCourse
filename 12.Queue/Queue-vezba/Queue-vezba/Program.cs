using System;
using System.Collections;
using System.Collections.Generic;

class Example
{
    static void PrimerZaEnqueueDequeuePeek()
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

        // Metodata Dequeue gi brisi elementite i go vrakja na objektot na pocetokot od listata
        Console.WriteLine("\nIzbrisi go '{0}'", numbers.Dequeue());

        // Metodata Peek gi prikazva elementite bez da gi izbrisi
        Console.WriteLine("Prikazi go sledniot element za brisenje: {0}",
            numbers.Peek());
        Console.WriteLine("Izbrisi go '{0}'", numbers.Dequeue());
        Console.WriteLine();
        // Prikazi gi stringovite
        Console.WriteLine("Prikazi ja listata numbers povtorno");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void Main()
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
        

        // Metodata Dequeue gi brisi elementite i go vrakja na objektot na pocetokot od listata
        Console.WriteLine("\nIzbrisi go '{0}'", numbers.Dequeue());

        // Metodata Peek gi prikazva elementite bez da gi izbrisi
        Console.WriteLine("Prikazi go sledniot element za brisenje: {0}",
            numbers.Peek());
        Console.WriteLine("Izbrisi go '{0}'", numbers.Dequeue());
        Console.WriteLine();
        // Prikazi gi stringovite
        Console.WriteLine("Prikazi ja listata numbers povtorno");
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        // Create a copy of the queue, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

        Console.WriteLine("\nContents of the first copy:");
        foreach (string number in queueCopy)
        {
            Console.WriteLine(number);
        }

        // Create an array twice the size of the queue and copy the
        // elements of the queue, starting at the middle of the
        // array.
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        // Create a second queue, using the constructor that accepts an
        // IEnumerable(Of T).
        Queue<string> queueCopy2 = new Queue<string>(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach (string number in queueCopy2)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
            queueCopy.Contains("four"));

        Console.WriteLine("\nqueueCopy.Clear()");
        queueCopy.Clear();
        Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);



        // Creates and initializes the source Queue.
        Queue mySourceQ = new Queue();
        mySourceQ.Enqueue("three");
        mySourceQ.Enqueue("napping");
        mySourceQ.Enqueue("cats");
        mySourceQ.Enqueue("in");
        mySourceQ.Enqueue("the");
        mySourceQ.Enqueue("barn");

        // Creates and initializes the one-dimensional target Array.
        Array myTargetArray = Array.CreateInstance(typeof(string), 15);
        myTargetArray.SetValue("The", 0);
        myTargetArray.SetValue("quick", 1);
        myTargetArray.SetValue("brown", 2);
        myTargetArray.SetValue("fox", 3);
        myTargetArray.SetValue("jumps", 4);
        myTargetArray.SetValue("over", 5);
        myTargetArray.SetValue("the", 6);
        myTargetArray.SetValue("lazy", 7);
        myTargetArray.SetValue("dog", 8);

        // Displays the values of the target Array.
        Console.WriteLine("The target Array contains the following (before and after copying):");
        PrintValues(myTargetArray, ' ');

        // Copies the entire source Queue to the target Array, starting at index 6.
        mySourceQ.CopyTo(myTargetArray, 6);

        // Displays the values of the target Array.
        PrintValues(myTargetArray, ' ');

        // Copies the entire source Queue to a new standard array.
        Object[] myStandardArray = mySourceQ.ToArray();

        // Displays the values of the new standard array.
        Console.WriteLine("The new standard array contains the following:");
        PrintValues(myStandardArray, ' ');
    }

    public static void PrintValues(Array myArr, char mySeparator)
    {
        foreach (Object myObj in myArr)
        {
            Console.Write("{0}{1}", mySeparator, myObj);
        }
        Console.WriteLine();
    }
}


/* This code example produces the following output:

one
two
three
four
five

Dequeuing 'one'
Peek at next item to dequeue: two
Dequeuing 'two'

Contents of the first copy:
three
four
five

Contents of the second copy, with duplicates and nulls:



three
four
five

queueCopy.Contains("four") = True

queueCopy.Clear()

queueCopy.Count = 0
 */