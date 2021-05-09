using System;
using System.Collections.Generic;
using System.Threading;

namespace Graphics
{
    class Program
    {

        public static void Main(string[] args)
        {
            //DDA dDA = new DDA();
            //dDA.DDAline(0, 0, 4, 6);

            //for (int i = 0; i < dDA.Xpoints.Count; i++)
            //{
            //    Console.WriteLine(dDA.Xpoints[i] + "\t" + dDA.Ypoints[i]);
            //}

            //Bresenham bresenHam = new Bresenham();
            //bresenHam.Bresline(32, 3, 48, 8);
            //for (int i = 0; i < bresenHam.Xpoints.Count; i++)
            //{
            //    Console.WriteLine(bresenHam.Xpoints[i] + "\t" + bresenHam.Ypoints[i]);
            //}

            Circle circle = new Circle();
            circle.CirclePoints(10);
            for (int i = 0; i < circle.Xpoints.Count; i++)
            {
                Console.WriteLine(circle.Xpoints[i] + "\t" + circle.Ypoints[i]);
            }

        }

    }
    
   
}