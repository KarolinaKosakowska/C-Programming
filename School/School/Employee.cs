using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal abstract class Employee
    {
        public DateTime EmploymentDate { get; private set; } //= new DateTime(2000, 1, 1);
        // private int workingHours;
        protected int WorkingHours { get; private set; }

        //{
        //    get
        //    {
        //        if (workingHours > 0)
        //        {
        //            return workingHours;
        //        }
        //        return int.MinValue;
        //    }
        //    private set
        //    {
        //        if (workingHours > 0)
        //        {
        //            workingHours = value;
        //        }
        //        else
        //        {
        //            workingHours = -1;
        //        }
        //    }
        //}

        public void SetWorkingHours(int workingHours)
        {
            if (workingHours > 6 && workingHours < 13)
            {
                WorkingHours = workingHours;
            }

        }
        //<summary>
        //Ta metoda ustawia komentarz
        //</summary>
        public void SetEmploymentDate(DateTime value)
        {
            DateTime defaultDate = new DateTime(2000, 1, 1);
            if (value > defaultDate)
            {
                EmploymentDate = value;
            }
            else
                EmploymentDate = defaultDate;

            //EmploymentDate = value > EmploymentDate ? value : EmploymentDate;

                    
        }
        public abstract bool IsWorking();
        public virtual int GetWorkingHours()   
        {
            return 0;
        }
        public virtual int GetWorkingHours(string dayName)
        {
            return 0;
        }
        public virtual int GetWorkingHours(string dayName, DateTime from)
        {
            return 0;
        }
    }
}
