using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class CV
    {
        public int ID { get; set; }
        public static int CV_ID { get; set; } = 0;
        public string Profession { get; set; }
        public string SchoolNO { get; set; }
        public int Score { get; set; }
        public string Skills { get; set; }      //List
        public string Companies { get; set; }   //List
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Languages { get; set; }   //Dictionary
        public bool Certificate { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }

        public CV()
        {
            ID = CV_ID++;
        }

        public override string ToString()
        {
            return $"CV ID: {ID}\nProfession: {Profession}\nSchool: {SchoolNO}\nScore: {Score}\nSkills: {Skills}\nCompanies: {Companies}\nStart Time: {StartTime.ToShortDateString()}\nEnd Time: {EndTime.ToShortDateString()}\nLanguages: {Languages}\nCertificate: {Certificate}\nGitHub Link: {GitHub}\nLinkedIn Link: {LinkedIn}\n\n";
        }

    }
}
