using System.Diagnostics.CodeAnalysis;
using System.Drawing;

string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв в слове: {subject.Length}");

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;

foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;
}
Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");

string[] students = { "Аня", "Ярослав", "Вика" };
int sum1 = 0;

foreach (string student in students) {
    Console.WriteLine(student);
    sum1++;
}
Console.WriteLine($"Всего учеников: {sum1}");

int[] points = { 10, 20, 15};

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}
foreach (int point in points)
    {
        Console.WriteLine(point);
    }

