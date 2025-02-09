namespace Bases;

// On peut créer une documentation a partir de commentaire en XML (équivalent de la JS-Doc)
public class Commentaire
{
    /// <summary>
    /// Renvoie le nombre de mot dans une phrase donnée
    /// </summary>
    /// <param name="sentence">Une chaine de caractère</param>
    /// <returns>Nombre de mot</returns>
    public static int CountWords(string sentence)
    {
        // Commentaire simple
        string[] words = sentence.Split(' ');

        /*
            Commentaire
            multiligne
            ...
        */
        return words.Length;
    }
}
