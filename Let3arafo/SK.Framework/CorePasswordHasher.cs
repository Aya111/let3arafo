using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace SK.Framework
{
    /// <summary>
    /// Password Hasher that use PBKDF2 with HMAC-SHA256, 128-bit salt, 256-bit subkey, 10000 iterations
    /// </summary>
    public static class CorePasswordHasher
    {
        // HACK: https://github.com/aspnet/Identity/blob/5da757642dd7c7a25315250ae3738b87f622cb4c/src/Microsoft.AspNet.Identity/PasswordHasher.cs
        // PasswordHasher class doesn't use the user object passed in the following method.
        // If this break in the future -- which is not possible right now -- here is the place you are looking for.

        private readonly static IOptions<PasswordHasherOptions> _options = Options.Create(new PasswordHasherOptions
        {
            CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3,
            IterationCount = 10_000
        });

        public static string HashPassword(string password)
        {
            var ph = new PasswordHasher<object>(_options);
            var result = ph.HashPassword(null, password);

            return result;
        }

        public static bool VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            var ph = new PasswordHasher<object>(_options);
            var result = ph.VerifyHashedPassword(null, hashedPassword, providedPassword);

            if(result == PasswordVerificationResult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}