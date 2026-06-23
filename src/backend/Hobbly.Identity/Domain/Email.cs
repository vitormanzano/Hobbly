using System.Text.RegularExpressions;

namespace Hobbly.Identity.Domain;

public class Email
{
    public string Address { get; private set; } = string.Empty;

    public Email(string address)
    {
        SetAddress(address);
    }

    public void SetAddress(string address)
    {
        ValidateAddress(address);
        Address = address;
    }

    private void ValidateAddress(string address)
    {
        if (String.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Email cannot be empty!"); // Sometime think about result pattern. If can and how apply that here or other pattern
        if (!ValidateRegex(address)) 
            throw new ArgumentException("Email invalid!");
    }

    private bool ValidateRegex(string address)
    {
       string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple email pattern
       return Regex.IsMatch(address, pattern);
    }
}
