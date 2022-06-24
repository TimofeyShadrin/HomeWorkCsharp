namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            //Задача 6: Напишите программу, которая на вход принимает число и 
            //выдаёт, является ли число чётным (делится ли оно на два без остатка).

            // 4 -> да
            // -3 -> нет
            // 7 -> нет

            Console.Clear();

            Console.WriteLine("Input value: ");
            // получаем число
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
            //Вывод результата
            Console.WriteLine($"Your number {number} is even");
            }
            
            else
            {
            //Вывод результата
            Console.WriteLine($"Your number {number} is odd");
            }
        } 
    } 
} 