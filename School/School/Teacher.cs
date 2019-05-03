using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teacher : Employee
    {
        public string Name { get; set; }
        internal Teacher()
        {
            DailyHours = 4;
        }
        internal Teacher(int dailyHours)
        {
            DailyHours = dailyHours;
        }
        private int DailyHours { get; set; }
        public override bool IsWorking()
        {
            return (DailyHours < 8);
        }
        public new void SetWorkingHours(int hours)
        {
            base.SetWorkingHours(hours+2);
        }
        public override int GetWorkingHours()
        {
            return GetWorkingHoursFromBase();
        }
        public int GetWorkingHoursFromBase()
        {
            return WorkingHours;
        }
    }
}
