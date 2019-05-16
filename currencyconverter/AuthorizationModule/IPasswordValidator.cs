using System;
namespace currencyconverter.AuthorizationModule
{
    public interface IPasswordValidator : IValidator
    {
        bool MoreLessCharactersValidate(string pass);
    }
}
