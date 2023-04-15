﻿Console.Write("Ввидите год: ");
int year = Convert.ToInt32(Console.ReadLine());                                      // Ввод года
if (year > 0)                                                                        // Проверка на Маслова
{
    string[,] sign =                                                                 // Массив {Знак года,окончиние}
    { 
        { "Обезьяны", "й " },{ "Петуха", "го " },{ "Собоки", "й " },{ "Свиньи", "й " },{ "Крысы", "й " },{ "Быка", "го " },
        { "Тигра", "го " },{ "Кролика", "го " },{ "Дракона", "го " },{ "Змеи", "й " },{ "Лошади", "й " }, { "Овцы", "й " } 
    };
    string[] skin = { "металлическо", "водно", "деревянно", "огняно", "земляно" };   // Массив с окраской  
    int signPoint = year % 12, skinPoint = year % 10 / 2;                            // Поиск идокса знака года / окраски
    Console.WriteLine("Год " + year + " является годом " + skin[skinPoint] + sign[signPoint, 1] + sign[signPoint, 0]);   // Вывод предложения 
}
else
{
    Console.WriteLine("Вы маслов?");
}

            
