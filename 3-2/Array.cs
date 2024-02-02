using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Array : BasicArray
{
    int[] mas;
    public Array(int n = 3) : base(n)
    {
        mas = new int[number_of_cells];

    } 
    public override void Input()
    {
        Console.WriteLine("Enter number of elements ");
        int n = Convert.ToInt32(Console.ReadLine());
        mas = new int[n];
        Console.WriteLine("Enter elements ");
        for (int i = 0; i < mas.Length; i++)
        {           
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

    public override void Random()
    {
        Random rnd = new Random();       
        Console.WriteLine("Enter number of elements ");
        int n = Convert.ToInt32(Console.ReadLine());
        mas = new int[n];
        for (int i = 0; i < mas.Length; i++)
        {          
            mas[i] = rnd.Next(-100, 100);
        }
    }

    public override void Recreate(int n)
    {
        mas = new int[number_of_cells];
    }
}

