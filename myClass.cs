namespace GitExercise
{
    class myClass
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }
        public myClass(string navn, string adresse, int postnummer)
        {
            Navn = navn;
            Adresse = adresse;
            Postnummer = postnummer;
        }
        public override string ToString()
        {
            return Navn + Adresse + Postnummer;
        }

    }
}