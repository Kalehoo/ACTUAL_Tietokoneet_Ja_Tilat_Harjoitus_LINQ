using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTUAL_Tietokoneet_Ja_Tilat_Harjoitus_LINQ
{
    public class Tilat
    {
        //TilaID,Nimi,Sijainti,Huonenro,Koneet

        [CsvColumn(Name = "TilaID", FieldIndex = 1)]
        public int TilaID { get; set; }

        [CsvColumn(Name = "Nimi", FieldIndex = 1)]
        public string Nimi { get; set; }

        [CsvColumn(Name = "Sijainti", FieldIndex = 1)]
        public string Sijainti { get; set; }

        [CsvColumn(Name = "Huonenro", FieldIndex = 1)]
        public string Huonenro { get; set; }

        [CsvColumn(Name = "Koneet", FieldIndex = 1)]
        public string[] Koneet { get; set; }


    }
}
