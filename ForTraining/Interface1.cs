using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining
{
    interface ISpecialBenefit2
    {
        int Stock();
        bool Travel();
        bool Tel();
    }

    interface IGeneral2
    {
        int Salary { get; }

        int Bonus();
    }
}
