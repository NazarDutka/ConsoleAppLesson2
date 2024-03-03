using MyCalculationClassLibrary;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? input = Console.ReadLine();
input ??= string.Empty;
string[] srtA = input.Split(' ');
int[] numbers = Converters.ToInt(srtA);
int sum = Mathematics.Sum(numbers);

sum = LinqDemo.TryParseAndSum(input);

Console.WriteLine("sum is following: {0}", sum);

