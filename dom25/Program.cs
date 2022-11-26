// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Exp(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }

    return result;
}

Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exp = Exp(numberA, numberB);
Console.WriteLine("Total: " + exp);
