namespace Task2.Analyzer;

public class BinaryStringAnalyzer
{
    public bool IsGoodBinaryString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        var countZero = 0;
        var countOne = 0;

        for (var i = 0; i < input.Length; i++)
        {
            var c = input[i];
            if (c == '0')
            {
                countZero++;
            }
            else if (c == '1')
            {
                countOne++;
            }
            else
            {
                return false;
            }

            if (countOne < countZero)
            {
                return false;
            }
        }

        return countOne == countZero;
    }
}
