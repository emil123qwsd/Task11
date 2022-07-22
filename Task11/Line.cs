using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public struct Line
    {
        double b;
        double k;

        public Line(double b, double k)
        {
            this.b = b;
            this.k = k;
        }

        public string Root()
        {
            if (k == 0)
                return "Решений нет";
            double r = -b / k;
            return $"Корень равен- {r}";
        }
    }
    
    
}
