using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class Bresenham
    {
        public List<int> Xpoints = new List<int>();
        public List<int> Ypoints = new List<int>();
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
                Xpoints.Add(x);
                Ypoints.Add(y);
            }
        }
    }
}
