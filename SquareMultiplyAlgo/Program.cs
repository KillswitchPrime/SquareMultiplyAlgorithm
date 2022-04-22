using SquareMultiplyAlgo;

//the 'double' type accepts numbers all the way up to 1.7 E 308.

double baseNumber;
double exponent;
double mod;

Console.WriteLine("This program takes a base number to the power of an exponent,\n" +
    "and gives the remainder (remainder of division with the modulo number).\n" +
    "When numbers are very big, this operation is usually extremely computationally intense.\n");

var continueProgram = true;
while (continueProgram)
{

    do
    {
        Console.Write("Input base number: ");

        var successfullyParsed = double.TryParse(Console.ReadLine(), out var resultBase);

        baseNumber = successfullyParsed switch
        {
            true => resultBase,
            _ => 0
        };

    } while (baseNumber < 1);

    do
    {
        Console.Write("Input exponent: ");

        var successfullyParsed = double.TryParse(Console.ReadLine(), out var resultExponent);

        exponent = successfullyParsed switch
        {
            true => resultExponent,
            _ => 0
        };

    } while (exponent < 1);

    do
    {
        Console.Write("Input modulo: ");

        var successfullyParsed = double.TryParse(Console.ReadLine(), out var resultMod);

        mod = successfullyParsed switch
        {
            true => resultMod,
            _ => 0
        };

    } while (mod < 1);

    Console.WriteLine($"\nVisualization of inputs: {baseNumber}^{exponent} % {mod}\n");

    var result = SquareMultiply.Calculate(baseNumber, exponent, mod);

    Console.WriteLine($"Result: {result}");

    Console.Write("\nAgain? (Y/N): ");
    var continueInput = Console.ReadLine();

    continueProgram = continueInput.Trim().ToUpperInvariant() switch
    {
        "Y" => true,
        _ => false
    };
}