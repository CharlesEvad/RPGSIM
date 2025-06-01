using System;
using System.Windows.Forms;
using System.Drawing;

namespace RPGSIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStartBattle.Click += btnStartBattle_Click;
            this.Load += Form1_Load;

            cbCharacter1.SelectedIndexChanged += cbCharacter1_SelectedIndexChanged;
            cbCharacter2.SelectedIndexChanged += cbCharacter2_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCharacter1.Items.Clear();
            cbCharacter2.Items.Clear();

            cbCharacter1.Items.Add("Charles_Fighter");
            cbCharacter1.Items.Add("Jansean_Marksman");
            cbCharacter1.Items.Add("JessieLou_Assassin");
            cbCharacter1.Items.Add("Dex_Wizard");

            cbCharacter2.Items.Add("Charles_Fighter");
            cbCharacter2.Items.Add("Jansean_Marksman");
            cbCharacter2.Items.Add("JessieLou_Assassin");
            cbCharacter2.Items.Add("Dex_Wizard");

            cbCharacter1.SelectedIndex = 0;
            cbCharacter2.SelectedIndex = 1;

            lblHealth1.Text = $"{txtPlayer1.Text} Health: 0/0";
            lblHealth2.Text = $"{txtPlayer2.Text} Health: 0/0";
            lblWinner.Text = "";

            this.BackColor = Color.FromArgb(30, 30, 30);
            groupBox1.BackColor = Color.FromArgb(45, 45, 48);

            lblPlayer1.ForeColor = Color.White;
            lblPlayer2.ForeColor = Color.White;
            lblCharacter1.ForeColor = Color.White;
            lblCharacter2.ForeColor = Color.White;
            lblHealth1.ForeColor = Color.LightGreen;
            lblHealth2.ForeColor = Color.LightGreen;
            lblWinner.ForeColor = Color.Gold;

            btnStartBattle.BackColor = Color.FromArgb(60, 60, 60);
            btnStartBattle.ForeColor = Color.White;
            btnStartBattle.FlatStyle = FlatStyle.Flat;
            btnStartBattle.FlatAppearance.BorderColor = Color.DimGray;

            txtPlayer1.BackColor = Color.FromArgb(50, 50, 50);
            txtPlayer1.ForeColor = Color.White;
            txtPlayer2.BackColor = Color.FromArgb(50, 50, 50);
            txtPlayer2.ForeColor = Color.White;

            cbCharacter1.BackColor = Color.FromArgb(50, 50, 50);
            cbCharacter1.ForeColor = Color.White;
            cbCharacter2.BackColor = Color.FromArgb(50, 50, 50);
            cbCharacter2.ForeColor = Color.White;

            lstBattleLog.BackColor = Color.FromArgb(40, 40, 40);
            lstBattleLog.ForeColor = Color.White;

            pictureBox1.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox2.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                string name1 = txtPlayer1.Text.Trim();
                string name2 = txtPlayer2.Text.Trim();
                string char1 = cbCharacter1.SelectedItem?.ToString();
                string char2 = cbCharacter2.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2))
                    throw new Exception("Both players need names to start the battle.");
                if (string.IsNullOrEmpty(char1) || string.IsNullOrEmpty(char2))
                    throw new Exception("Please select a character for both players.");

                Character player1 = CreateCharacter(char1, name1);
                Character player2 = CreateCharacter(char2, name2);

                lstBattleLog.Items.Clear();
                lblWinner.Text = "";

                Random rng = new Random();
                bool player1Turn = rng.Next(2) == 0;

                while (player1.Health > 0 && player2.Health > 0)
                {
                    if (player1Turn)
                    {
                        int damage = player1.Attack(player2);
                        player2.TakeDamage(damage);
                        lstBattleLog.Items.Add($"{player1.Name} strikes {player2.Name} delivers {damage} damage!");
                    }
                    else
                    {
                        int damage = player2.Attack(player1);
                        player1.TakeDamage(damage);
                        lstBattleLog.Items.Add($"{player2.Name} attacks {player1.Name} inflicts {damage} damage!");
                    }

                    lblHealth1.Text = $"{player1.Name} Health: {player1.Health}/{player1.MaxHealth}";
                    lblHealth2.Text = $"{player2.Name} Health: {player2.Health}/{player2.MaxHealth}";

                    player1Turn = !player1Turn;

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(500);
                }

                string winner = player1.Health > 0 ? player1.Name : player2.Name;
                lblWinner.Text = $"Winner: {winner}!";
                MessageBox.Show($"{winner} is victorious!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCharacter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacter1.SelectedItem != null)
            {
                lblHealth1.Text = "Health: " + GetCharacterHealth(cbCharacter1.SelectedItem.ToString());
                UpdateCharacterImage(pictureBox1, cbCharacter1.SelectedItem.ToString());
            }
        }

        private int GetCharacterHealth(string characterName)
        {
            Character character = CreateCharacter(characterName, "Temp");
            return character.Health;
        }

        private void cbCharacter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacter2.SelectedItem != null)
            {
                lblHealth2.Text = "Health: " + GetCharacterHealth(cbCharacter2.SelectedItem.ToString());
                UpdateCharacterImage(pictureBox2, cbCharacter2.SelectedItem.ToString());
            }
        }

        private Character CreateCharacter(string characterType, string playerName)
        {
            switch (characterType)
            {
                case "Charles_Fighter":
                    return new Charles_Fighter(playerName);
                case "Jansean_Marksman":
                    return new Jansean_Marksman(playerName);
                case "JessieLou_Assassin":
                    return new JessieLou_Assassin(playerName);
                case "Dex_Wizard":
                    return new Dex_Wizard(playerName);
                default:
                    throw new Exception("Unknown character selected.");
            }
        }

        private void UpdateCharacterImage(PictureBox pictureBox, string characterName)
        {
            try
            {
                string gifPath = "images/" + characterName + ".gif";
                string imagePath = null;

                if (System.IO.File.Exists(gifPath))
                {
                    imagePath = gifPath;
                }

                if (imagePath != null)
                {
                    if (pictureBox.Image != null)
                    {
                        var oldImage = pictureBox.Image;
                        pictureBox.Image = null;
                        oldImage.Dispose();
                    }
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading character image: " + ex.Message);
            }
        }

        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }
    }
}