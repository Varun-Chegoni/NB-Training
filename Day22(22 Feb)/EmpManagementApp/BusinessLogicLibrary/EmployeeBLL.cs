using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            var result = EmpDAL.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<String> GetEmployeeById(int id)
        {
            var result = EmpDAL.GetEmployeeById(id);
            return result;
        }
        public static List<String> GetEmployeeByName(string name)
        {
            var result = EmpDAL.GetEmployeeByName(name);
            return result;
        }
        public static string[] GetAllEmployee()
        {
            var result = EmpDAL.GetAllEmployee();
            return result;
        }
    }
}
