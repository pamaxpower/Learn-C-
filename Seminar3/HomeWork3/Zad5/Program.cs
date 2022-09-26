﻿/* Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов 
и вывести на экран те (тот), где чаще всего встречается введённая буква.
Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"
*/

Console.Clear();

string[] city = {"Москва", "Тюмень", "Новосибирск", "Санкт-Петербург", "Краснодар", "Казань"};

Console.WriteLine("Введите букву русского алфавита: ");
string letter = Convert.ToString(Console.ReadLine());  // введенная буква

int index = 0;

int Count (string text, char letter)       // Задал метод для переборки слова
{
    string a = city[index];                 // присвоил значение слова
    int len = city[index].Length;           // количество букв в слове
    int b = 0;                              // количество искомых букв
    for (int j = 0; j < len; j++)           // начинаю перебор 
    {
        if (a[j] == letter) b++;            // проверяю условие: если j-буква в слове соответствует введенной букве, то количество искомых букв увеличивается
    }
    return b;                               // возвращаю количество искомых букв
}

for (index = 0; index < city.Length; index++)          // делаю переборку заданного массива на поиск слов с заданной буквой
{
    if (city[index].Contains(letter.ToLower()))         // если буква есть в слове, то перехожу дальше
    {
        int value = Count((city[index]), letter);           // тут применяю написанный метод для слова содержащим букву и саму букву
                                                            // выдает ошибку, что str не удается перевести в char
    } 
    // else Console.WriteLine($"В слове {city[index]} нет буквы {letter}"); 
}
    
