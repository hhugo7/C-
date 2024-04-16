namespace Mediatheque.Core.Model
{

    public class CD : ObjetDePret
    {
        public string Groupe { get; set; }
        public string Titre { get; set; }

        public CD(string titre, string groupe) : base(titre)
        {
            Titre = titre;
            Groupe = groupe;
        }

    }
}
