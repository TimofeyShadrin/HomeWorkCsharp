namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            //Задача 2: Напишите программу, которая на вход принимает два числа и 
            //выдаёт, какое число большее, а какое меньшее.

            // a = 5; b = 7 -> max = 7
            // a = 2 b = 10 -> max = 10
            // a = -9 b = -3 -> max = -3
            Console.Clear();

            Console.WriteLine("Input value number one: ");
            // получаем первое число
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value number two: ");
            //Получаем второе число
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                //Вывод результата
                Console.WriteLine($"First number {number1} greater than second {number2}");
            }

            else if (number1 < number2)
            {
                //Вывод результата
                Console.WriteLine($"Second number {number2} greater than first {number1}");
            }

            else
            {
                //Вывод результата
                Console.WriteLine($"The first number {number1} is equal to the second {number2}");
            }
            

        } 
    } 
} 