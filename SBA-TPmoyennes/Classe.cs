using TPMoyennes;

class Classe
{
    public string nomClasse { get; private set; }
    public List<Eleve> eleves { get; private set; }
    public List<string> matieres { get; private set; }

    public Classe(string nomClasse)
    {
        this.nomClasse = nomClasse;
        eleves = new List<Eleve>();
        matieres = new List<string>();
    }

    public void ajouterEleve(string prenom, string nom)
    {
        if (eleves.Count < 30)
        {
            eleves.Add(new Eleve(prenom, nom));

        }
    }

    public void ajouterMatiere(string matiere)
    {
        if (matieres.Count < 10)
        {
            matieres.Add(matiere);

        }
    }

    public float MoyenneMatiere(int matiere)
    {
        float total = 0;
        int count = 0;
        foreach (var eleve in eleves)
        {
            total += eleve.MoyenneMatiere(matiere);
            count++;
        }
        return count > 0 ? total / count : 0;
    }

    public float MoyenneGeneral()
    {
        float total = 0;
        foreach (var eleve in eleves)
        {
            total += eleve.MoyenneGeneral();
        }
        return eleves.Count > 0 ? total / eleves.Count : 0;
    }
}