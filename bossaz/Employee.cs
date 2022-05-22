using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class Employee : User
    {
        public List<CV> CVs = new List<CV>();
        public List<Vacancy> BidList = new List<Vacancy>();
        public Employer employer { get; set; }
        List<Vacancy> FavoriteVacancies = new List<Vacancy>();
        FileHelper fh = new FileHelper();
        public List<string> Nottifications = new List<string>();
        public Employee()
        {
            {
                CV cv1 = new CV
                {
                    Profession = "Cyber Security",
                    SchoolNO = "THL",
                    Score = 522,
                    Skills = "C++, C#",
                    Companies = "Step IT",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    Languages = "Azerbaijani,English,Turkish",
                    Certificate = true,
                    GitHub = "github.com/ayxanabb",
                    LinkedIn = "linkedin.com/ayxanabb"
                };
                CV cv2 = new CV
                {
                    Profession = "Cyber Security2",
                    SchoolNO = "THL2",
                    Score = 522,
                    Skills = "C++, C#",
                    Companies = "Step IT",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    Languages = "Azerbaijani,English,Turkish",
                    Certificate = true,
                    GitHub = "github.com/ayxanabb",
                    LinkedIn = "linkedin.com/ayxanabb"
                };
                CVs.Add(cv1);
                CVs.Add(cv2);
            }
        }

        public void showCVs()
        {
            foreach (var item in CVs)
            {
                Console.WriteLine(item);
            }

        }

        public void Bid(Employer employer, int id, int idVac)
        {
            var item = CVs.SingleOrDefault(c => c.ID == id);
            if (item != null)
            {
                foreach (var itemVac in employer.vacancies)
                {
                    if (idVac == itemVac.ID)
                    {
                        BidList.Add(itemVac);
                        fh.WriteVacanciesToBidList("BidList.json", itemVac);
                    }
                };
                employer.IncomingCVs.Add(item);
            }
            else throw new Exception();
        }
        public void RemoveBid(int idVac)
        {
            var item = BidList.Single(c => c.ID == idVac);
            if (item != null) BidList.Remove(item);
            else throw new Exception();
        }
        public void ShowBidList()
        {
            foreach (var item in BidList)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowNottifications()
        {
            foreach (var item in Nottifications)
            {
                Console.WriteLine(item);
            }
        }

        public void AddCV(CV cv)
        {
            CVs.Add(cv);
        }
        public CV CreateCV(string profession, string school, int score, string skills, string companies, DateTime startTime, DateTime endTime, string languages, bool certificate, string github, string linkedin)
        {
            CV cv = new CV
            {
                Profession = profession,
                SchoolNO = school,
                Score = score,
                Skills = skills,
                Companies = companies,
                StartTime = startTime,
                EndTime = endTime,
                Languages = languages,
                Certificate = certificate,
                GitHub = github,
                LinkedIn = linkedin
            };
            return cv;
        }
        public void DeleteCV(int id)
        {
            var item = CVs.Single(c => c.ID == id);
            if (item != null) CVs.Remove(item);
            else throw new Exception();
        }

        public void AddToFavoritesVacancy(Employer employer, int id)
        {
            var item = employer.vacancies.Single(v => v.ID == id);
            if (item != null) FavoriteVacancies.Add(item);
            else throw new Exception();
        }
    }
}