using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class Vacancy
    {
        public int ID { get; set; }
        public static int Vacancy_ID { get; set; }

        public string VacancyName { get; set; }
        public string City { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }
        public string JobDetails { get; set; }
        public string Requirements { get; set; }
        public int ViewCount { get; set; }
        public Vacancy()
        {
            ID = Vacancy_ID++;
        }

        public static Vacancy operator ++ (Vacancy vacancy)
        {
            vacancy.ViewCount++;
            return vacancy;
        }
        

        public override string ToString()
        {
            return $"Vacancy ID: {ID}\nVacancy Name: {VacancyName}\nCity: {City}\nAge Range: {MinAge} - {MaxAge}\nWork Hours: {StartTime.ToShortTimeString()} - {EndTime.ToShortTimeString()}\nSalary: {Salary}\nExperience: {Experience} year(s)\nEmail: {Email}\nJob Details: {JobDetails}\nRequirements: {Requirements}\nView Count: {ViewCount}\n";
        }

    }
}
