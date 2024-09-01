
Console.Write("Please input temperature in degrees Fahrenheit: ");
string input = Console.ReadLine();

int degF = Convert.ToInt32(input);

double degC = 5 * (degF - 32.0) / 9.0;

Console.WriteLine("{0} degrees Fahrenheit = {1} degrees Celsius",input,Math.Round(degC,1));

