using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Array : BasicArray
{
    int[] mas;
    public override void Input()
    {
        Console.WriteLine("Enter number of elements ");
        int n = Convert.ToInt32(Console.ReadLine());
        mas = new int[n];
        for(int i = 0; i < mas.Length; i++)
        {
            Console.WriteLine("Enter elements ");
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public override double Average()
    {
        int sum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            sum += mas[i];
        }
        return sum / mas.Length;
    }

    public override void Show()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] +  " ");
        }
        Console.WriteLine();
    }
}

