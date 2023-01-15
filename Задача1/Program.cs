Console.WriteLine("Введите первое число: ");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число: ");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

if (number1 > number2){
    Console.WriteLine(number1 + " больше, " + number2 + " меньше");
}
else Console.WriteLine(number2 + " больше, " + number1 + " меньше");
