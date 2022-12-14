namespace TODO.Domain.Extensions;

public static class Md5Extension
{
    public static int ToMd5(this string input)
    {
        // Use input string to calculate MD5 hash
        using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        return Convert.ToInt16(hashBytes);
    }
}
