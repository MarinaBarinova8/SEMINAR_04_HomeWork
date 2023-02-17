// Задача 25. Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В
//3,5->243(3^5); 2,4->16


void A_DegreeB(int number1, int number2) 

{
    int current = 1; 
    

    for (int count = 1; count <= number2; count++) 
    {
        
        current = current * number1; 
    }
    
    Console.WriteLine($"{number1}, {number2} -> {current}");

}
Console.WriteLine("Input your number A: ");
int user_numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your number B: ");
int user_numB = Convert.ToInt32(Console.ReadLine());

if (user_numB > 0)
{
     A_DegreeB(user_numA, user_numB);
    

}

else 
    Console.WriteLine("Impossible value!");
    
