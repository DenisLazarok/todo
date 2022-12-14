namespace TODO.Domain.Extensions;

public static class Md5Extension
{
    /// <summary>
    /// string to md5 convert
    /// </summary>
    /// <param name="input">any string</param>
    /// <returns></returns>
    public static string ToMd5(this string input)
    {
        // Use input string to calculate MD5 hash
        using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        return Convert.ToHexString(hashBytes);
    }
}
