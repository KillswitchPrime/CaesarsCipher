namespace CaesarsCipher
{
    public static class Shifter
    {
        public static string EncryptionShift(int shift, string message)
        {
            var shiftedMessage = "";

            foreach (var symbol in message)
            {
                if (AlphabetRecord.Alphabet.Contains(char.ToLower(symbol)) is false)
                {
                    shiftedMessage += symbol;
                    continue;
                }

                var currentIndex = AlphabetRecord.Alphabet.IndexOf(char.ToLower(symbol));
                var shiftedIndex = currentIndex + shift;

                if (shiftedIndex > AlphabetRecord.Alphabet.Count)
                {
                    shiftedIndex -= AlphabetRecord.Alphabet.Count - 1;
                }

                shiftedMessage += AlphabetRecord.Alphabet[shiftedIndex];

            }

            return shiftedMessage.ToString();
        }
    }
}
