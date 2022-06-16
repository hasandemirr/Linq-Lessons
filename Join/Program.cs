using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    public class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int AddressID { get; set; }
        public int DepartmentID { get; set; }

    }
    public class Address
    {
        public int ID { get; set; }
        public String AddressLine { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ID=1,Name="Preety",AddressID=1,DepartmentID=10},
                new Employee{ID=2,Name="Priyanka",AddressID=2,DepartmentID=20},
                new Employee{ID=3,Name="Anurag",AddressID=3,DepartmentID=30},
                new Employee{ID=4,Name="Hina",AddressID=4,DepartmentID=10},
                new Employee{ID=5,Name="Sambit",AddressID=5,DepartmentID=10},
                new Employee{ID=6,Name="Happy",AddressID=6,DepartmentID=20},
                new Employee{ID=7,Name="Tarun",AddressID=7,DepartmentID=30},
            };
            List<Address> addresses = new List<Address>()
            {
                new Address{ID=1,AddressLine="Addressline1"},
                new Address{ID=2,AddressLine="Addressline2"},
                new Address{ID=3,AddressLine="Addressline3"},
                new Address{ID=4,AddressLine="Addressline4"},
                new Address{ID=5,AddressLine="Addressline5"},
                new Address{ID=6,AddressLine="Addressline6"},
                new Address{ID=7,AddressLine="Addressline7"}
            };
            List<Department> departments = new List<Department>()
            {
                new Department{ID=10,Name="IT"},
                new Department{ID=20,Name="HR"},
                new Department{ID=30,Name="Payroll"}

            };

            var result = employees.Join(addresses, employee => employee.AddressID, addresse => addresse.ID, (employee, addresse) => new
            {
                EmployeeName = employee.Name,
                AddressLine = addresse.AddressLine
            }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("Name:" + item.EmployeeName + " Adress:" + item.AddressLine);
            }

            var result2 = (from x in employees
                           join y in addresses
                           on x.AddressID equals y.ID
                           select new
                           {
                               EmployeeName = x.Name,
                               AddressLine = y.AddressLine
                           }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("Name:" + item.EmployeeName + " Adress:" + item.AddressLine);
            }
            Console.WriteLine("");

            var multipleJoin = (from x in employees
                                join y in addresses
                                on x.AddressID equals y.ID
                                join z in departments
                                on x.DepartmentID equals z.ID
                                select new
                                {
                                    ID = x.ID,
                                    employeeName = x.Name,
                                    addressLine = y.AddressLine,
                                    depertmentName = z.Name
                                });
            foreach (var item in multipleJoin)
            {
                Console.WriteLine("ID:"+item.ID + " | Name:"+item.employeeName + " | Address:"+item.addressLine + " | Department:"+item.depertmentName);
            }


            Console.ReadLine();

        }
    }
}
