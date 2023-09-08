XYZ

This repository contains ```C#``` based examples of many popular Design Patterns.

Each Design Pattern has its own separate README with related explanations.

☝ Note that this project is meant to be used for learning and researching purposes only, and it is not meant to be used for production.

# Design Pattern
Design patterns are solutions to common problems in software design. Any pattern is like a blueprint that you can customize to solve a particular problem in your code.

Any design pattern is not a specific code. But you need to adjust the code according to your need in your Project.

Mainly it is just a set of instructions for every pattern that we can follow. If we will follow the guidelines for each design pattern, then it will be easy for the changes that will happen in the future.

# How to run this project?
- Open solution file in Visual Studio from here - [design-pattern](https://github.com/jay191193/design-pattern/blob/main/design-pattern/design-pattern.sln).
- Right click on solution. 
- Go to properties.
- Make sure ```Output type``` to be ```Console Application```.
- Go to ```Program.cs``` file.
- Add your code inside ```Main()``` function for any design pattern.
- Here is the Example to call code for ```SingleResponsibility.cs``` file.
```sh
using design_pattern.SingleResponsibilityPrinciple;

namespace design_pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { EmployeeId = 101, EmployeeName = "Jay Ponkia",  DepartmentId = 1};
            Employee e2 = new Employee() { EmployeeId = 102, EmployeeName = "Neel Ponkia",  DepartmentId = 2};

            Employee e = new Employee();
            e.AddEmployee(e1);
            e.AddEmployee(e2);
            e.GetEmployees();

        }
    }
}
```
- Now press ```ctrl+F5```. It will run console application against our ```Main()``` function inside ```Program.cs``` file.
