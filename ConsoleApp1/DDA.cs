using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class DDA
    {
       
        public DDA()
        {

        }

        public void DDAline(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0;
            int dy = yEnd - y0;
            int steps, xf, yf;

            float slop = (float)dy / (float)dx;
            
            float x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }

            Console.WriteLine("D of X = "+dx);
            Console.WriteLine("D of Y = " + dy);
            Console.WriteLine("Slop = " + slop);

            Console.WriteLine("-----------");


            if (slop > 1)
            {
                for (int i = 0; i < steps; i++)
                {
                     y0++;                  

                     x += (1 / slop);
                     xf = (int)Math.Round(x);
                     Console.WriteLine("(" + xf + "," + y0 + ")" + "\t" + "Orignal X = " + x);
                }
            }
            else
            {
                for (int i = 0; i < steps; i++)
                {
                    x0++;
                   

                    y += slop;
                    yf = (int)Math.Round(y);
                  
                    Console.WriteLine("(" + x0 + "," + yf + ")"+"\t"+"Orignal Y = "+ y);
                }
            }           


        }

    }
}
