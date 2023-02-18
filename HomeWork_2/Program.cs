// Задача 27. Напишите программу, которая принимает на вход 
//число и выдает сумму цифр в числе
//452->11; 82->10; 9012->12


/*void SummLen(int num)
{
    int count = 1;
    while(num>=10)
    {
        num =num/10;
        count++;
    }


    int sum = 0;
    for (int i = 1; i <= count ; i++)
    {
        num= num / 10;
        sum = sum + num % 10;
        
    }
    Console.Write($"{num}-> {sum}");
}
     
Console.Write("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num > 0)
{
    SummLen(user_num);
    
}

else 
    Console.WriteLine("Impossible value!");

*/


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