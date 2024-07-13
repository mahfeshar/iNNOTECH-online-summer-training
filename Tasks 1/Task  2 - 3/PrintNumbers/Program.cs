
using System.Diagnostics;
using System.Text;

string? input;
long maximumNumber;

do
{
    Console.Write("Please enter the maximum number you need to print: ");
    input = Console.ReadLine();
    if (long.TryParse(input, out maximumNumber))
    {
        if (maximumNumber > 0)
            break;
        else
            Console.WriteLine("Number cannot be negative or zero, Please enter valid number.");
    }
    else
        Console.WriteLine("Invalid input. Enter a valid integer");
}
while (true);

Console.WriteLine("------------------------------------------------");
// Using Normal String

Console.WriteLine("Using Normal String");

string resultNumbers;
Stopwatch stopwatch;

stopwatch = Stopwatch.StartNew();
resultNumbers = string.Empty;

for (int i = 1; i <= maximumNumber; i++)
{
    // We need to remove comma from the end
    // First Sol

    if (i == 1)
        resultNumbers += i.ToString();
    else
        resultNumbers += "," + i.ToString();

    // Second sol
    // We can make it from the end, when i == max -> print just number

    // We can also try:
    // if (i != 1)
    //      result += ","
    // result += i.ToString()

    // But last one will increase the time (Bad Approach)
}
stopwatch.Stop();

//Console.WriteLine($"All numbers from 1 to {maximumNumber} = {resultNumbers}");
//Console.WriteLine();
Console.WriteLine($"The time is {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();


Console.WriteLine("------------------------------------------------");
// Using StringBuilder

Console.WriteLine("Using StringBuilder");

stopwatch = Stopwatch.StartNew();
StringBuilder resultNumberWithBuilder;

resultNumberWithBuilder = new StringBuilder();

for (int i = 1; i <= maximumNumber; i++)
{
    if (i == 1)
        resultNumberWithBuilder.Append(i.ToString());
    else
        resultNumberWithBuilder.Append($",{i.ToString()}");
}

stopwatch.Stop();

//Console.WriteLine($"All numbers from 1 to {maximumNumber} = {resultNumberWithBuilder}");
//Console.WriteLine();
Console.WriteLine($"The time is {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();
Console.WriteLine("------------------------------------------------");
