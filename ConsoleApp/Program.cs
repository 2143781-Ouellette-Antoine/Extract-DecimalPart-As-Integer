using ClassLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        //Trouver nombre de digits apres la virgule d'un numero
        decimal numero1 = 2.125M;
        Console.WriteLine(ProcessingNumbers.NombreDigits(numero1));

        //Trouver le -nombre maximal de digits apres la virgule- d'un tableau
        decimal[] tableau = { 2.125M, 2.2M, 2.231M, 0.515M, 0.005M, 0.6M };
        int maxDigits = ProcessingNumbers.TrouverNbrMaxDigits(tableau);
        Console.WriteLine(maxDigits);

        //Extraire la partie decimale d'un nombre et
        //la Transformer en Entier(Int)
        decimal numero2 = 2.2M;
        Console.WriteLine(ProcessingNumbers.TransformerEnInt(numero2, maxDigits));
        //______________________
        //| Entiers | Decimaux |    0.125 => 125
        //|      2. | 125      |    0.125  x  10^3 = 125
        //|      0. | 005      |
        //|      2. | 200      |    numero *  10^{maxDigits} = PartieDecimaleEnInt
        //|_________|__________|    On deplace les decimaux a gauche de la virgule

        Console.ReadKey(true);
    }
}