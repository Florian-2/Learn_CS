using System.Text;

class Program
{
    static void Main(string[] args)
    {

    }

    public void InitString()
    {
        string s1 = "abc";   // syntaxe la plus commune

        string s2 = new string('*', 7); // N fois le même caractère

        char[] ar = { 'e', 'f', 'g' };
        string s3 = new string(ar);   // initialisation à partir d'un tableau de caractères

        Console.WriteLine(s1); // abc
        Console.WriteLine(s2); // *******
        Console.WriteLine(s3); // efg
    }

    /*
        Les chaîne Verbatime (précéder d'un @) autorise l’insertion de retours à la ligne et de caractères spéciaux dans la chaîne, sans utiliser de séquences d’échappement.

        A savoir !
            La chaîne ne peut pas être indentée
    */
    public void Verbatim()
    {
        string texte = @"Dans une chaîne verbatim :
- les retours à la ligne sont bien interprétés
- pas besoin d'échapper les caractères spéciaux (ex : C:\Temp\essai.txt)
- mais il faut ""doubler"" les guillemets";

        Console.WriteLine(texte);
    }

    // Les chaînes littéraux on les même avantage que les chaîne Verbatim mais sans leur inconvénients, mais elle sont dispo que depuis C#
    public void StringLiterals()
    {
        string texte = """
      Dans un littéral de chaîne brut :
      - pas besoin d'échapper les caractères spéciaux, y compris les "guillemets"
      - on peut indenter la chaîne comme le reste du code
      """;

        Console.WriteLine(texte);
    }

    public void Unicode()
    {
        Console.OutputEncoding = new UnicodeEncoding(); // A utilisé si le terminal n'affiche pas correctement les caractères unicode

        string symboles = "🖫 🖉 🗑 ✓ 🛈 🗙 ⭮ ⭯";
        string flèches = "⏶ ⏷ ⏴ ⏵";

        Console.WriteLine(symboles);
        Console.WriteLine(flèches);
    }
}
