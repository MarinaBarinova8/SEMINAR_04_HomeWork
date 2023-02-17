//Задача 29. Напишите программу, которая задает массив из произвольного 
//количества элементов и выводит их на экран
//1,2,5,7,19,->[1,2,5,7,19]
//6,1,33 ->[6,1,33]



int [] CreatNewArray(int size_array)
{
    int[] random01array = new int [size_array];
    for (int i = 0; i < size_array; i++)
    {
        random01array[i] = new Random().Next(0,1000);
    }
    return  random01array;
}
void ShowCreatArray(int[] array01)
{
    Console.WriteLine("Your array is ");
    for (int i = 0; i < array01.Length; i++)
    Console.Write(array01[i] + " " );
}
int[]arrayNew = CreatNewArray(15);
ShowCreatArray(arrayNew);