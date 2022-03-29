using SOAPWebClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPWebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient calculator = new ServiceReference1.MathsOperationsClient();
            Console.WriteLine("3 + 3 = "+calculator.Add(3, 3));
            Console.WriteLine("4 - 2 = "+calculator.Substract(4, 2));
            Console.WriteLine("4 * 2 = "+calculator.Multiply(4, 2));
            Console.ReadLine();
        }
    }
}
