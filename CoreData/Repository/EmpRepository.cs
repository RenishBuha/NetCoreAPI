using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData.Model;
using CoreData.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CoreData.Repository
{
    public class EmpRepository : IEmployee
    {
        List<Employee> Emplist = new List<Employee>
        {
            new Employee{EmpId = 1, EmpName = "Rinkal", EMailId = "Rinkal@gmail.com", MobileNumber = "1234598658" },
            new Employee{EmpId = 2, EmpName = "Mayur",  EMailId = "Mayur@gmail.com",  MobileNumber = "5678900256" },
            new Employee{EmpId = 3, EmpName = "Renish", EMailId = "Renish@gmail.com", MobileNumber = "8989555005" },
        };

        public List<Employee> GetAll()
        {
            return Emplist;
        }

        public Employee GetById(int id)
        {
            return Emplist.FirstOrDefault(x => x.EmpId == id);
        }

        public Employee GetByName(string name)
        {
            return Emplist.FirstOrDefault(x => x.EmpName == name);
        }

        public Employee GetFromQueryData(string name)
        {
            return Emplist.FirstOrDefault(x => x.EmpName == name);
        }

        public Employee GetFromBodyData(string name)
        {
            return Emplist.FirstOrDefault(x => x.EmpName == name);
        }

        public Employee GetFromFormData(string name)
        {
            return Emplist.FirstOrDefault(x => x.EmpName == name);
        }
    }
}
