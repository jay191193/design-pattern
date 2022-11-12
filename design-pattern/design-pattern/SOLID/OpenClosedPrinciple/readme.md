# Open Closed Principle
## _Definition: software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification_

This definition sounds cryptic. Let's understand this in simple terms.

- We will take example for Calculator over here.
- Let say as of now we have got requirement from client that we have to add functionality in our calculator application to calculate addition and substraction.
- Normally we will add something like this.

```sh
public class Calculator
{
  public int Add(int a, int b) { return a + b; }
  public int Substract(int a, int b) { return a - b; }
}
```

- It is the definition for the first point in definition. This class has got opened for extension as we are adding functionalities in ```Calculator``` class.
- Now, after around 1 month we have got requirement from client that now we have to add functionality for multiplication.
- Normally we will add another function for ```Multiply()``` in ```Calculator``` class. That will look something like this.
```sh
public class Calculator
{
  public int Add(int a, int b) { return a + b; }
  public int Substract(int a, int b) { return a - b; }
  public int Multiply(int a, int b) { return a * b; }
}
```
- Now this violates Open Closed Principle. Because in the second point of definition, it states that it _should be closed for modification_. Here we have modified the existing class.

## What is the solution for this?
- You can refer the **solution** for this violation of **Open Closed Principle** over [here](https://github.com/jay191193/design-pattern/blob/main/design-pattern/design-pattern/SOLID/OpenClosedPrinciple/OpenClosedPrinciple.cs).
- So, it will create separate class for each functionality of calculator.
- One other thing you can notice over here that we are serving **Single Responsibility Principle** here also.
