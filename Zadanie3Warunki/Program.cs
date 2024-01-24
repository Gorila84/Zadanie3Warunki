int number;

Console.WriteLine("Wprowadź liczbę: ");
var enteredNumber = Console.ReadLine();

Int32.TryParse(enteredNumber, out number);


if (number > 0)
{
    Console.WriteLine($"{number} jest liczbą dodatnią");
}
else if(number == 0){
    Console.WriteLine($"{number} nie jest liczbą dodatnią ani liczbą ujemną");
}
else
{
    Console.WriteLine($"{number} jest liczbą ujemną");
}
