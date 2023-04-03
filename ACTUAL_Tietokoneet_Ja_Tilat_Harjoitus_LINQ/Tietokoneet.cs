using LINQtoCSV;
using System;

namespace ACTUAL_Tietokoneet_Ja_Tilat_Harjoitus_LINQ
{
    public class Tietokoneet
    {

        [CsvColumn(Name = "ID", FieldIndex = 1)]
        //Fieldindex = indeksi jos nimi on tyhjä
        // OutputFormat = "dd-MM-yyyy HH:mm tai esim C (currency) määrittää eri formaatin tyhjälle lokerolle" 
        // Nyt OutputFormat ei tarvita koska kyseessä on string
        public int TietokoneID { get; set; }

        [CsvColumn(Name = "Merkki", FieldIndex = 2)]
        public string Merkki { get; set; }

        [CsvColumn(Name = "Malli", FieldIndex = 3)]
        public string Malli { get; set; }

        [CsvColumn(Name = "Omistussuhde", FieldIndex = 4)]
        public string Omistussuhde { get; set; }

        [CsvColumn(Name = "Huone", FieldIndex = 5)]
        public int Huone { get; set; }


    }
}
