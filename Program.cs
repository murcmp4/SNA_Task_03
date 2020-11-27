using System;

namespace SNA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String password = "pass";
            int trying = 1;
            do
            {
                Console.Write("Введите пароль - ");
                Console.Write("Попытка - ");
                Console.WriteLine(trying);
                trying++;
                password = Convert.ToString(Console.ReadLine());
                if (password == "pass")
                {
                    Console.Write("Ключ под ковриком");
                    break;
                }
            } while (trying <= 3);
        }
    }
}
