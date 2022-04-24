using Xunit;

namespace CaesarsCipher.Test
{
    public class EncrypterTests
    {
        [Fact]
        public void Encrypt_Valid()
        {
            var cipher = "cipher";
            var message = "message that should be shifted";
            var expected = "kesscae tbct sbmujh ie sbdrteh";

            var shiftedMessage = Encrypter.Encrypt(cipher, message);

            Assert.NotNull(shiftedMessage);
            Assert.NotEmpty(shiftedMessage);

            Assert.Equal(expected, shiftedMessage);
        }

        [Fact]
        public void Decrypt_Valid()
        {
            var cipher = "cipher";
            var message = "kesscae tbct sbmujh ie sbdrteh";
            var expected = "message that should be shifted";

            var shiftedMessage = Encrypter.Decrypt(cipher, message);

            Assert.NotNull(shiftedMessage);
            Assert.NotEmpty(shiftedMessage);

            Assert.Equal(expected, shiftedMessage);
        }
    }
}