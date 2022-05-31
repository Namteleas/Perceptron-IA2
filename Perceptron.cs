using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        float[] pesos;
        float ratApr;

        public Perceptron(float ra)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            pesos = new float[3];
            for(int i = 0; i < 3; i++)
            {
                pesos[i] = 5 - (float)random.NextDouble() * 10;
            }
            ratApr = ra;
        }

        public float[] Pesos
        {
            get
            {
                return pesos;
            }
        }

        public void actualizar(int error, float x, float y)
        {
            pesos[0] += (ratApr * error * -1);
            pesos[1] += (ratApr * error * x);
            pesos[2] += (ratApr * error * y);
        }
    }
}
