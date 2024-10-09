using EMAILS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Email

{ //konstruktor, list lidí
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string currentDirectory = "Emaily.txt";
            List<string> emails = new List<string>();
            emails = File.ReadAllLines(currentDirectory).ToList();

            foreach (string email in emails)
            {
                Person person = new Person(email);
            }
            Console.Read();
        }
    }
}