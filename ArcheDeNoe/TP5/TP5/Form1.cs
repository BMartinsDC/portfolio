using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        ArcheNoe Arche = new ArcheNoe();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4)
            {
                archenum1.Text = Arche.nbrAnimaux().ToString();
                archenum2.Text = Arche.nbrOiseaux().ToString();
                archenum3.Text = Arche.nbrChats().ToString();
            }
        }

        private void animalbutton_Click(object sender, EventArgs e)
        {
            Animal monAnimal = new Animal(Convert.ToInt32(animaltext2.Text), animaltext1.Text);
            Arche.getLesAnimaux().Add(monAnimal);
            MessageBox.Show(monAnimal.manger() + '\n' + monAnimal.dormir());
        }

        private void oiseaubutton_Click(object sender, EventArgs e)
        {
            Oiseau monOiseau = new Oiseau(oiseautext1.Text, 2, "Oiseau");
            Arche.getLesAnimaux().Add(monOiseau);
            MessageBox.Show(monOiseau.manger() + '\n' + monOiseau.dormir());
        }

        private void felinbutton_Click(object sender, EventArgs e)
        {
            Felin monFelin = new Felin(4, felintext1.Text);
            Arche.getLesAnimaux().Add(monFelin);
        }

        private void chatbutton_Click(object sender, EventArgs e)
        {
            Chat monChat = new Chat(4, "Chat", chattext1.Text);
            Arche.getLesAnimaux().Add(monChat);
            MessageBox.Show(monChat.getNom() + '\n' + monChat.manger() + '\n' + monChat.dormir());
        }
    }
}