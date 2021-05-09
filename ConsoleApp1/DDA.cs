using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class DDA
    {
       public  List<int> Xpoints = new List<int>();
       public List<int> Ypoints = new List<int>();

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

           

            if (slop > 1)
            {
                for (int i = 0; i < steps; i++)
                {
                    y0++;
                    Ypoints.Add(y0);

                     x += (1 / slop);
                     xf = (int)Math.Round(x);
                     Xpoints.Add(xf);
                }
            }
            else
            {
                for (int i = 0; i < steps; i++)
                {
                    x0++;
                    Xpoints.Add(x0);

                    y += slop;
                    yf = (int)Math.Round(y);
                    Ypoints.Add(yf);
                }
            }           


        }

    }
}
