using System;

namespace Box
{
   public class Box
    {
        private double lenght;

        public double Lenght
        {

            set
            {
                if (value > 0)
                {
                    lenght = value;
                }
                else
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }

            }
        }
        private double width;

        public double Width
        {
            
            set
            {
                
                    if (value > 0)
                    {
                        width = value;
                    }
                    else
                    {
                        throw new ArgumentException("Width cannot be zero or negative.");
                    }
                
                
                
            }
        }
        private double height;

        public double Height
        {

            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }
        public Box(double lenght,double width,double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public void Surface()
        {
            double surface = 2 * this.lenght * this.width + 2 * lenght * height + 2 * width * height;
            Console.WriteLine($"Surface Area - {surface:F2}");
        }
        public void LateralSurface()
        {
            double lateralSuraface = 2 * this.lenght * height + 2 * width * height;
            Console.WriteLine($"Lateral Surface Area - {lateralSuraface:F2}");
        }
        public void Volume()
        {
            double volume = width * height * lenght;
            Console.WriteLine($"Volume - {volume:F2}");
        }



    }
}
