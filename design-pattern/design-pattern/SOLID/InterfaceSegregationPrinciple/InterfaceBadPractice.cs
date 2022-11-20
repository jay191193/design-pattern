using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.SOLID.InterfaceSegregationPrinciple
{
    public class Document { }
    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }
    class InterfaceBadPractice
    {
    }
}
