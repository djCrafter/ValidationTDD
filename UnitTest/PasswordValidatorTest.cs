using currencyconverter.AuthorizationModule;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class PasswordValidatorTest
    {
        private IPasswordValidator _passwordValidator;

        [SetUp]
        public void SetUp()
        {
            _passwordValidator = new PasswordValidator();
        }

        [TestCase("")]
        [TestCase(null)]
        public void PassIsEmptyOrNullTest(string pass)
        {
            //When
            var actual = _passwordValidator.Validate(pass);

            //Then
            Assert.IsFalse(actual);
        }

        [TestCase("mypassword123")]
        public void PassMoreThanSixCharacters(string pass)
        {
            Assert.IsTrue(_passwordValidator.MoreLessCharactersValidate(pass));
        }

        [TestCase("123")]
        public void PassLessThanSixCharacters(string pass)
        {
            Assert.IsFalse(_passwordValidator.MoreLessCharactersValidate(pass));
        }
    }
}
