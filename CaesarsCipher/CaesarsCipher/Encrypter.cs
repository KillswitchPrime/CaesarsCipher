namespace CaesarsCipher
{
    public static class Encrypter
    {
        public static string Encrypt(string cipher, string message, LanguageEnum languageEnum)
        {
            var cipherAlphabet = CreateCipherAlphabet(cipher, languageEnum);

            var codedMessage = "";
            foreach(var symbol in message.ToLower())
            {
                if(AlphabetRecord.Alphabet[languageEnum].Contains(symbol) is false)
                {
                    codedMessage += symbol;
                    continue;
                }

                var indexOfSymbol = AlphabetRecord.Alphabet[languageEnum].IndexOf(symbol);

                codedMessage += cipherAlphabet[indexOfSymbol];
            }

            return codedMessage;
        }

        public static string Decrypt(string cipher, string message, LanguageEnum languageEnum)
        {

            var cipherAlphabet = CreateCipherAlphabet(cipher, languageEnum);

            var decodedMessage = "";
            foreach (var symbol in message.ToLower())
            {
                if (AlphabetRecord.Alphabet[languageEnum].Contains(symbol) is false)
                {
                    decodedMessage += symbol;
                    continue;
                }

                var indexOfSymbol = cipherAlphabet.IndexOf(symbol);

                decodedMessage += AlphabetRecord.Alphabet[languageEnum][indexOfSymbol];
            }

            return decodedMessage;
        }

        private static List<char> CreateCipherAlphabet(string cipher, LanguageEnum languageEnum)
        {
            var cipherAlphabet = new List<char>();
            foreach (var c in cipher)
            {
                cipherAlphabet.Add(c);
            }

            foreach (var symbol in AlphabetRecord.Alphabet[languageEnum])
            {
                if (cipherAlphabet.Contains(symbol)) continue;

                cipherAlphabet.Add(symbol);
            }

            return cipherAlphabet;
        }
    }
}
