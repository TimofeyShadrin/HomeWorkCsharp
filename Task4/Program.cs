namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            //Задача 4: Напишите программу, которая принимает на вход три числа и
            //выдаёт максимальное из этих чисел.

            // 2, 3, 7 -> 7
            // 44 5 78 -> 78
            // 22 3 9 -> 22

            Console.Clear();

            Console.WriteLine("Input value number one: ");
            // получаем первое число
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value number two: ");
            //Получаем второе число
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value number three: ");
            //Получаем второе число
            int number3 = Convert.ToInt32(Console.ReadLine());
            
            int max = number1;

            if (number2 > max) max = number2;
            if (number3 > max) max = number3;
            
            //Вывод результата
            Console.WriteLine($"The maximum number is {max}");
            
        } 
    } 
} 