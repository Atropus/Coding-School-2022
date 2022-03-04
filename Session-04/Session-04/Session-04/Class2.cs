using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Class2
    {
        int i = 1;

        public int GetSum(int n1) 
        {   
            int sum = n1;
            for (int i = 1; i <= n1; i++);
                sum = sum + n1;
            return sum;

        }

        public int GetProduct(int n1)
        {
            int product = n1;
            for (int i = 1; i < n1; i++)
                product = product * i;
            return product;
            //int product = n1;
            //for (int i = 1; i <= n1; i++)
            //  product = product + i;
            //return product;
        }   
        public Class2()
        {

        }
        



    }
}
