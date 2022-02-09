//Задача 2: Даны два числа. Показать большее и меньшее число
/*int numberA = new Random().Next(1, 10); // 1 2 3 4 ...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

if(numberA > numberB);
{
    Console.WriteLine(numberA  +  " Большее число ");
    Console.WriteLine(numberB  +  " Меньшее число ");
}
else if (numberA < numberB);
{
   Console.WriteLine(numberB  +  "Большее число");
   Console.WriteLine(numberB  +  "Меньшее число");
}
else 
{
    Console.WriteLine(" Числа равны ");
}*/


 Console.WriteLine("Введите первое число: ");
 int num1 = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
 int num2 = int.Parse(Console.ReadLine());
 if (num1 > num2)
 {
     Console.Write("Число " + num1 + " большее");
 }
 else if(num1 < num2)
 {
     Console.Write("Число " + num1 + " меньшее");
 }
 else 
 {
   Console.Write(" Число  " + num1 + " и число " + num2 + " равны ");
 }


