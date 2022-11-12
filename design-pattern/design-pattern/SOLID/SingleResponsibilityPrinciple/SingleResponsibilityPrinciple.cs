using System;
using System.Collections.Generic;

/// <summary>
/// Every software module should have only one reason to change
/// </summary>
namespace design_pattern.SOLID
{
    /// <summary>
    /// Single Responsibility to handle Employee related activity.
    /// </summary>
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        private List<Employee> lstEmployees = new List<Employee>();

        public void GetEmployees()
        {
            foreach (var item in lstEmployees)
            {
                Console.WriteLine(item.EmployeeId + " - " + item.EmployeeName);
            }
        }

        public void AddEmployee(Employee e)
        {
            lstEmployees.Add(e);
            Console.WriteLine("Employee Added Successfully");
        }
    }

    /// <summary>
    /// Single Responsibility to handle Department related activity.
    /// </summary>
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        private List<Department> lstDepartments = new List<Department>();

        public void AddDepartment(Department d)
        {
            lstDepartments.Add(d);
            Console.WriteLine("Department Added Successfully");
        }
    }

    /// <summary>
    /// Single Responsibility to handle Database related activity.
    /// </summary>
    internal class StoretoDB
    {
        public void SavetoDB()
        {
            //...Code to save data to DB
        }
    }
}
