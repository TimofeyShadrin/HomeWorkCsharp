namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            //Задача 8: Напишите программу, которая на вход принимает число (N), а 
            //на выходе показывает все чётные числа от 1 до N.

            // 5 -> 2, 4
            // 8 -> 2, 4, 6, 8

            Console.Clear();

            Console.WriteLine("Input number: ");
            // получаем число
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            Console.WriteLine($"These even numbers range from 1 to your number {number}: ");

            while (count <= number)
            {
                if (count % 2 == 0)
                {
                    //Вывод результата
                    Console.WriteLine(count);
                }
                count++;
            }

        } 
    } 
} 