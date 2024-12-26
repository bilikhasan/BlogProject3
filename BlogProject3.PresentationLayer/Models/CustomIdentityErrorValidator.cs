using Microsoft.AspNetCore.Identity;

namespace BlogProject3.PresentationLayer.Models
{
    public class CustomIdentityErrorValidator : IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = "HATA! Bu email Adresi Zaten Sistemde Kayıtlı."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "HATA! Lütfen en az 1 rakam giriniz!"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "HATA! Lütfen en az 1 küçük harf giriniz!"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "HATA! Lütfen en az 1 büyük harf giriniz!"
            };
        }


        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "HATA! Lütfen en az 1 tane sembol giriniz!"
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "HATA! Lütfen en az 6 karakter giriniz!"
            };
        }

    }
}
