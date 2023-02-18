// Задача 27. Напишите программу, которая принимает на вход 
//число и выдает сумму цифр в числе
//452->11; 82->10; 9012->12





void Sumnum(int num)
{
    int sum = 0;
    int count = num.ToString().Length;
    for (int i= 0; i < count; i++)
    {
       int current = num % 10;
        num /= 10;
        sum += current; 
    }
    Console.Write($"The sum of the digits of your number is {sum}");
}

Console.Write("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());



if (user_num > 0)
{
    Sumnum(user_num);
    
}

else 
    Console.WriteLine("Impossible value!");