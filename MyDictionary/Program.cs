using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> Persons = new MyDictionary<string, int>();
            Persons.Add("Ahmet" ,51);
            Persons.Add("mAHMUT",48);

            Persons.toList();

        }
    }
}
