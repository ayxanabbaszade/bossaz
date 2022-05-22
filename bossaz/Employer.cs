using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class Employer : User
    {
        public List<Vacancy> vacancies = new List<Vacancy>();
        List<Vacancy> SearchList = new List<Vacancy>();
        public Employee Employee { get; set; }
        public List<CV> IncomingCVs = new List<CV>();
        public List<CV> AcceptedCVs = new List<CV>();
        public List<CV> RefusedCVs = new List<CV>();
        List<CV> Favorites = new List<CV>();
        FileHelper fh;
        public Employer()
        {
            {
                Vacancy vacancy1 = new Vacancy
                {
                    VacancyName = "IT",
                    City = "Baku",
                    MinAge = 18,
                    MaxAge = 30,
                    StartTime = new DateTime(2021, 02, 20, 09, 00, 00),
                    EndTime = new DateTime(2021, 02, 20, 18, 00, 00),
                    Salary = 1000,
                    Experience = 3,
                    Email = "ayxanabb@gmail.com",
                    JobDetails = "Web developer teleb olunur. Cay ve kofe pulsuz",
                    Requirements = "HTML, CSS, JS bilikleri"
                };
                Vacancy vacancy2 = new Vacancy
                {
                    VacancyName = "IT",
                    City = "Baku",
                    MinAge = 20,
                    MaxAge = 30,
                    StartTime = new DateTime(2021, 02, 20, 09, 00, 00),
                    EndTime = new DateTime(2021, 02, 20, 18, 00, 00),
                    Salary = 5000,
                    Experience = 2,
                    Email = "ayxanabb@gmail.com",
                    JobDetails = "Web developer teleb olunur. Cay ve kofe pulsuz",
                    Requirements = "HTML, CSS, JS bilikleri"
                };
                Vacancy vacancy3 = new Vacancy
                {
                    VacancyName = "IT",
                    City = "Tovuz",
                    MinAge = 18,
                    MaxAge = 30,
                    StartTime = new DateTime(2021, 02, 20, 09, 00, 00),
                    EndTime = new DateTime(2021, 02, 20, 18, 00, 00),
                    Salary = 1000,
                    Experience = 2,
                    Email = "ayxanabb@gmail.com",
                    JobDetails = "Web developer teleb olunur. Cay ve kofe pulsuz",
                    Requirements = "HTML, CSS, JS bilikleri"
                };
                Vacancy vacancy4 = new Vacancy
                {
                    VacancyName = "Marketing",
                    City = "Baku",
                    MinAge = 18,
                    MaxAge = 30,
                    StartTime = new DateTime(2021, 02, 20, 09, 00, 00),
                    EndTime = new DateTime(2021, 02, 20, 18, 00, 00),
                    Salary = 1000,
                    Experience = 2,
                    Email = "ayxanabb@gmail.com",
                    JobDetails = "Web developer teleb olunur. Cay ve kofe pulsuz",
                    Requirements = "HTML, CSS, JS bilikleri"
                };
                vacancies.Add(vacancy1);
                vacancies.Add(vacancy2);
                vacancies.Add(vacancy3);
                vacancies.Add(vacancy4);
            }
        }

        public void showVacancies()
        {
            foreach (var item in vacancies)
            {
                Console.WriteLine(item);
            }
        }

        public Vacancy CreateVacancy(string vacancyName, string city, int minAge, int maxAge, DateTime startTime, DateTime endTime, int salary, int experience, string email, string jobDetails, string requirements)
        {
            Vacancy vacancy = new Vacancy
            {
                VacancyName = vacancyName,
                City = city,
                MinAge = minAge,
                MaxAge = maxAge,
                StartTime = startTime,
                EndTime = endTime,
                Salary = salary,
                Experience = experience,
                Email = email,
                JobDetails = jobDetails,
                Requirements = requirements
            };
            return vacancy;
        }
        public void AddVacancy(Vacancy vacancy)
        {
            vacancies.Add(vacancy);
        }
        public void DeleteVacancy(int id)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) vacancies.Remove(item);
            else throw new Exception();
        }
        public void DeleteAllVacancies()
        {
            vacancies.Clear();
        }
        public void UpdateVacancyName(int id, string vacancyName)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.VacancyName = vacancyName;
            else throw new Exception();
        }
        public void UpdateCity(int id, string city)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.City = city;
            else throw new Exception();
        }
        public void UpdateMinAge(int id, int minAge)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.MinAge = minAge;
            else throw new Exception();
        }
        public void UpdateMaxAge(int id, int maxAge)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.MaxAge = maxAge;
            else throw new Exception();
        }
        public void UpdateStartTime(int id, DateTime startTime)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.StartTime = startTime;
            else throw new Exception();
        }
        public void UpdateEndTime(int id, DateTime endTime)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.EndTime = endTime;
            else throw new Exception();
        }
        public void UpdateSalary(int id, int salary)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.Salary = salary;
            else throw new Exception();
        }
        public void UpdateExperience(int id, int experience)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.Experience = experience;
            else throw new Exception();
        }
        public void UpdateEmail(int id, string email)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.Email = email;
            else throw new Exception();
        }
        public void UpdateJobDetails(int id, string jobDetails)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.JobDetails = jobDetails;
            else throw new Exception();
        }
        public void UpdateRequirements(int id, string requirements)
        {
            var item = vacancies.Single(c => c.ID == id);
            if (item != null) item.Requirements = requirements;
            else throw new Exception();
        }


        public void Accept(Employee employee, int id)
        {
            var item = IncomingCVs.Single(c => c.ID == id);
            AcceptedCVs.Add(item);
            IncomingCVs.Remove(item);
        }
        public void Refuse(Employee employee, int id)
        {
            var item = IncomingCVs.Single(c => c.ID == id);
            RefusedCVs.Add(item);
            IncomingCVs.Remove(item);
            Console.WriteLine($"ID {ID} Refused");
        }

        public void ShowIncomingCVs()
        {
            foreach (var item in IncomingCVs)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowAcceptedCVs()
        {
            foreach (var item in AcceptedCVs)
            {
                Console.WriteLine(item);
            }
        }

        public void AddToFavoritesCV(Employee employee, int id)
        {
            var item = employee.CVs.Single(c => c.ID == id);
            if (item != null) Favorites.Add(item);
            else throw new Exception();
        }
        public void ShowFavoriteCVs()
        {
            foreach (var item in Favorites)
            {
                Console.WriteLine(item);
            }
        }
    }
}
