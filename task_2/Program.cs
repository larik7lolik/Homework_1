//Задача 2: Даны два числа. Показать большее и меньшее число
int numberA = new Random().Next(1, 10); // 1 2 3 4 ...9
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
}

