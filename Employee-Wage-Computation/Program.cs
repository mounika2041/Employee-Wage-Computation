using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
     public class EmpWageBuilderObject
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public  EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmPHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmPHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmPHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            totalEmpWage = totalEmPHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company :" + company + "is:" + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company:" + this.company + "is:" + this.totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmpWageBuilderObject Dmart =new EmpWageBuilderObject("DMart", 20, 10, 10);
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("tcs", 10, 15, 20);
            Dmart.computeEmpWage();
            Console.WriteLine(Dmart.toString());
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());
            Console.ReadLine();
        }
    }
}
