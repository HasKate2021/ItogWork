//создание функции заполнения массива из строки
// string[] MasString(string [] txt,int m)
// {
//     string [] array = new string [m];
    
// }

void PrintArry(string[] massiv)
{
    int count = massiv.Length;
    Console.Write("[");
    for (int i = 0;i < count;i++)
    {
        Console.Write(massiv[i]);
        if (i < count-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Введите слова через пробел: ");
string? text = Console.ReadLine();
//int predel = 3;
//int length = text.Length;
string[] text1 = text.Split(" ");
PrintArry (text1);
// string[] text2 = MasString(text1,length);
// PrintArry (text2);

