using System.Text.RegularExpressions;

Console.WriteLine("This program will encrypt and decrypt text using caesars cipher.");

string message;
string cipher;
int shift;

Regex regex = new(@"([,.A-Åa-å])\\w+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

do
{
    Console.Write("Input message: ");

    message = Console.ReadLine();

} while (string.IsNullOrWhiteSpace(message) is true || regex.IsMatch(message) is false);

do
{
    Console.Write("Input cipher: ");

    cipher = Console.ReadLine();

} while (string.IsNullOrWhiteSpace(cipher) is true || regex.IsMatch(cipher) is false);

do
{
    shift = -1;
    
    Console.Write("Input cipher: ");

    var succesfullyParsed = int.TryParse(Console.ReadLine(), out var number);

    if (succesfullyParsed) 
    { 
        shift = number; 
    }

} while (shift < 0);

