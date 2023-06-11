using System;

namespace Recruting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*(eintrag.StdProWoche < 25 ? "green" 
             * : eintrag.StdProWoche <35 ? "yellow" 
             * : "red")">
                @(eintrag.StdProWoche?.ToString())*/
            for (int i = 1; i <= 108; i++)
            {
                Console.WriteLine((i % 5 == 0 && i % 3 == 0 && i % 7 == 0) ? "BimBamBum":(i % 5 == 0 && i % 3 == 0) ? "BimBam" : (i % 7 == 0 && i % 3 == 0) ? "BimBum" : (i % 5 == 0 && i % 7 == 0) ? "BamBum" : (i%3==0) ? "Bim" : (i % 7 == 0) ? "Bum" : (i%5==0) ? "Bam"  : i);
            }
            Console.ReadKey();

            /*Variante 3 – Zisch
In dieser Variante kommt eine weitere Teilbarkeitsregel hinzu: Zahlen die durch 11 teilbar sind, werden mit „Zisch“ ersetzt – Zahlen die durch 11 und weitere Zahlen teilbar sind, enthalten dann dementsprechend das Wort „Zisch“ (und das Wort/die Wörter der anderen Zahlen, also bei 3 „Bim“, bei 5 „Bam“, bei 7 „Bum“)
Beispielausgabe (Ausschnitt):
…
1147
Bum
Bim
Bam
1151
Bim
1153
1154
BimBamBumZisch
1156
1157
…
Hinweis: Falls man merkt, dass das Schreiben dieses Zusatzes sehr aufwändig wird, ist es vielleicht Zeit, seinen ursprünglichen Ansatz zu überdenken und einen effizienteren zu finden.*/

        }
    }
}
