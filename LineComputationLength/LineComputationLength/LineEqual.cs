using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputationLength
{
    public class LineEqual : LineCompare
    {
        public double dis1, dis2, dis3;
        public void equal()
        {
            LineComputation uc1 = new LineComputation();
            dis1 = uc1.UserCartesian();

            LineComputation uc2 = new LineComputation();
            dis2 = uc1.UserCartesian();
            LineComputation uc3 = new LineComputation();

            dis3 = uc3.UserCartesian();
            CheckEquality(dis1, dis2, dis3);
            ComparingLines(dis1, dis2, dis3);

        }

        public void CheckEquality(double dis1, double dis2, double dis3)
        {

            if (dis1 == dis2)
            {
                Console.WriteLine("Line 1 and line 2 are equal");
            }
            else if (dis1 == dis3)
            {
                Console.WriteLine("Line 1 and line 3 are equal");
            }
            else if (dis2 == dis3)
            {
                Console.WriteLine("Line 2 and line 3 are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}
