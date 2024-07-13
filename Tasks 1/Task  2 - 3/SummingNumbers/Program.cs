using System.Diagnostics;


string? input;
long maximumNumber;

do
{
    Console.Write("Please enter the maximum number: ");
    input = Console.ReadLine();

    if (long.TryParse(input, out maximumNumber))
    {
        if (maximumNumber > 0)
        {
            Console.WriteLine($"Are you sure you need to get the addition up to {maximumNumber}? (Y or y for yes, N or n for no)");
            string? answer;
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
                break;
            else if (answer == "N" || answer == "n")
                continue;
            //TODO: Validate (answer)
        }
        else
          Console.WriteLine("Number cannot be negative or zero, Please enter valid number.");
    }
    else
        Console.WriteLine("Invalid input. Enter a valid integer");
}
while (true);


Console.WriteLine("------------------------------------------------");
// For Loop Approach
Console.WriteLine("The ((FOR Loop Approach))");

long sum;

sum = 0;
Stopwatch stopwatch;

stopwatch = Stopwatch.StartNew();
for (int i = 0; i <= maximumNumber; i++)
{
    sum += i;
}
stopwatch.Stop();
Console.WriteLine($"The Sum = {sum} and It takes {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

Console.WriteLine("------------------------------------------------");

// Formula Approach 
Console.WriteLine("The ((Formula Approach))");
stopwatch.Start();
sum = maximumNumber * (maximumNumber + 1) / 2;
//Console.WriteLine($"Stop watch now = {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Stop();
Console.WriteLine($"The Sum = {sum} and It takes {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

Console.WriteLine("------------------------------------------------");
