namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilerArray empWageBuilerArray = new EmpWageBuilerArray();

            empWageBuilerArray.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilerArray.addCompanyEmpWage("Reilance", 10, 4, 20);

            empWageBuilerArray.computeEmpWage();
        }
    }
}
