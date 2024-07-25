namespace HBDPG_1_WindowsApp;

public static class HBDPG_1
{
    private static readonly MD5 md5 = MD5.Create();
    private static readonly SHA256 sha256 = SHA256.Create();

    private static readonly char[,] symbols = { { '!', '@', '#', '$', '%', '^', '&', '*', '/', ')', '[', '{', '-', '=', '<', '?', ',', ';', '`' },
                                              { '.', ',', '|', '?', '\\', ';', ':', '"', '\'', '(', ']', '}', '+', '_', '>', '^', '$', '!', '~' } };

    /// <summary>
    /// Pers HBDPG-1 algorithm.
    /// </summary>
    /// <param name="passkey">Passkey to calculate.</param>
    /// <returns>Calculated password.</returns>
    public static StringBuilder CalculatePassword(StringBuilder passkey)
    {
        StringBuilder hash1 = GetHash(passkey, md5);
        StringBuilder hash2 = GetHash(passkey.Append(hash1), sha256);
        StringBuilder result = GetHash(hash1.Append(hash2), md5);

        List<int> numbers = new();
        List<int> sumPairs = new();

        // all numbers from hash2
        foreach (char c in hash2.ToString())
            if (char.IsDigit(c)) numbers.Add(c - '0');

        numbers.Reverse();

        // sums of numbers pairs
        for (int i = 0; i < numbers.Count - 1; i++)
            sumPairs.Add(numbers[i] + numbers[i + 1]);

        int interval = sumPairs[0] switch
        {
            < 3 => 7,
            < 5 => sumPairs[0] * 2,
            > 9 => sumPairs[0] / 2,
            _ => sumPairs[0]
        };

        // insert symbols
        for (int i = interval / 2, num = 1; i < result.Length; i += interval, num = ((num += interval) >= sumPairs.Count) ? 0 : num)
            result.Replace(result[i], symbols[(numbers.Sum() + i) % 2, sumPairs[num]], i, 1);
        
        // insert uppercase letters
        for (int i = 0; i < result.Length; i++)
            if (i % (2 + numbers.Sum() % 3) == 0 && char.IsLower(result[i]))
                result.Replace(result[i], char.ToUpper(result[i]), i, 1);
        
        if (sumPairs.Sum() % 2 == 0) Reverse(ref result);

        return result;
    }

    private static void Reverse(ref StringBuilder input)
    {
        StringBuilder result = new();
        for (int i = input.Length - 1; i >= 0; i--)
            result.Append(input[i]);
        input = result;
    }

    private static StringBuilder GetHash(StringBuilder input, HashAlgorithm algorithm)
    {
        StringBuilder result = new();
        byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input.ToString()));

        for (int i = 0; i < data.Length; i++)
            result.Append(data[i].ToString("x2"));

        return result;
    }
}
