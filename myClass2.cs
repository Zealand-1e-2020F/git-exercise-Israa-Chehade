namespace GitExercise
{
    class myClass2
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }
        public string By { get; set;}

        public myClass2(string navn, string adresse, int postnummer, string by)
        {
            Navn = navn;
            Adresse = adresse;
            Postnummer = postnummer;
            By = by;
        }
        public override string ToString()
        {
            return "Navnet er " + Navn + " adressen er " + Adresse + " postnr er " + Postnummer + " byen er " + By;
        }

        


    }
}