using MyCalulationClassLibrary;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? intput = Console.ReadLine();
//string[] srtA = intput.Split(' ');
//int[] numbers = Converters.ToInt(srtA);
//int sum = Mathematics.Sum(numbers);

int? sum = intput?.Split(' ')
    .Select((string str) => 
    { 
        int.TryParse(str, out var number);
        return number;
    })
    .Sum();

Console.WriteLine("sum is following: {0}", sum);


