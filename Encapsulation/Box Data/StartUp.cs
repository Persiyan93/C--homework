using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, width, height);
                box.Surface();
                box.LateralSurface();
                box.Volume();
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }



        }
    }
}
