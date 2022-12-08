Console.WriteLine("Введите число соответствующее дню недели");
int day = Convert.ToInt32(Console.ReadLine() ??"");
switch (day)    
{
    case 1 : Console.WriteLine("Первый день недели это понедельник. ");   
    break;
    case 2 : Console.WriteLine("Второй день недели это вторник. ");
    break;
    case 3 : Console.WriteLine("Третий день недели это среда. ");
    break;
    case 4 : Console.WriteLine("Четвертый день недели это четверг. ");
    break;
    case 5 : Console.WriteLine("Пятый день недели это пятница. ");
    break;
    case 6 : Console.WriteLine("Шестой день недели это суббота. ");
    break;
    case 7 : Console.WriteLine("Седьмой день недели это воскресенье. ");
    break;
    default:
    Console.WriteLine("В недели только 7 дней. Нужно вводить число только от 1 до 7.");
    break;
}
if (Math.Abs(day) <=5 )
    {
    Console.Write("Этот день не выходной");
    }
else if((day == 6) || (day == 7))
    {
    Console.WriteLine("Этот день является выходным.");
    }
