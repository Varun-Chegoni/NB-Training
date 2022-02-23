using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class EmpDAL
    {
        public static string FilePath = "D:\\NB_Training\\Training_Assignments\\DotNET_Assignments\\Day22(22 Feb)\\Employees.txt";
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                String textContent = String.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(FilePath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<String> GetEmployeeById(int id)
        {
            var allEmployees = File.ReadAllLines(FilePath);
            bool isFound = false;
            List<String> empFound = new List<string>();
            
            foreach(String employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    empFound.Add(employee);
                    break;
                }
            }
            return empFound;
        }
        public static List<String> GetEmployeeByName(string name)
        {
            var allEmployees = File.ReadAllLines(FilePath);
            bool isFound = false;
            List<String> empFound = new List<string>();

            foreach (String employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name)) 
                {
                    empFound.Add(employee);
                }
            }
            return empFound;
        }
        public static string[] GetAllEmployee()
        {
            var allEmployees = File.ReadAllLines(FilePath);
            return allEmployees;
        }

    }
}
