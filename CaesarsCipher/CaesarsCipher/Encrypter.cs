namespace CaesarsCipher
{
    public static class Encrypter
    {
        public static string Encrypt(string cipher, string message)
        {

            var cipherAlphabet = CreateCipherAlphabet(cipher);

            var codedMessage = "";
            foreach(var symbol in message.ToLower())
            {
                if(AlphabetRecord.Alphabet.Contains(symbol) is false)
                {
                    codedMessage += symbol;
                    continue;
                }

                var indexOfSymbol = AlphabetRecord.Alphabet.IndexOf(symbol);

                codedMessage += cipherAlphabet[indexOfSymbol];
            }

            return codedMessage;
        }

        public static string Decrypt(string cipher, string message)
        {

            var cipherAlphabet = CreateCipherAlphabet(cipher);

            var codedMessage = "";
            foreach (var symbol in message.ToLower())
            {
                if (AlphabetRecord.Alphabet.Contains(symbol) is false)
                {
                    codedMessage += symbol;
                    continue;
                }

                var indexOfSymbol = cipherAlphabet.IndexOf(symbol);

                codedMessage += AlphabetRecord.Alphabet[indexOfSymbol];
            }

            return codedMessage;
        }

        private static List<char> CreateCipherAlphabet(string cipher)
        {
            var cipherAlphabet = new List<char>();
            foreach (var c in cipher)
            {
                cipherAlphabet.Add(c);
            }

            foreach (var symbol in AlphabetRecord.Alphabet)
            {
                if (cipherAlphabet.Contains(symbol)) continue;

                cipherAlphabet.Add(symbol);
            }

            return cipherAlphabet;
        }
    }
}
