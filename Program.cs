using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.NET_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Lütfen soyadınızı giriniz:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Lütfen cinsiyetinizi (E/K) formatında giriniz:");
            char gender = Console.ReadLine().ToLower()[0];
            
            Console.WriteLine("Lütfen telefon numaranızı giriniz:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Lütfen doğum tarihinizi (GG/AA/YYYY) formatında giriniz:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
                age--;

            int weeksInMonth = age >= 21 ? 5 : 6;
            int daysInWeek = age >= 21 ? 8 : 6;

            Console.WriteLine("Lütfen kaç gün sonra işiniz olduğunu giriniz:");
            int days = int.Parse(Console.ReadLine());

            DateTime futureDate = DateTime.Now.AddDays(days);

            string genderText = gender.ToString().ToLower() == "e" ? "Bey" : "Bayan";

            Console.WriteLine($"Sayın {firstName} {lastName} isimli {genderText} {age} yaşındasınız. {futureDate.Month}. ayının {((futureDate.Day - 1) / daysInWeek + 1)}. gününde işiniz bulunmaktadır.");
            
            Console.ReadLine();
        }
    }
}
