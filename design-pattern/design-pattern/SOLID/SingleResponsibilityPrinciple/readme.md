# Single Responsibility Principle
## _Definition: Every software module should have only one reason to change_

This definition sounds cryptic. Let's understand this in simple terms.

We have to create one application with respect to Employee Management System. In this application we have to store Employee details and respective Department details. Below is pseudo code sample for this scenario.

```sh
public class SingleResponsibilityPrinciple
{
  public void GetEmployees() { }
  public void SaveEmployee(Employee e) { }
  public void GetDepartments() { }
  public void SaveDepartment(Department d) { }
  public void StoreRecordsToDB() { }
}
``` 

- For this pseudo code we have to handle three tasks. 
  1. Task to handle Employee data
  2. Task to handle Department data
  3. Task to handle storing data to DB.
- We are handing all these 3 tasks inside one class.
- As per Single Responsibility Principle, this is very bad practice to handle everything inside one class.
- Instead of this, we have to handle everything separately (_one reason to change_). So, in future if there is any details we have to change related to Employee then we will only make change related to Employee Task and so on.

## Updated Pseudo Code with Single Reponsibility Principle Implemented
```sh
public class Employee
{
    public void GetEmployees() { }
    public void SaveEmployee(Employee e) { }
}
public class Department 
{
    public void GetDepartments() { }
    public void SaveDepartment(Department d) { }
}

public class StoreToDB
{
    public void StoreEmployee(Employee e) { }
    public void StoreDepartment(Department e) { }
}
```
Here we have 3 classes with each class has it's own responsibility.

## To run Single Responsibility Principle code, you need to update your ```Program.cs``` file as per below.
```sh
using design_pattern.SingleResponsibilityPrinciple;

namespace design_pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee masterEmployee = new Employee();
            Department masterDepartment = new Department();

            Department d = new Department() { DepartmentId = 1, DepartmentName = "HR" };
            Department d1 = new Department() { DepartmentId = 2, DepartmentName = "Network" };
            masterDepartment.AddDepartment(d);
            masterDepartment.AddDepartment(d1);
            System.Console.WriteLine();

            Employee e = new Employee() { EmployeeId = 101, DepartmentId = 1, EmployeeName = "Zuck" };
            Employee e1 = new Employee() { EmployeeId = 102, DepartmentId = 2, EmployeeName = "Elon" };
            Employee e2 = new Employee() { EmployeeId = 103, DepartmentId = 1, EmployeeName = "Bill" };
            masterEmployee.AddEmployee(e);
            masterEmployee.AddEmployee(e1);
            masterEmployee.AddEmployee(e2);
            System.Console.WriteLine();
            masterEmployee.GetEmployees();
            System.Console.WriteLine();

            
        }
    }
}
```
