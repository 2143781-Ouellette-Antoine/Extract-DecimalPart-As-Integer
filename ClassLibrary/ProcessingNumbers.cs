namespace ClassLibrary
{
    public class ProcessingNumbers
    {
        public static int TrouverNbrMaxDigits(decimal[] tableau)//Le maximum de digits apres la virgule
        {
            int nbrMax = NombreDigits(tableau[0]);
            for (int currentIndex = 1; currentIndex <= tableau.Length - 1; currentIndex++)
            {
                int currentNombreDigits = NombreDigits(tableau[currentIndex]);
                if (currentNombreDigits > nbrMax)
                {
                    nbrMax = currentNombreDigits;
                }
            }

            return nbrMax;
        }

        public static int NombreDigits(decimal numero)//Nombre de digits dans la partie decimale
        {
            int count = 0;
            //0.125
            while (numero - Decimal.Truncate(numero) != 0)
            {
                numero *= 10;
                count++;
            }

            return count;
        }

        public static int TransformerEnInt(decimal numero, int maxDigits)
        {
            //Tronquer partie entiere
            decimal partieDecimale = numero - (int)Math.Truncate(numero);
            //Shifter les chiffres a gauche de la virgule, pour un longueur de maxDigits.
            return (int)(partieDecimale * (decimal)Math.Pow(10, maxDigits));
        }
    }
}