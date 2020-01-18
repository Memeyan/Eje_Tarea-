using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_2B.BO
{
    class operaciones_BO
    {
        private double num1;
        private double num2;
        private double r_sum;
        private double r_mul;


		//Constructor
		public operaciones_BO(double n1, double n2)
        {
            num1 = n1;
            num2 = n2;
        }

		// Metodos 

		public double Suma()
        {
            r_sum = num1 + num2;
            return r_sum;
        }
		public double Multi()
        {
            r_mul = num1 * num2;
            return r_mul;
        }


    }
}
