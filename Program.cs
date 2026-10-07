using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;

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


string[] students1 = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string student in students1)
{
    Console.WriteLine($"{number}. {student}");
    number++;
}

Console.WriteLine("Самостоятельное задание А");
int[] numbers = { 10, 25, 30, 45, 15 };
int summ = 0;

foreach (int num in numbers)
{
    Console.WriteLine(num);
    summ += num;
}
Console.WriteLine($"Сумма чисел: {summ}");

Console.WriteLine("Самостоятельное задание Б");
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

foreach (string day in days)
{
    Console.WriteLine($"{day}!");
}

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


Console.WriteLine("Вариант 4");
int[] sum2 = [500, 400, 200, 150, 1000];
int totalsum = 0;
int count = 0;

foreach (int summ1 in sum2)
{
    totalsum += summ1;
    if (summ1 > 500)
    {
    count++; 
    }

}
Console.WriteLine($"Накопление суммы: {totalsum}");
Console.WriteLine($"Дороже 500: {count}");

Console.WriteLine("Вариант 8");
string word = "Программирование";
for (int a = word.Length - 1; a >= 0; a--){
    Console.WriteLine(word[a]);
}