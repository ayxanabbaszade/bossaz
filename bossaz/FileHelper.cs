using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectJob
{
    class FileHelper
    {
        public void WriteEmployeesToFile(string fileName, List<Employee> employees)
            => File.WriteAllText(fileName, JsonSerializer.Serialize(employees));

        public List<Employee> ReadEmployeesFromFile(string fileName)
            => JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(fileName));

        public void WriteEmployersToFile(string fileName, List<Employer> employers)
            => File.WriteAllText(fileName, JsonSerializer.Serialize(employers));
        public List<Employer> ReadEmployersFromFile(string fileName)
            => JsonSerializer.Deserialize<List<Employer>>(File.ReadAllText(fileName));

        public void WriteVacanciesToFile(string fileName, Vacancy vacancy)
                   => File.WriteAllText(fileName, JsonSerializer.Serialize(vacancy));

        public void WriteCVsToFile(string fileName, CV cv)
                          => File.WriteAllText(fileName, JsonSerializer.Serialize(cv));

        public void WriteVacanciesToBidList(string fileName, Vacancy vacancy)
                    => File.WriteAllText(fileName, JsonSerializer.Serialize(vacancy));


    }
}
