using Microsoft.AspNetCore.Identity;

namespace Hobbly.Identity.Domain;

public class Password
{
   public string Value { get; private set; } = string.Empty;

   public Password(string value)
   {
       Set(value);
   }

    public void Set(string value)
    {
        Validate(value);
        Value = Hash(value);
    }

    private void Validate(string value)
    {

    }

    private string Hash(string value)
    {
        var hasher = new PasswordHasher<string>();
        return hasher.HashPassword(string.Empty, value);
    }
}
