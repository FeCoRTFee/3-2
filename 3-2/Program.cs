﻿using System;



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
            Console.WriteLine("random press 0, input press 1");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0) el.Random();
            else if (b==1) el.Input();
            Console.WriteLine("Average: " + el.Average());
            el.Show();
        }
    }
}

