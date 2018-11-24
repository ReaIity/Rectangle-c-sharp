using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Dot = new int[2];
            Console.WriteLine("Введите х-координату точки");
            Dot[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите y-координату точки");
            Dot[1] = Int32.Parse(Console.ReadLine());
            int c;
            do
            {
                Console.WriteLine("Введите количество прямоугольников");
            } while (!Int32.TryParse(Console.ReadLine(), out c) || c < 0);
            Rectangle[] Rec = new Rectangle[c];
            for (int f = 0; f < c; f++) {
                Rec[f] = new Rectangle(Dot);
                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }

    class Points
    {
        public static Random rand = new Random();
        protected int RectangleWidth { get; set; }
        protected int RectangleLength { get; set; }
        protected int[] Dot_1 = new int[2];

        public Points() {
            Console.WriteLine("Введите х-координату левого верхнего угла прямоугольника");
            Dot_1[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите y-координату левого верхнего угла прямоугольника");
            Dot_1[1] = Int32.Parse(Console.ReadLine());
        }
    }

    class Rectangle : Points
    {
        public Rectangle(int[] Dot) {
            do {
                Console.WriteLine("Введите ширину прямоугольника");
                RectangleWidth = Int32.Parse(Console.ReadLine());
            } while (Dot_1[1] - RectangleWidth < 0);
            do {
                Console.WriteLine("Введите длину прямоугольника");
                RectangleLength = Int32.Parse(Console.ReadLine());
            } while (!(RectangleLength < (10 - Dot_1[0])));


            Console.WriteLine($"Длина прямоугольника = {RectangleLength}");
            Console.WriteLine($"Ширина прямоугольника = {RectangleWidth}");

            if ((Dot[0] > Dot_1[0]) && (Dot[0] < (Dot_1[0] + RectangleLength)))
            {
                if ((Dot[1] < Dot_1[1]) && (Dot[1] > (10 - RectangleWidth)))
                {
                    Console.WriteLine("Точка внутри прямоугольника");
                }
                else
                {
                    Console.WriteLine("Точка вне прямоугольника");
                }
                
            }
            else
            {
                Console.WriteLine("Точка вне прямоугольника");
            }
        }
    }
}
