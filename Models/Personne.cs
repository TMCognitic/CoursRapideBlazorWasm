namespace CoursRapideBlazorWasm.Models
{
    public class Personne
    {
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
