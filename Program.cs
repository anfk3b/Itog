// Итоговая проверочная работа.
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения 
// первого блока обучения на программе разработчик. Мы должны убедиться что базовое 
// знакомство с it прошло успешно.

// Задача алгоритмически не самая сложная, однако для полценного вьполнения проверочной 
// работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной 
// части, если вы выделяете ее в отдельный метод)
// З. Снабдить репозиторий оформленным текстoвым описанием решения (файл README.md)
// 4. Написать программу, решающyю поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть 
// так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены 
// в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте вьполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string InputStr(string message)
{
    System.Console.Write(message);
    return Console.ReadLine();
}

void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        System.Console.WriteLine($"{i + 1}: " + stringArray[i]);
    }
}

string[] Reform(string[] initArray)
{
    // подсчёт строк нужной длины
    int count = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= 3)
            count++;
    }
    // заполнение результирующего массива
    string[] resultArray = new string[count];
    int j = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= 3)
        {
            resultArray[j] = initArray[i];
            j++;
        }
    }
    return resultArray;
}

int n = InputInt("Введите количество строк исходного массива: ");
string[] arr1 = new string[n];
for (int i = 0; i < n; i++)
{
    arr1[i] = InputStr($"Введите {i + 1}-ю строку: ");
}
string[] arr2 = Reform(arr1);
System.Console.WriteLine("\nРезультирующий массив:");
PrintArray(arr2);
