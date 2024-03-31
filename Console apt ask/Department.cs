using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_apt_ask
{
    internal class Department
    {
       
        Employee[] Employees;
        private List<Employee> employees;

        public Department()
        {
            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployees=new Employee[Employees.Length+1];
            for(int i=0; i<Employees.Length; i++)
            {
                newEmployees[i] = Employees[i];
            }
            newEmployees[^1] = employee;
            Employees = newEmployees;
        }public Employee GetEmployee(int id)
        {
            foreach(Employee employee in Employees)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }return null;
            
        }
        public List<Employee> GetAllEmployees(Employee employee)
        {
            return employees;
        }





    }
}
