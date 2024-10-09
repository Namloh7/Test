using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EMAILS
{
    internal class Person
    {
        public string Email;
        public string Name;
        public string Surname;
        public string Mailserver;
        public string Domain;
        public int? Age;
        public Person(string email)
        {
            this.Email = email; 
            DataFromEmail();
        }
        private void PrintInfo()
        {
            //Console.WriteLine("Your name. " + Name);
            //Console.WriteLine("Your surname. " + Surname);
            //Console.WriteLine("Your mailserver: " + Mailserver);
            //Console.WriteLine("Your domain: " + Domain);
            //if (Age != null) Console.WriteLine("Your age: " + Age);
            //Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        }
        private void DataFromEmail()
        {
            string[] parts = this.Email.Split('@');
            string ndPart = parts[1];
            string stPart = parts[0];

            string number = Regex.Replace(this.Email, @"\D", "");
            bool hasValidNumber = int.TryParse(number, out int intnum);

            string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            this.Name = names[0];
            this.Surname = names[1];

            string[] DomainMS = ndPart.Split('.');
            this.Mailserver = DomainMS[0];
            this.Domain = DomainMS[1];

            if (hasValidNumber && intnum >= DateTime.Now.Year - 100 && intnum <= DateTime.Now.Year)
            {
                this.Age = DateTime.Now.Year - intnum;
            }
            PrintInfo();
        }
    }
}
        