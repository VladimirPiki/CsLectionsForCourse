using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable = new Hashtable();

            // Adding key/value pair in the hashtable 
            // Using Add() method 
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "GeeksforGeeks");
            my_hashtable.Add(4, "GeeksforGeeks");

            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
        }
    }
}
