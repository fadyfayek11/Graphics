using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class Ellipse
    {
        public Ellipse()
        {

        }
        public void EllipsPoints(int rx, int ry)
        {
            int x = 0;
            int y = ry;
            double p0 = Math.Pow(ry, 2) - (Math.Pow(rx, 2) * ry) + (0.25 * Math.Pow(rx, 2));
            double dx = 2 * Math.Pow(ry, 2) * x;
            double dy = 2 * Math.Pow(rx, 2) * y;

            Console.WriteLine("(" + x + "," + y + ")" + "\t" + "D of X = " + dx + "\t D of Y = " + dy + "\t" + "P0 = " + p0);
            do
            {
                
                if (p0 < 0)
                {
                    x++;
                    dx += (2 * Math.Pow(ry, 2));
                    p0 += dx + Math.Pow(ry, 2);
                }
                else
                {
                    x++;
                    y--;
                    dx += (2 * Math.Pow(ry, 2));
                    dy -= ((2 * Math.Pow(rx, 2)));
                    p0 += dx - dy + Math.Pow(ry, 2);
                }
                Console.WriteLine("(" + x + "," + y + ")"+"\t"+"D of X = "+ dx + "\t D of Y = "+dy +"\t"+ "P0 = " + p0);
            } while (dx < dy);

            
            double p1 = (Math.Pow(ry, 2) * (Math.Pow((x + .5),2))) + (Math.Pow(rx , 2) * (Math.Pow((y-1),2))) - (Math.Pow(rx, 2) * Math.Pow(ry ,2));
            do
            {
                if (p1 > 0)
                {
                    y--;
                    
                    dy -= (2 * (Math.Pow(rx, 2)));
                    p1 += dy - Math.Pow(rx, 2) ;
                }
                else
                {
                    x++;
                    y--; 

                    dy -= (2 * (Math.Pow(rx, 2)));
                    dx += (2 * (Math.Pow(ry, 2)));
                    p1 += dx - dy + Math.Pow(rx, 2);
                }
                Console.WriteLine("(" + x + "," + y + ")" + "\t" + "D of X = " + dx + "\t D of Y = " + dy + "\t" + "P0 = " + p0);

            } while (y > 0);
           
        }
    }
}
