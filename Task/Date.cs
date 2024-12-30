using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task
{
    internal class Date
    {
        public string day;
        public string month;
        public string year;

        public Date(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
        }
    }
}