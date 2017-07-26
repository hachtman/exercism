using System;
using System.Linq;

public static class Bob
{

    public static string Response(string statement)
    {

        if (statement.Length == 0 || String.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        else if (CheckNoAlphas(statement) && statement[statement.Length - 1] == '?')
        {
            return "Sure.";
        }
        else if (Char.IsNumber(statement[0]) && Char.IsNumber(statement[statement.Length -1]))
        {
            return "Whatever.";
        }
        else if (!CheckNoAlphas(statement) && statement.ToUpper() == statement)
        {
            return "Whoa, chill out!";
        }
        else if (statement.TrimEnd()[statement.TrimEnd().Length - 1] == '?') {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
    }

    public static bool CheckNoAlphas(string statement)
    {
        bool result = !statement.Any(char.IsLetter);
        return result;
    }

}
