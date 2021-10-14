using System;

namespace EmpWage
{
   public class TotEmpWageOfComp
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public void EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
        this.company=company;
        this.empRatePerHour=empRatePerHour;
        this.numOfWorkingDays=numOfWorkingDays;
        this.maxHoursPerMonth=maxHoursPerMonth;
        }

        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + totalEmpWage;
        }
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            TotEmpWageOfComp dMart = new TotEmpWageOfComp();
            dMart.EmpWageBuilderObject("DMART", 20, 2, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());

            TotEmpWageOfComp reliance = new TotEmpWageOfComp();
            reliance.EmpWageBuilderObject("RELIANCE", 10, 4, 20);
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }

    }

