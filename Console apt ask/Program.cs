using System.Net.Cache;

namespace Console_apt_ask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit=false;
           do 
            {
                Console.WriteLine("salam 6 bazari burnundan gelmis telebenin taskinin menyusunu gorursunuz");
                Console.WriteLine("zehmet olmazsa sechim edin");
                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Butun işçilere bax");
                Console.WriteLine("0.Proqramı bitir");
                string input=Console.ReadLine();
                Employee employee;
                Department department = new Department();
                switch (input)
                {
                        case "1":
                        Employee employee1 = CreateEmployee();
                        department.AddEmployee(employee1);

                        break;
                        case "2":department.GetAllEmployees();

                        break;
                        case "0":
                        exit = true;
                        break;
                        default:
                        Console.WriteLine("Yalniz 0,1,2, verilenlerini sece bilersiniz");
                        break;
                }
                
            } 
            while (exit!=true);
            
        }
        public static Employee CreateEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine("employee'nin Name'ni daxil edin:");
            employee.Name = Console.ReadLine();
            Console.WriteLine("employee'nin Surname'ni daxil edin:");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("employee'nin Age ni daxil edin:");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("employee'nin Id sini daxil edin:");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("employee'nin Salary ni daxil edin:");
            employee.Salary = Convert.ToInt32(Console.ReadLine());

            return employee;
        }
    }
    
}
