using Xunit;

namespace CaesarsCipher.Test
{
    public class ShifterTests
    {
        [Theory]
        [InlineData(5, "test", "yjxy")]
        [InlineData(26, "test", "rcqr")]
        [InlineData(0, "test", "test")]
        public void EncryptionShift_Valid(int shift, string message, string expected)
        {
            var shiftedMessage = Shifter.EncryptionShift(shift, message);

            Assert.NotNull(shiftedMessage);
            Assert.NotEmpty(shiftedMessage);

            Assert.Equal(expected, shiftedMessage);
        }

        [Theory]
        [InlineData(5, "yjxy", "test")]
        [InlineData(26, "rcqr", "test")]
        [InlineData(0, "test", "test")]
        public void DecryptionShift_Valid(int shift, string message, string expected)
        {
            var shiftedMessage = Shifter.DecryptionShift(shift, message);

            Assert.NotNull(shiftedMessage);
            Assert.NotEmpty(shiftedMessage);

            Assert.Equal(expected, shiftedMessage);
        }
    }
}
