using Bogus;
using System.Text;

public class CustomPasswordGenerator
{
    private readonly Bogus.Faker _faker;

    public CustomPasswordGenerator()
    {
        _faker = new Bogus.Faker(); // Initialize Bogus Faker
    }

    public string GeneratePassword()
    {
        // Define the sets for different characters required by the rules
        var lowercase = "abcdefghijklmnopqrstuvwxyz";
        var uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var numbers = "0123456789";
        var specialCharacters = "_$!*&.";

        // Generate random characters for each category
        var password = new StringBuilder();

        // At least one lowercase
        password.Append(lowercase[_faker.Random.Int(0, lowercase.Length - 1)]);

        // At least one uppercase
        password.Append(uppercase[_faker.Random.Int(0, uppercase.Length - 1)]);

        // At least one number
        password.Append(numbers[_faker.Random.Int(0, numbers.Length - 1)]);

        // At least one special character
        password.Append(specialCharacters[_faker.Random.Int(0, specialCharacters.Length - 1)]);

        // Fill the rest of the password with random characters
        var allChars = lowercase + uppercase + numbers + specialCharacters;
        for (int i = password.Length; i < 12; i++) // Let's make the password length 12
        {
            password.Append(allChars[_faker.Random.Int(0, allChars.Length - 1)]);
        }

        // Shuffle the characters to randomize their order
        var passwordArray = password.ToString().ToCharArray();
        int n = passwordArray.Length;
        while (n > 1)
        {
            n--;
            int k = _faker.Random.Int(0, n);
            var value = passwordArray[k];
            passwordArray[k] = passwordArray[n];
            passwordArray[n] = value;
        }

        // Return the randomized password as a string
        return new string(passwordArray);
    }
}
