namespace CaesarsCipher
{
    internal static class AlphabetRecord
    {
        private static readonly List<char> LanguageEn = new()
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
        };
        
        private static readonly List<char> LanguageNo = new()
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            'æ',
            'ø',
            'å'
        };
        
        public static readonly Dictionary<LanguageEnum, List<char>> Alphabet = new()
        {
            { LanguageEnum.EN, LanguageEn },
            { LanguageEnum.NO, LanguageNo }
        };
        
    }
}
