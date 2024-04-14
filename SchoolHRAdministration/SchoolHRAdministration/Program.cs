using HRAdministrationAPI;

namespace SchoolHRAdministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster
    }
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            /*foreach (var employee in employees)
            {
                totalSalaries += employee.Salary;
            }*/
            Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob Fisher", 40000);           
            employees.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny Thomas", 40000);
            employees.Add(teacher2);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda  Mullins", 50000);
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Damien Jones", 80000);
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Brenda Mullins", 80000);
            employees.Add(headMaster);

        }
    }

    public class Teacher : BaseEmployee
    { 
        private decimal _baseSalary;
        private decimal _salary;

        public override decimal Salary
        {
            get => _salary;
            set
            {
                _baseSalary = value;
                // Calculate the salary with the additional 2% increase
                _salary = _baseSalary + (_baseSalary * 0.02m);
            }
        }
    }


    public class HeadOfDepartment : BaseEmployee
    {
        private decimal _baseSalary;
        private decimal _salary;

        public override decimal Salary
        {
            get => _salary;
            set
            {
                _baseSalary = value;
                // Calculate the salary with the additional 2% increase
                _salary = _baseSalary + (_baseSalary * 0.02m);
            }
        }

    }
    public class DeputyHeadMaster : BaseEmployee
    {
        private decimal _baseSalary;
        private decimal _salary;

        public override decimal Salary
        {
            get => _salary;
            set
            {
                _baseSalary = value;
                // Calculate the salary with the additional 2% increase
                _salary = _baseSalary + (_baseSalary * 0.02m);
            }
        }
    }
    public class HeadMaster : BaseEmployee
    {
        private decimal _baseSalary;
        private decimal _salary;

        public override decimal Salary
        {
            get => _salary;
            set
            {
                _baseSalary = value;
                // Calculate the salary with the additional 2% increase
                _salary = _baseSalary + (_baseSalary * 0.02m);
            }
        }
    }

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string name, decimal salary)
        {
            IEmployee employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                    break;

                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                    break;

                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                    break;

                case EmployeeType.HeadMaster:
                    employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                    break;

                default:
                    break;
            }

            if (employee  != null)
            {
                employee.Id = id;
                employee.Name = name;
                employee.Salary = salary;
            }
            else
            {
                throw new NullReferenceException();
            }
            return employee;
        }
    }
}
