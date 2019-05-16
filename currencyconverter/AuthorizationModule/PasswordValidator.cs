using System;
namespace currencyconverter.AuthorizationModule
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool MoreLessCharactersValidate(string pass)
        {
            if (pass.Length >= 6)
                return true;
            else
                return false;
        }

        public bool Validate(string password)
        {        
            return !string.IsNullOrEmpty(password);
        }
    }
}
