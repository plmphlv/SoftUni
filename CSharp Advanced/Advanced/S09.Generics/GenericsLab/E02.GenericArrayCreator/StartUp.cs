using System;

namespace GenericArrayCreator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] words = ArrayCreator.Create(5, "Pesho");
            int[] numbers = ArrayCreator.Create(10, 33);
        }
    }
}