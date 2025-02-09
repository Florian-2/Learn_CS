namespace Bases;

public class Tableau
{
    public Tableau()
    {
        /* Les Tableaux

            Les tableau en C# ne sont pas l'équivalent des tableau en Javascript, ici la taille du tableau est définie à l'initialisation ne peut pas être modifié et la syntaxe est différente.

            Pour avoir quelque chose de similaire au tableau en JS, il faut allez voir du côté des List ou Collection.
        */

        // Tableau (nullable) de petit nombre
        byte?[] notes = new byte?[5];
        notes[0] = 12;
        notes[1] = 6;

        foreach (var num in notes)
        {
            if (num != null) // x3 null
            {
                Console.WriteLine(num);
            }
        }

        // Tableau de string
        string[] children = new string[3];

        foreach (var child in children)
            Console.WriteLine(child == null ? "null" : child);

        Console.WriteLine($"il y a {children.Length} enfants");

        // Tableau de string avec des valeurs prédéfinie
        string[] person = { "Florian", "John", "David" };
        Console.WriteLine(person[1]);
    }

    public static void Tuple()
    {
        (string firstname, string lastname) user = ("John", "Doe");
        Console.WriteLine(user.firstname); // John

        // Nouvelle syntaxe
        (string firstname, string lastname) = ("John", "Doe");
        Console.WriteLine(firstname); // John
    }
}
