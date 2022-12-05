using CaesarsCipher;
using System.Text.RegularExpressions;

Console.WriteLine("This program will encrypt and decrypt text using caesars cipher.");

string message;
string cipher;
int shift;

Regex regex = new(@"([\s,.A-Åa-å])\w+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

do
{
    char langChar;
    do
    {
        Console.Write("Input language code (e = EN, n = NO): ");
        var langKey = Console.ReadKey();
        Console.WriteLine();

        langChar = langKey.KeyChar;

    } while (langChar != 'e' && langChar != 'n');

    var languageEnum = langChar == 'e' ? LanguageEnum.EN : LanguageEnum.NO;
    
    // TODO: Add logic for switching between encryption and decryption.
    Console.WriteLine("Input 'e' for encryption and 'd' for decryption: ");
    var selectedKey = Console.ReadKey();
    Console.WriteLine();

    var keyChar = selectedKey.KeyChar;

    if (keyChar != 'e' && keyChar != 'd') continue;

    do
    {
        Console.Write("Input message: ");

        message = Console.ReadLine();

    } while (string.IsNullOrWhiteSpace(message) || regex.IsMatch(message) is false);

    var noRepeats = true;
    do
    {
        Console.Write("Input cipher (one word, no repeat characters): ");

        cipher = Console.ReadLine();
        
        foreach (var symbol in cipher)
        {
            if (cipher.Count(s => s.Equals(symbol)) > 1)
            {
                noRepeats = false;
            }
        }

        if (string.IsNullOrEmpty(cipher))
            noRepeats = true;

    } while (noRepeats is false);

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

    var completedMessage = "";
    if(keyChar == 'e')
    {
        var shiftedMessage = Shifter.EncryptionShift(shift, message, languageEnum);

        completedMessage = Encrypter.Encrypt(cipher, shiftedMessage, languageEnum);
    }
    else if(keyChar == 'd')
    {
        var decryptedMessage = Encrypter.Decrypt(cipher, message, languageEnum);

        completedMessage = Shifter.DecryptionShift(shift, decryptedMessage, languageEnum);
    }

    Console.WriteLine();
    Console.WriteLine(completedMessage);
    Console.WriteLine();

} while (true);