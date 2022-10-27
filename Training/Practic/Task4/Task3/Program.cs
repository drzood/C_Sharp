// // Задача 3: Напишите программу, которая будет 
// // выдавать название дня недели по заданному номеру.
// // 3 -> Среда 
// // 5 -> Пятница

// void DayOfTheWeek(int a)
// {
//     if (a < 1 || a > 8)
//     {
//         Console.WriteLine($"B неделе всего 7 дней.");
//     }
//     else if (a == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//      else if (a == 2)
//     {
//         Console.WriteLine("Вторник");
//     }
//      else if (a == 3)
//     {
//         Console.WriteLine("Среда");
//     }
//      else if (a == 4)
//     {
//         Console.WriteLine("Четверг");
//     }
//      else if (a == 5)
//     {
//         Console.WriteLine("Пятница");
//     }
//      else if (a == 6)
//     {
//         Console.WriteLine("Суббота");
//     }
//      else 
//     {
//         Console.WriteLine("Воскресение");
//     }
// }

// Console.Write("Введите день недели: ");
// int x = Convert.ToInt32(Console.ReadLine());
// DayOfTheWeek(x);