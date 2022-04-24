using CaesarsCipher;
using System.Text.RegularExpressions;

Console.WriteLine("This program will encrypt and decrypt text using caesars cipher.");

string message;
string cipher;
int shift;

Regex regex = new(@"([\s,.A-Åa-å])\w+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

while (true)
{
    do
    {
        Console.Write("Input message: ");

        message = Console.ReadLine();

    } while (string.IsNullOrWhiteSpace(message) is true || regex.IsMatch(message) is false);

    do
    {
        Console.Write("Input cipher (one word, no repeat characters): ");

        cipher = Console.ReadLine();

        var noRepeats = true;
        foreach (var symbol in cipher)
        {
            if (cipher.Count(s => s.Equals(symbol)) > 1)
            {
                noRepeats = false;
            }
        }

        if (noRepeats is false)
        {
            cipher = "";
        }

    } while (string.IsNullOrWhiteSpace(cipher) is true || regex.IsMatch(cipher) is false);

    do
    {
        shift = -1;

        Console.Write("Input shift: ");

        var input = Console.ReadLine();

        var succesfullyParsed = int.TryParse(input, out var number);

        if (succesfullyParsed)
        {
            shift = number;
        }

    } while (shift < 0);

    var shiftedMessage = Shifter.EncryptionShift(shift, message);

    Console.WriteLine(shiftedMessage);
}