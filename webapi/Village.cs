using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public interface IVillage
    {
        double GetKilledAverage(List<Person> people);
    }
    public class Village : IVillage
    {
        IWitch _witch;
        public Village(IWitch witch)
        {
            _witch = witch;
        }

        public double GetKilledAverage(List<Person> people)
        {
            int count = people.Count();
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Person person = people[i];
                int bornOnYear = person.YearOfDeath - person.AgeOfDeath;
                if (bornOnYear < 1)
                {
                    return -1;
                }
                int killed = _witch.GetKilledVillagersByYear(bornOnYear);
                sum += killed;
            }
            return (double)sum / (double)count;
        }
    }
}
