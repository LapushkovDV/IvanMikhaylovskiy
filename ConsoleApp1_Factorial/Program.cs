// See https://aka.ms/new-console-template for more information
using System.Drawing;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Вывод факториала введенного числа");
string _enterChar = "";

double _factorial = 1;
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
        _isInt = true;
    }
    catch
    {
        _isInt = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ошибка преобразования в число");
    }
} while (_isInt == false);

for (int i = 1; i<= _enterInt; i++)
{
    _factorial = _factorial * i;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Факториал введенного числа = " + _factorial.ToString());
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Для выхода нажмите любую клавишу");
Console.ReadKey();