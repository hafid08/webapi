using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public interface IWitch
    {
        int GetKilledVillagersByYear(int year);
    }
    public class Witch : IWitch
    {

        public int GetKilledVillagersByYear(int year)
        {
            int result = 0;
            int _2nd = 0;
            int _1st = 0;
            for (int i = 1; i <= year; i++)
            {
                if (i == 1)
                {
                    _1st = i;
                }
                else
                {
                    int item = _2nd + _1st;
                    _2nd = _1st;
                    _1st = item;
                }
                result += _1st;
            }
            return result;
        }
    }
}
