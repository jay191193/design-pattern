# Interface Segregation Principle
## _Definition: Interface Segregation Principle states that no code should be forced to depend on methods it does not use. It should splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them._

This definition sounds cryptic. Let's understand this in simple terms.

- We can take example for Printer over here.
- First of all below is out pseudo code.
```sh
interface IPrinter
{
    void Print(Document d);
    void Fax(Document d);
    void Scan(Document d);
    void ColorPrint(Document d);
}

- So this is our Printer interface.
- Now, we will create a main Printer class and we will implement this interface for that class.
- Once we will do that and if that particular printer will not do scanning or faxing, then what we will add for those methods.
- So, the solution is we will divide this interface into multiple interfaces and will implement whichever interface we want to implement for particular printer.
- For that we can go into the code itself.
