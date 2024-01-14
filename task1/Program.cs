// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
// Console.WriteLine(mas);

///////////////////////////////////////////////////////
// Вызов массива при помощи цикла While
int ind = 0;
while(ind < mas.Length)
{
    Console.Write($"{mas[ind]}\t");
    ind = ind + 1;
}
Console.WriteLine();

////////////////////////////////////////////////////////
// // Вызов массива при помощи цикла For
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]}\t");
}
Console.WriteLine();

////////////////////////////////////////////////////////
// //Вызов массива при помощи foreach
foreach (var item in mas)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();
///////////////////////////////////////////////////////
//Функция
void Print_mas(int[] col)
{
    foreach (var item in col)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();
}
Print_mas(mas);
////////////////////////////////////////////////////////

int[] Random_mas(int[]col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }
    return col; 
}
int[] new_mas = Random_mas(mas);
Print_mas(new_mas);

//Число вводимое пользователем:
Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// Счетчик
int count = 0;

foreach (var item in new_mas)
{
    if(item == num)
    {
        count++;
        break;
    }
}
if(count != 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Да");
}