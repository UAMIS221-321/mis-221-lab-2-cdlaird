using System.Numerics;
using System.Runtime.InteropServices;

int numberOfSanwiches = GetNumberOfSandwiches();
int numberOfToppings = GetNumberOfToppings();

System.Console.WriteLine("Please express tip as Decimal: ");
double tip = double.Parse(Console.ReadLine());


double totalSandwichCost= 4.75*numberOfSanwiches;
double totalToppingCost= 0.55*numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tip + baseCost - (baseCost * 0.10);

static int GetNumberOfSandwiches()
    { 
    Console.WriteLine("How many sandwiches would you like?");
    return int.Parse(Console.ReadLine());
    }

 static int GetNumberOfToppings()
    {
    Console.WriteLine("How many toppings do you want");
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("Your total order cost is: " + orderCost);


