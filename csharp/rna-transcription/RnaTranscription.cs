using System;
using System.Collections.Generic;

public static class Complement
{
    public static string OfDna(string nucleotide)
    {
        char[] rnaArray = new char[nucleotide.Length];

        for (int i = 0; i < nucleotide.Length; i++)
        {
            if (nucleotide[i] == 'G')
            {
                rnaArray[i] = 'C';
            }
            else if (nucleotide[i] == 'C')
            {
                rnaArray[i] = 'G';
            }
            else if (nucleotide[i] == 'T')
            {
                rnaArray[i] = 'A';
            }
            else
            {
                rnaArray[i] = 'U';
            }
            // rnaArray[i] = nucleotide[i].ToString();
        }
        return string.Join("", rnaArray);
    }
}
