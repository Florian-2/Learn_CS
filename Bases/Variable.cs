namespace Bases;

public class Variable
{
    public Variable()
    {

        /* ----- Type Primitifs C# ----- 

            Type signé / non signé, quand un type commence par "u" alors c'est un type non signé ce qui veut dire qu'il ne peut pas être négatif. 
        */

        int i = -3_000;
        uint i2 = 2_000;
        byte y = 3;
        short s = 3;
        long l = 3;
        double d1 = 0.012;
        double d2 = 1.2E-2;  // forme exponentielle

        bool isAdmin = false;

        // float f1 = 10.2;  // Erreur
        float f2 = 10.2f;
        float f3 = 3.1E2f;

        // decimal dc1 = 0.012;  // Erreur
        decimal dc2 = 0.012m;

        string str = "voiture";
        // char c1 = "z";  // Erreur
        char oneLetter = 'z'; // Correct

        Constante();
        Null();
        StringInterpretation();
    }

    public static void Constante()
    {
        // Les constantes ne change jamais de valeur.

        const string firstame = "Florian";
        Console.WriteLine($"Je suis {firstame}");
    }

    public static void Null()
    {
        string? answer = Console.ReadLine(); // Peut être null

        if (string.IsNullOrWhiteSpace(answer))
        {
            Console.WriteLine("Valeur null ou contient que des espaces blanc");
        }

        if (answer != null)
        {
            Console.WriteLine($"type de la valeur : {answer.GetType()}");
        }
    }

    public static void StringInterpretation()
    {

        /* Interprétation des chaînes

            Chaque type possède des méthodes comme "parse" pour converture une valeur donnée.
        */
        Console.WriteLine("Quelle est ton année de naissance ?");
        string? rep = Console.ReadLine();

        short yearOfBirth = short.Parse(rep ?? "");
        Console.WriteLine($"Vous avez {DateTime.Today.Year - yearOfBirth} ans");
    }
}
