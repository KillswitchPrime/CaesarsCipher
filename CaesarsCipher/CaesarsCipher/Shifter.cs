namespace CaesarsCipher
{
    public static class Shifter
    {
        public static string EncryptionShift(int shift, string message, LanguageEnum languageEnum)
        {
            var shiftedMessage = "";

            foreach (var symbol in message.ToLower())
            {
                if (AlphabetRecord.Alphabet[languageEnum].Contains(symbol) is false)
                {
                    shiftedMessage += symbol;
                    continue;
                }

                var currentIndex = AlphabetRecord.Alphabet[languageEnum].IndexOf(symbol);
                var shiftedIndex = currentIndex + shift;

                if (shiftedIndex >= AlphabetRecord.Alphabet[languageEnum].Count)
                {
                    shiftedIndex -= AlphabetRecord.Alphabet[languageEnum].Count - 1;
                }

                shiftedMessage += AlphabetRecord.Alphabet[languageEnum][shiftedIndex];
            }

            return shiftedMessage;
        }

        public static string DecryptionShift(int shift, string message, LanguageEnum languageEnum)
        {
            var shiftedMessage = "";

            foreach (var symbol in message.ToLower())
            {
                if (AlphabetRecord.Alphabet[languageEnum].Contains(symbol) is false)
                {
                    shiftedMessage += symbol;
                    continue;
                }

                var currentIndex = AlphabetRecord.Alphabet[languageEnum].IndexOf(symbol);
                var shiftedIndex = currentIndex - shift;

                if (shiftedIndex < 0)
                {
                    shiftedIndex += AlphabetRecord.Alphabet[languageEnum].Count - 1;
                }

                shiftedMessage += AlphabetRecord.Alphabet[languageEnum][shiftedIndex];
            }

            return shiftedMessage;
        }
    }
}
