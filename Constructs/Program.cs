namespace Constructs
{


    // Her lager jeg en klasse som heter Hus. Dette er klassen som jeg lager en constructor i.
    public class Hus
    {

        public int byggeår;                 // Her lager jeg tre forskjellige fields/variabler som er de forskjellige egenskapene som
        public int kvadratMeter;            // klassen Hus har. Disse skal tilleges verdier senere, og det er disse man kaller på gjennom en dot-notation.
        public string farge;

        // Her lages selve constructoren. Constructoren må ha samme navn som classen den er i, altså "Hus". Dermed kommer det parametre som man fyller ut.
        // Her er parametrene buildYear, squareMeters, og color.
        public Hus (int buildYear, int squareMeters, string color)
        {
            byggeår = buildYear;                                    // Her initialiseres parametrene med de tre forskjellige fieldsene jeg lagde over.    
            kvadratMeter = squareMeters;                            // Fieldsene blir gitt samme verdi som parametrene, slik at man kan kalle på de lenger ned.
            farge = color;

        }
    }
    internal class Program              // Her starter program-klassen
    {
        static void Main(string[] args) // Main method
        {
            Hus bolig1 = new(1999, 200, "Green"); // Her skapes det et hus. Man starter med constructornavnet "Hus", og lager en instans av dette.
                                                  // I dette tilfellet heter instansen av Hus bolig1. Deretter initialiseres den med "= new(PARAMETERE).

            Console.WriteLine( bolig1.byggeår + " " + bolig1.kvadratMeter + " " + bolig1.farge); // For å printe til console må man plusse de forskjellige verdiene
                                                                                                 // sammen, evt bruke en $"{bolig1.byggeår}".
        }
    }
}