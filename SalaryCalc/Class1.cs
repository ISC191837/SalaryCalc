using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalc
{
    public class Calculator
    {
        public float getSalaryByHours(int hoursWorked, float paidByHours)
        {
            float result = 0;

            if (hoursWorked > 30)
            {
                result = paidByHours * 30;
                result = result + ((paidByHours * 2) * (hoursWorked - 30));
            } 
            else
            {
                result = hoursWorked * paidByHours;
            }

            return result;
        }

        public string getTaxString(float salary)
        {
            if(hasTax(salary))
            {
                return "15%";
            }
            else
            {
                return "10%";
            }
        }

        public float getTax(float salary)
        {
            float result;
            if (hasTax(salary))
            {
                result = (float)(salary * 0.15);
            }
            else
            {
                result = (float)(salary * 0.10);
            }

            return result;
        }
        
        public bool hasTax(float salary)
        {
            if (salary > 3000)
            {
                return true;
            }

            return true;
        }
    }
}
