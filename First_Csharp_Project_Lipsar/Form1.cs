namespace First_Csharp_Project_Lipsar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes) this.Close();
            else return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This is Clicker-game. You're welcome!", "Game Load", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                Form newForm = new Form2();
                newForm.ShowDialog();
            }
        }
    }
}