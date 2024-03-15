namespace TPMoyennes
{
    internal class Eleve
    {
        public string prenom { get; set; }
        public string nom { get; set; }
        public List<Note> notes { get; set; }

        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
            notes = new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            if (notes.Count < 200)
            {
                notes.Add(note);
            }
        }

        public float MoyenneMatiere(int matiere)
        {
            float total = 0;
            int count = 0;
            foreach (var n in notes)
            {
                if (n.matiere == matiere)
                {
                    total += n.note;
                    count++;
                }
            }
            return count > 0 ? total / count : 0;
        }

        public float MoyenneGeneral()
        {
            float total = 0;
            foreach (var n in notes)
            {
                total += n.note;
            }
            return notes.Count > 0 ? total / notes.Count : 0;
        }

    }
}
