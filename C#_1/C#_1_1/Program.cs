int numberA =-3;
int numberB =-6;
int max =1;
int min =0;
if (numberA>numberB)
{
  max =numberA;
  min =numberB;
}
else 
{
   max =numberB;
   min =numberA;
}
Console.Write ("Большее число: ");
Console.WriteLine(max);
Console.Write ("Меньшее число: ");
Console.WriteLine(min);