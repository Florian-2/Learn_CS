using Func;

class Program
{
    static void Main(string[] args)
    {
        int c = Functions.CountWords("je suis une phrase");
        Console.WriteLine($"{c} mots");

        int result = Functions.Addition(20, 4, 9); // 33
        Console.WriteLine(result);

        Functions.GetMinMaxOutParams(out double mini, out double maxi, 2, 8, 34, 3);
        Console.WriteLine($"Valeur mini : {mini} et valeur maximal : {maxi}");
    }
}
