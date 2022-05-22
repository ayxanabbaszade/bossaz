using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class Menu
    {
        public static void PrintMenuForEmployers()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Show your vacancies");
            Console.WriteLine("2.Create new vacancy");
            Console.WriteLine("3.Delete vacancy");
            Console.WriteLine("4.Show all employees");
            Console.WriteLine("5.Incoming CVs");
            Console.WriteLine("6.Accepted CVs");
            Console.WriteLine("0.Exit");
        }
        public static void PrintMenuForEmployees()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Show your CV(s)");
            Console.WriteLine("2.Create new CV");
            Console.WriteLine("3.Delete CV");
            Console.WriteLine("4.Show vacancies");
            Console.WriteLine("5.Show Bid list");
            Console.WriteLine("6.Remove Bid");
            Console.WriteLine("7.Nottifications");
            Console.WriteLine("0.Exit");
        }
        public static void PrintVacancyAndCVMenu()
        {
            Console.WriteLine("1.Bid");
            Console.WriteLine("0.Exit");
        }
        public static void PrintCategories()
        {
            Console.WriteLine("1.IT");
            Console.WriteLine("2.Marketing");
            Console.WriteLine("3.Design");
            Console.WriteLine("4.Business");
            Console.WriteLine("5.Writing");
        }
        public static void PrintCities()
        {
            Console.WriteLine("1.Baku");
            Console.WriteLine("2.Ganja");
            Console.WriteLine("3.Sumgait");
            Console.WriteLine("4.Kazakh");
            Console.WriteLine("5.New York");
            Console.WriteLine("6.Los Angeles");
            Console.WriteLine("7.Manchester");
        }
        public static void PrintAcceptRefuseMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1.Accept");
            Console.WriteLine("2.Refuse");
        }
        public static void UpdateMenuForVacancy()
        {
            Console.WriteLine("1.Update category");
            Console.WriteLine("2.Update city");
            Console.WriteLine("3.Update minimum age");
            Console.WriteLine("4.Update maximum age");
            Console.WriteLine("5.Update start time");
            Console.WriteLine("6.Update end time");
            Console.WriteLine("7.Update salary");
            Console.WriteLine("8.Update experience");
            Console.WriteLine("9.Update email");
            Console.WriteLine("10.Update job details");
            Console.WriteLine("11.Update requirements");
            Console.WriteLine("0.Exit");
        }
    }
}
