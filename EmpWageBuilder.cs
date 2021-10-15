using System;

namespace EmpWage
{
    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public void  EmpWageBuilderArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, computeEmpWage);

        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWageArray.setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(companyEmpWageArray.toString());
            }
        }


        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
         public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMART", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("RELIANCE", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart:" + empWageBuilder.getTotalWage("DMart"));
        }
    }

    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);

    }

    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
        this.company=company;
        this.empRatePerHour=empRatePerHour;
        this.numOfWorkingDays=numOfWorkingDays;
        this.maxHoursPerMonth=maxHoursPerMonth;
    }

    public void setTotalEmpWage(int totalEmpWage)
        {
            this.setTotalEmpWage = totalEmpWage;
        }

    public void toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + totalEmpWage;
        }
    }
}





