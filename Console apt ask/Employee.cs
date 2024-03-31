using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_apt_ask
{
    internal class Employee
    {
        private int _age;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public int Age { get { return _age; }
            set 
            {
                if(value>18)
                {
                    _age = value;
                }else
                {
                    Console.WriteLine("18 yasdan kicik isci qebul etmirik!!!");
                    
                }
            } 
        }
        public int Salary {  get; set; }
        public void ShowFUllInfo()
        {
            Console.WriteLine(Name+","+Surname+","+Age+","+Id+","+Salary);
        }
        
    }
    
}
