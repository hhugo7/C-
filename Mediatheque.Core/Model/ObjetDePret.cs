using System;

namespace Mediatheque.Core.Model
{
    public class ObjetDePret
    {
        private string v;

        public string TitreDeLObjet { get; }
        public string Emprunteur { get; private set; }

        public ObjetDePret(string titreDeLObjet, string emprunteur )
        {
            TitreDeLObjet = titreDeLObjet;
            Emprunteur = emprunteur;
        }

        public ObjetDePret(string v)
        {
            this.v = v;
        }

        public bool Emprunte(string emprunteur)
        {
            if (Emprunteur != null)
            {
                return false;
            }
            Emprunteur = emprunteur;
            return true;
        }

        public bool EstDisponible()
        {
            return Emprunteur == null;
        }
    }
}
