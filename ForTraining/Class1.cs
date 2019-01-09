using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining
{
    interface ISpecialBenefit
    {
        int Stock();
        bool Travel();
        bool Tel();
    }

    interface IGeneral
    {
        int Salary { get; }

        int Bonus();
    }
    abstract class Employee : ISpecialBenefit, IGeneral
    {
        // From General
        public abstract int Bonus();
        public abstract int Salary { get; set; }

        // From SpecialBenefit
        public abstract int Stock();
        public abstract bool Tel();
        public abstract bool Travel();

        // special feature.
        public virtual int AnnualLeave(int i)
        {
            return i;
        }

    }

    class Engineer : Employee
    {
        public override int Bonus()
        {
            int x = int.MinValue;
            return x;
        }

        public override int Salary
        {
            get
            {
                return xSalary;
            }
            set
            {
                xSalary = value;
            }
        }
        private int xSalary = int.MinValue;
        public override int Stock()
        {
            int x = 0;
            return x;
        }

        public override bool Tel()
        {
            bool x = false;
            return x;
        }

        public override bool Travel()
        {
            bool x = false;
            return x;
        }

        public override int AnnualLeave(int i)
        {
            int tempi = i;
            i = 0;
            return i;
        }
    }
}
