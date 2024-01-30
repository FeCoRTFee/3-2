using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StepArray : BasicArray
{
    int[][] mas;
    public override void Input()
    {
        Console.WriteLine("Enter rows number");
        int rows = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Enter line");
            string line = Console.ReadLine();
            string[] elements = line.Split(' ');
            int[] mas1 = new int[elements.Length];
            for (int j = 0; j < mas1.Length; j++)
            {
                mas1[j] = Int32.Parse(elements[j]);

            }
            mas[i] = mas1;

        }
    }

    public override double Average()
    {
        double s = 0;
        int c = 0;
        foreach (int[] row in mas)
        {
            foreach (int number in row)
            {
                s += number;
                c++;

            }

        }
        return s /= c;
    }

    public override void Show()
    {
        Console.WriteLine("Array:");
        foreach (int[] row in mas)
        {
            foreach (int number in row)
            {
                Console.Write(number);

            }
            Console.WriteLine();
        }
    }
}

