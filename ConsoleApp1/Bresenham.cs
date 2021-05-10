using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class Bresenham
    {
      
        public Bresenham()
        {

        }
        public void Bresline(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = Math.Abs(xEnd - x0);
            int dy = Math.Abs(yEnd - y0);

            int x, y;

            int p0 = 2 * dy - dx;

            int twoDy = 2 * dy;
            int twoDyMinusDx = 2 * (dy - dx);

            
            if (x0 > xEnd)
            {
                x = xEnd; 
                y = yEnd;
                xEnd = x0;
            }
            else
            {
                x = x0; 
                y = y0;
            }

            Console.WriteLine("2 D(Y) = " + twoDy);
            Console.WriteLine("2 D(Y-X) = "+ twoDyMinusDx);
            Console.WriteLine("-----------");

            Console.WriteLine("(" + x + "," + y + ")" + "\t" + "Pk = " + p0);
            
            while (x < xEnd)
            {
                x++;

                if (p0 < 0)
                {
                    p0 += twoDy;
                }                   
                else
                {
                    y++;
                    p0 += twoDyMinusDx;
                }
                Console.WriteLine("(" + x + "," + y + ")"+"\t"+"Pk = "+ p0);
            }
        }
    }
}
