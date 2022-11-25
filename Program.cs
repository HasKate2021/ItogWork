//создание функции заполнения итогового массива 
string[] MasString(string[] txt, int n)
{
    string[] array = new string[LengthMassiv(txt, n)];
    int j = 0;
    for (int i = 0; i < txt.Length; i++)
    {
        if (txt[i].Length <= n)
        {
            array[j] = txt[i];
            j++;
        }
    }
    return array;
}

int LengthMassiv(string[] arr, int n) //ф-ия подсчета элементов массива с <=3 символами
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            count++;
            //        Console.Write($" {count} ");
        }
    }
    return count;
}

//функция печати
void PrintArry(string[] massiv)
{
    int count = massiv.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(massiv[i]);
        if (i < count - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Введите слова через пробел: ");
string? text = Console.ReadLine();
int predel = 3;
string[] text1 = text.Split(" "); //массив из строки
PrintArry(text1);
Console.WriteLine();
string[] text2 = MasString(text1, predel);
PrintArry(text2);

