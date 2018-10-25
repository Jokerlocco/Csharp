// Manuel Lago
// Cifrador v2 (XOR)

using System;

public class Cifrado
{
    public static void Main()
    {
        
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();
        string encryptedText = "";
        string decryptedText = "";
        
        // Encrypt
        foreach (char c in text)
            encryptedText += Convert.ToChar(c ^ 1);
        Console.WriteLine("Encrypted: " + encryptedText);

        // Decrypt
        foreach (char c in encryptedText)
            decryptedText += Convert.ToChar(c ^ 1);
        Console.WriteLine("Decrypted: " + decryptedText);
    }
}
