namespace Bases;

public class Condition
{
    public Condition()
    {
        ConditionIf();
        ConditionSwitchCase();
    }

    private static void ConditionIf()
    {
        bool isAdmin = false;

        if (isAdmin)
        {
            Console.WriteLine("Chargenment des ressources...");
        }
        else
        {
            Console.WriteLine("Vous n'avez pas accès a cette ressource.");
        }
    }

    private static void ConditionSwitchCase()
    {
        Console.WriteLine("Y or N ? ");
        string? answer = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(answer)) return;

        switch (answer.ToLower())
        {
            case "y":
                Console.WriteLine("Lancement du téléchargement...");
                break;

            case "n":
                Console.WriteLine("Annualtion en cours...");
                break;

            default:
                break;
        }
    }
}
