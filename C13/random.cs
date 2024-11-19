namespace C13;

public class CommonFunctions
{
    private static readonly Random getrandom = new Random();

    public static int GetRandomNumber(int min, int max)
    {
        lock (getrandom)
        {
            return getrandom.Next(min, max);
        }
    }
}
