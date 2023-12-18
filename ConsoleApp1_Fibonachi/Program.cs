// See https://aka.ms/new-console-template for more information
using System.Drawing;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Вывод значения числа Фибоначи по порядковому номеру последовательности (номер члена начинается с 0)");
string _enterChar = "";
double _fibonachi = 0;
double _fibonachi_1 = 0;
double _fibonachi_2 = 1;
Int64 _enterInt = 0;
bool _isInt = false;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Введите число");
    _enterChar = Console.ReadLine();
    try
    {
        _enterInt = Convert.ToInt64(_enterChar);
        if (_enterInt >0)
        {
            _isInt = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите число больше 0");
            _isInt = false;
        }
    }
    catch
    {
        _isInt = false;
    }
} while (_isInt == false);
if (_enterInt != 0)
{
    for (int i = 1; i <= _enterInt; i++)
    {
        _fibonachi = _fibonachi_1 + _fibonachi_2;
        _fibonachi_2 = _fibonachi_1;
        _fibonachi_1 = _fibonachi;
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Число Фибоначи № "+ _enterInt.ToString() + " равно = " + _fibonachi.ToString());
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Для выхода нажмите любую клавишу");
Console.ReadKey();