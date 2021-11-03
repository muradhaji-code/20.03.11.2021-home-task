using MyClassLibrary;
using System;

namespace _20._03._11._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.WriteLine(instance.Add(5, 8));
            Console.WriteLine(instance.Subtract(40, 5));
        }
    }
}
