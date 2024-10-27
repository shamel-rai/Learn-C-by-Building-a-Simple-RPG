using Engine;


namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player player;
        public SuperAdventure()
        {
            InitializeComponent();
            Location location = new Location(1, "Home", "This is a safe place for the player");

            player = new Player(10, 10, 30, 0, 1);



            lblHitPoint.Text = player.CurrentHitPoints.ToString();
            lblGold.Text = player.Gold.ToString();
            lblExperience.Text = player.ExperiencePoints.ToString();
            lblLevel.Text = player.Level.ToString();

        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }
    }
}
