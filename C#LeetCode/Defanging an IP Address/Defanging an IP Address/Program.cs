using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defanging_an_IP_Address
{

    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");
            return address;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var address = "255.100.50.0";
            var solution = new Solution();
            Console.WriteLine(solution.DefangIPaddr(address));

            Console.WriteLine(address);
            Console.ReadKey();
        }
    }
}
