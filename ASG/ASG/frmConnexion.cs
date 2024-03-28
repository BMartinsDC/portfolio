namespace ASG
{
    public partial class frmConnexion : Form
    {
        Accueil monAccueil = new Accueil();
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //On récupère la saisie des identifiants.
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            string validLogin = "unLogin";
            string validPassword = "unPassword";
            if (login == validLogin && password == validPassword)
            {
                //On ouvre l'application
                this.Hide();
                var accueil = new Accueil();
                accueil.Closed += (s, args) => this.Close();
                accueil.Show();
            }
            else
            {
                MessageBox.Show("Les indentifiants de connexion sont incorrects.");
            }
        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }
    }
}