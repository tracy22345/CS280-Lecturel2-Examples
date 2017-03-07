using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sq1 =
                @"select * from table
                  where id >1000";
            string xm1 =
                 @"<Pokemon>
                    <NationalNo><#001></NationalNo>
                    <Name><Bulbsaur></Name>
                    </Pokemon>";

            string xm2 =
                  @"Pokemon ={
                    NationalNo: '#001',
                    Name: Bulbsaur
                    }";

            Console.WriteLine(sq1);
            Console.WriteLine(xm1);
            Console.WriteLine(xm2);
        }
    }
}