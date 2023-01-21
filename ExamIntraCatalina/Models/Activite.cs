namespace ExamIntraCatalina.Models
{
    public class Activite
    {

        public Activite()
        {
        }

        public Activite(string nom, int duree, double prix, int vote)
        {
            this.Nom = nom;
            this.Duree = duree;
            this.Prix = prix;
            this.Vote = vote;
        }



        public string Nom { get; set; }
        public int Duree { get; set; }
        public double Prix { get; set; }
        public int Vote { get; set; }

    }
}
