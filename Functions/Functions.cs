namespace Func;

public class Functions
{
    public static int CountWords(string sentence)
    {
        string[] words = sentence.Split(' ');

        return words.Length;
    }

    // Nombre indéfini de paramètre (du meme type)
    public static int Addition(params int[] numbers)
    {
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }

        return result;
    }

    // Exemple de fonction qui return un TUPLE, pratique quand on souhaite return plusieurs valeurs.
    public static (double, double) GetMinMax(double[] numbers)
    {
        double min = double.MaxValue;
        double max = double.MinValue;

        foreach (double number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }

        return (min, max);
    }

    /*
        Quand un paramètre est précédé du mot-clé "out", cela veut dire que ce paramètre sera fourni par la méthode. Ce sont des paramètres de sortie et non d'entrée.

        Au moment de l'appel de cette méthode, il faut préciser que l'on souhaite récupérer les paramètres de sortie de cette façon :

            Functions.GetMinMaxOutParams(out double mini, out double maxi, 2, 8, 34, 3);

    */
    public static void GetMinMaxOutParams(out double min, out double max, params double[] numbers)
    {
        min = double.MaxValue;
        max = double.MinValue;

        foreach (double number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }
    }
}
