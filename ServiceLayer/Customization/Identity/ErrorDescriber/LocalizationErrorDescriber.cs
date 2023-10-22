using Microsoft.AspNetCore.Identity;

namespace ServiceLayer.Customization.Identity.ErrorDescriber
{
    public class LocalizationErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            //return new() { Code = "NewDigitError", Description = "Please Use Digits" };
            return base.PasswordRequiresDigit();
        }

        public override IdentityError PasswordRequiresLower()
        {
            //return new() { Code = "NewLowerLettersError", Description= "Please Use Lower Letters" };
            return base.PasswordRequiresLower();

        }

        public override IdentityError PasswordTooShort(int length)
        {
            //return new() { Code = "NewTooShortError", Description = "Your Password too short!" };
            return base.PasswordTooShort(length);

        }

      
    }
}
