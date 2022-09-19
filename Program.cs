Console.Clear();

Random rand = new Random(); //Создания объекта класса Random.
int count = 0;

void GenerateWord(out string randomWord) // Функция генерации случайного числа
{
    int strLength = rand.Next(1, 10); //генерация длины случаной строки.
    int temp;
    randomWord = String.Empty;
    char letter;
    for (int i = 0; i < strLength; i++)
    {
        temp = rand.Next(65, 91); // Генерация числа в пределах 65 до 90.
        letter = Convert.ToChar(temp); // Создания буквы случайного числа в таблице ASCII с 65 по 90 (A..Z).
        randomWord = randomWord + letter; // Создание случайной строки путем конкатенации строк.
    }
    if (randomWord.Length <= 3) count++; // Подсчет слов по зданию больше 3 символов для создания выходного массива заданной длины.
}

void PrintArray(string message, string[] array) // Функция вывода массива на экран.
{
    int arrayLength = array.Length;
    Console.Write(message + " | ");
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write(array[i] + " | ");
    }
    Console.WriteLine("\n"); // Для красивого отображения на экране.
}

string[] arrayBasic = new string[rand.Next(2, 11)]; // Инициация массива случайной длины

for (int i = 0; i < arrayBasic.Length; i++) // Генерация массива случайных строк.
{
    GenerateWord(out arrayBasic[i]);
}

// Вывод исходного массива на экран.
PrintArray("Исходный массив случайных строк: ", arrayBasic);

if (count == 0)
{
    Console.WriteLine("В исходном массиве нет строк, длиною короче или равное 3 символов");
    return;
}

string[] arrayResult = new string[count]; // Инициация результируещего массива, длиное count
count = 0; // Обнуление count

for (int i = 0; i < arrayBasic.Length; i++)
{
    if (arrayBasic[i].Length <= 3)
    {

        arrayResult[count] = arrayBasic[i];
        count++;
    }
}

// Вывод результирующего массива на экран.
PrintArray("Результирующий массив случайных строк, длиною менее или равно 3 символам: ", arrayResult);
