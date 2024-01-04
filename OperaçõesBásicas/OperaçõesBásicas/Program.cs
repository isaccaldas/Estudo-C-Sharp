int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal dQuociente = 7.0m / 5;
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient: {dQuociente}");
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
Console.WriteLine($"Decimal quotient: {decimalQuotient2}");

int primeiro = 7;
int segundo = 5;
decimal quociente = (decimal)primeiro / (decimal)segundo;
Console.WriteLine(quociente);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value = 0;     // value is now 0.
Console.WriteLine(value);
value = value + 5; // value is now 5.
Console.WriteLine(value);
value += 5;        // value is now 10.
Console.WriteLine(value);

value = 0;     // value is now 0.
Console.WriteLine(value);
value = value + 1; // value is now 1.
Console.WriteLine(value);
value++;           // value is now 2.
Console.WriteLine(value);

value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5m / 9m);
Console.WriteLine(celsius);