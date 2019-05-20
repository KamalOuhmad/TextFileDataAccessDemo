using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string Files = @"C:\Demo\Test.txt";

            //List<string> Lines = File.ReadAllLines(Files).ToList();

            //foreach ( string line in Lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Lines.Add("Hassan, Lywaj, wwww.Yahoo.com");
            //File.WriteAllLines(Files, Lines);

            List<Person> People = new List<Person>();

            List<string> Lines = File.ReadAllLines(Files).ToList();

            foreach (var line in Lines)
            {
                string[] entries = line.Split(',');

                Person newperson = new Person();
                newperson.FirstName = entries[0];
                newperson.LastName = entries[1];
                newperson.URL = entries[2];

                People.Add(newperson);

            }

            Console.WriteLine("Reading");

            foreach (var person in People)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}:{person.URL}");
            }
            People.Add(new Person { FirstName = "Greg", LastName = "Houston", URL = "www.google.com" });
            

            List<string> output = new List<string>();
            
            foreach( var person in People)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.URL}");
            }

            Console.WriteLine("Writing");

            File.WriteAllLines(Files, output);

            Console.WriteLine("Everything is done");

            
            Console.ReadLine();
        }
    }
}
