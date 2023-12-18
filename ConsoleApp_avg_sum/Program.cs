// See https://aka.ms/new-console-template for more information
using System.Drawing;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Вывод среднего арифметического введенных чисел");
Console.WriteLine("Ввводите необходимое количество чисел, а для выполнения расчета введите 'готово'");
string _enterChar = "";
Console.ForegroundColor = ConsoleColor.White;
int _i = 0;
double _sum = 0;
do
{
    Console.WriteLine("Введите число № " + (_i + 1).ToString()+ ". Для выполнения расчета введите 'готово'");
    _enterChar = Console.ReadLine();
    if (_enterChar.ToUpper() != ("ГОТОВО"))
    {
        try
        {
            double _enterdouble = Convert.ToDouble(_enterChar);
            _i++;
            _sum += _enterdouble;
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ошибка преобразования в число");
        }
    }
} while (_enterChar.ToUpper() != ("ГОТОВО"));
_sum = _sum /_i;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введено " + _i.ToString() + " чисел");
Console.WriteLine("Среднее арифметичесоке введенных чисел = "+_sum.ToString());
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Для выхода нажмите любую клавишу");
Console.ReadKey();