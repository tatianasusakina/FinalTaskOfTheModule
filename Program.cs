/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 */

string[] GetUserString(string msg)
{
    Console.WriteLine(msg);
    string[] userString = Console.ReadLine().Split(" ");
    return userString;
}

int FindCountOfStrings(string[] str, int n)
{
    int i = 0;
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j].Length <= n)
            i++;
    }
    return i;
}

string[] FindStrings(string[] userString, int n)
{
    string[] result = new string[FindCountOfStrings(userString, n)];
    for (int i = 0, j = 0; i < userString.Length; i++)
    {
        if(userString[i].Length <= n)
        {
            result[j] = userString[i];
            j++;
        }
    }
    return result;
}

string[] userString = GetUserString("Вводите строки через пробел");
string[] result = FindStrings(userString, 3);
Console.WriteLine($"[{string.Join(", ", userString)}] -> [{string.Join(", ", userString)}]");
