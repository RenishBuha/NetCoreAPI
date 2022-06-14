using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData.Model;

namespace CoreData.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee GetByName(string name);
        Employee GetFromQueryData(string name);
        Employee GetFromBodyData(string name);
        Employee GetFromFormData(string name);
    }
}
