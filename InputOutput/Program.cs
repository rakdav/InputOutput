// See https://aka.ms/new-console-template for more information
//Иванов Иван Иванович 22-ИСП-2/2 Вариант 6
//Даны два числа. Найти среднее арифметическое и среднее геометрическое их
//модулей.
Console.Write("Введите первую переменную:");
double var1=double.Parse(Console.ReadLine());
Console.Write("Введите вторую переменную:");
double var2 = double.Parse(Console.ReadLine());
double srArif = (var1 + var2) / 2;
double srGeom = Math.Sqrt(var1*var2/2);
Console.WriteLine("Среднее арифметическое {0:F2}, среднее" +
    " геометрическое {1:F2}",srArif,srGeom);



