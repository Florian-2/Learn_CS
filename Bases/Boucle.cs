namespace Bases;

public class Boucle
{
    static readonly string[] people = { "John", "Florian", "David" };

    public Boucle()
    {
        LoopFor();
        LoopForEach();
        LoopWhile();
        LoopDoWhile();
    }

    private static void LoopFor()
    {

        /* Mots cléfs :

            - break : stop la boucle
            - continue : skip la suite du code et reffet une itération (il revient à la ligne => for (int i = 0; i < person.Length; i++))
        */
        for (int i = 0; i < people.Length; i++)
        {
            string p = people[i];

            if (p.Length > 6)
            {
                Console.WriteLine($"{p} ({p.Length} caractères)");
                Console.WriteLine($"Nombre d'itération effectué : {i}");
                break; // Stop la boucle
            }
        }
    }

    private static void LoopForEach()
    {

        foreach (string person in people)
        {
            Console.WriteLine(person);
        }
    }

    private static void LoopWhile()
    {
        // while
        byte num = 0;
        while (num < 5)
        {
            num++;
            // ...
        }
    }

    private static void LoopDoWhile()
    {
        /*
            Le code dans le bloc "do" est exécuter une première fois et ensuite on voit si la condition du "while" est bonne pour exécuter une nouvelle fois le bloc de code "do"
        */
        bool isOk = false;

        do
        {
            Console.Write("1 or 2 ? ");
            string? rep = Console.ReadLine();

            if (rep == "1" || rep == "2")
                isOk = true;

        } while (!isOk);
    }
}
