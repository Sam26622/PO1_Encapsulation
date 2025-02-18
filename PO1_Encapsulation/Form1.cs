namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;
        public Form1()
        {
            InitializeComponent();
            joueur = new Personnage();
            joueur.PointDeVie = 10;
            joueur.PuissanceDAttaque = 1;


            monstre = new Personnage();
            monstre.PointDeVie = 30;
            monstre.PuissanceDAttaque = 3;


            ActualiserAffichage();


        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.PuissanceDAttaque;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceDAttaque;


            ActualiserAffichage();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceDAttaque;


            ActualiserAffichage();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PuissanceDAttaque += 4;
            joueur.PuissanceDAttaque = joueur.PuissanceDAttaque - 
        }
        private void ActualiserAffichage()
        {
            lbl_pointsVieJoueur.Text = "Points de vie : " + joueur.PointDeVie;
            lbl_pointsVieDragon.Text = "Points de vie : " + monstre.PointDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque : " + joueur.PuissanceDAttaque;
            lbl_puissanceAttaqueDragon.Text = "Puissance d'attaque : " + monstre.PuissanceDAttaque;
        }
       
    }
}