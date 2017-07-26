using System;

public static class Gigasecond
{
    public static DateTime Date(DateTime birthDate)
    {
        double gigasecond = 1000000000;
        return birthDate.AddSeconds(gigasecond);
    }
}
