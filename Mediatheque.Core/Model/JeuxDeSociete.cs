using System; // Nécessaire pour Enum

namespace Mediatheque.Core.Model
{
    public class JeuxDeSociete : ObjetDePret
    {
        // Propriétés publiques
        public int AgeMinimum { get; private set; }
        public int AgeMaximum { get; private set; }
        public string Editeur { get; private set; }
        public TypeJeuxDeSociete TypeJeux { get; private set; }

        // Constructeur
        public JeuxDeSociete(string titreDeLObjet, int ageMini, int ageMaxi, string editeur, TypeJeuxDeSociete type) : base(titreDeLObjet)
        {
            AgeMinimum = ageMini;
            AgeMaximum = ageMaxi;
            Editeur = editeur;
            TypeJeux = type;
        }
    }

}
