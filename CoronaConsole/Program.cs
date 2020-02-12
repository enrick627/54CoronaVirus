//Enrick De Munter nr3 5ITN 11/02/2020
/* opgave
 * ======
 * zie blad taak
 * ANALYSE
 * =======
 * BEREKEN  beginDatum(=16/01/2020)
 * BEREKEN  aantalBesmettingen (=45)
 * VRAAG    eindDatum
 * BEREKEN  overzicht:
 *      BEREKEN     overzicht(=lege lijst)
 *      HERHAAL datum van beginDatum t/m eindDatum IN STAPPEN VAN 1 dag
 *          BEREKEN aangroei (berekeningAangroei: aantalBesmettingen)
 *          BEREKEN aantalBesmettingen (= aantalBesmettingen + aangroei)
 *          BEREKEN overzichtslijn (=(datum):( aantalbesmettingen)*(aangroei))
 *          VOEG    overzichtslijn TOE AAN overzicht
 *      EINDE HERHALING
 *      BEREKEN overzicht (=omgekeerd sorteren)
 * TOON     overzicht
 * 
 * BerekenAangroei:
 * ----------------
 *  BEREKEN     aantalBesmettingen (=via parameter)
 *  BEREKEN     aangroei (=aantalBesmettingen * 48%)
 *  RETURN      aangroei
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIES
            DateTime beginDatum, eindDatum;
            ulong aantalBesmettingen, aangroei;
            List<string> overzicht = new List<string>();
            string overzichtLijn;
            // VRAAG    eindDatum
            Console.WriteLine("geef een datum:");
            eindDatum = DateTime.Parse(Console.ReadLine());
            // BEREKEN  beginDatum(=16/01/2020)
            beginDatum = new DateTime(2020, 1, 16);// alternatief begindatum = datetime.pars("16/1/2020")
            // BEREKEN  aantalBesmettingen (=45)
            aantalBesmettingen = 45;
            // BEREKEN  overzicht:
            //      BEREKEN     overzicht(=lege lijst)
            //      HERHAAL datum van beginDatum t/m eindDatum IN STAPPEN VAN 1 dag
            for (DateTime datum = beginDatum; datum <= eindDatum; datum = datum.AddDays(1))
            {
                //          BEREKEN aangroei (berekeningAangroei: aantalBesmettingen)
                aangroei = BerekenAangroei(aantalBesmettingen);
                //          BEREKEN overzichtslijn (=(datum):( aantalbesmettingen)*(aangroei))
                overzichtLijn = $"{datum.ToString("YYYY-MM-DD")}: {aantalBesmettingen} * {aangroei}";
                //          BEREKEN aantalBesmettingen (= aantalBesmettingen + aangroei)
                aantalBesmettingen += aangroei;

                //          VOEG    overzichtslijn TOE AAN overzicht
                overzicht.Add(overzichtLijn);
                //      EINDE HERHALING
            }

            //      BEREKEN overzicht (=omgekeerd sorteren)
            // TOON     overzicht
            overzicht.Reverse();
            
            foreach (var item in overzicht)
            {
                Console.WriteLine(item);
            }


            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten!");
            Console.ReadKey();
        }
        public static ulong BerekenAangroei(ulong aantalBesmetting)
        {
            // BerekenAangroei:
            // ----------------
            //  BEREKEN     aantalBesmettingen (=via parameter)
            //  BEREKEN     aangroei (=aantalBesmettingen * 48%)
            ulong aangroei = (ulong)(aantalBesmetting * 0.48);
            //  RETURN      aangroei
            return aangroei;
            
        }
        

        
    }
}
