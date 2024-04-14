using HRAdministrationAPI;

namespace SchoolHRAdministration
{
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
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                Name = "Bob Fisher",
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                Name = "Jenny Thomas",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                Name = "Brenda  Mullins",
                Salary = 50000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                Name = "Damien Jones",
                Salary = 80000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster= new HeadMaster
            {
                Id = 5,
                Name = "Brenda  Mullins",
                Salary = 80000
            };
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
}