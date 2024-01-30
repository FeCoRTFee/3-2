using System;



class Program
{
    static void Main(string[] args)
    {
        BasicArray[] array = new BasicArray[3];
        array[0] = new Array();
        array[1] = new Matrix();
        array[2] = new StepArray();
        foreach(BasicArray el in array)
        {
            el.Input();
            Console.WriteLine("Average: " + el.Average());
            el.Show();
        }

    }
}

