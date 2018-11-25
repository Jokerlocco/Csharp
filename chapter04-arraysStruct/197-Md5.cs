// Ivan Lazcano
// Cracking an MD5 hash

using System;
using System.Security.Cryptography;
using System.Text;

public class CrackingMD5
{
    public static void Main()
    {

        for (int j = 10000; j < 99999; j++)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(j.ToString()));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            string hash = sBuilder.ToString();
            if (hash == "099ebea48ea9666a7da2177267983138")
            {
                Console.WriteLine("Found: " + j);
                break;
            }
        }
    }
}
