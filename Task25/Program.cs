// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetPower(int numA, int numB)
{
   int result = 1;
   for(int i = 0; i < numB; i++)
   {
    result = numA * result;
   }
    return result;
}
Console.WriteLine(GetPower(3, 5));
