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
            //dDA.DDAline(2, 3, 9, 8);


            Bresenham bresenHam = new Bresenham();
            bresenHam.Bresline(20, 10, 30, 18);


            //Circle circle = new Circle();
            //circle.CirclePoints(10);

            //Ellipse ellipse = new Ellipse();

            //ellipse.EllipsPoints(8, 6);


        }

    }
    
   
}