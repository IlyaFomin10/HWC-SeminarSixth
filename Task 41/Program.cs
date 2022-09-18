// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] GetArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
return array;    
}

int AmountPlus(int[] array)
{
int result = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + 1;
        }
    }
return result;
}


Console.WriteLine("Здравствуйте! Уверен, у вас настроение ввести пару чисел, но давайте уточним, сколько чисел вы хотите ввести?");
int amount = int.Parse(Console.ReadLine());
Console.WriteLine("Начинаем ввод!");
int[] arr = GetArray(amount);
int plusNumber = AmountPlus(arr);
Console.WriteLine($"Поздравляю, мы посчитали количество положительных введенных вами чисел, оно равно: {plusNumber}");
