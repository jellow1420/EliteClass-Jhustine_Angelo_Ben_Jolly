using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteClass
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlayer1.Items.AddRange(new string[] { "Debugger Dana", "QuizMaster Quincy" });
            cmbPlayer2.Items.AddRange(new string[] { "Debugger Dana", "QuizMaster Quincy" });
        }

        private async void btnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                string name1 = Player1.Text;
                string name2 = Player2.Text;
                string type1 = cmbPlayer1.SelectedItem?.ToString();
                string type2 = cmbPlayer2.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(name1) || string.IsNullOrWhiteSpace(name2))
                    throw new Exception("Please enter both player names.");
                if (type1 == null || type2 == null)
                    throw new Exception("Please select character types for both players.");

                StudentHero player1 = CreateCharacter(type1, name1);
                StudentHero player2 = CreateCharacter(type2, name2);

                BattleLog.Items.Clear();

                // Initial full width of health bars (set this based on your Panel size)
                int fullWidth = 200;

                while (player1.Health > 0 && player2.Health > 0)
                {
                    // Player 1 attacks
                    int damage1 = player1.Attack();
                    player2.TakeDamage(damage1);
                    BattleLog.Items.Add($"{player1.Name} attacks for {damage1} damage.");
                    lblPlayer2Health.Text = $"Health: {player2.Health}";
                    lblPlayer2HP.Text = $"HP: {player2.Health} / {player2.MaxHealth}";
                    BattleLog.Items.Add($"{player1.Name} attacks for {damage1} damage.");
                    lblPlayer2Health.Text = $"Health: {player2.Health}";

                    // Flash red effect on Player 2
                    panelPlayer2Body.BackColor = Color.Orange;
                    await Task.Delay(1000);
                    panelPlayer2Body.BackColor = Color.Red; // Change this to original color

                    // Shrink Player 2's health bar
                    panelPlayer2Health.Width = (player2.Health * fullWidth) / player2.MaxHealth;

                    if (player2.Health <= 0) break;

                    // Player 2 attacks
                    int damage2 = player2.Attack();
                    player1.TakeDamage(damage2);
                    BattleLog.Items.Add($"{player2.Name} attacks for {damage2} damage.");
                    lblPlayer1Health.Text = $"Health: {player1.Health}";
                    lblPlayer1HP.Text = $"HP: {player1.Health} / {player1.MaxHealth}";
                    BattleLog.Items.Add($"{player2.Name} attacks for {damage2} damage.");
                    lblPlayer1Health.Text = $"Health: {player1.Health}";

                    // Flash red effect on Player 1
                    panelPlayer1Body.BackColor = Color.Orange;
                    await Task.Delay(1000);
                    panelPlayer1Body.BackColor = Color.Red; // Change this to original color

                    // Shrink Player 1's health bar
                    panelPlayer1Health.Width = (player1.Health * fullWidth) / player1.MaxHealth;
                }

                string winner = player1.Health > 0 ? player1.Name : player2.Name;
                lblWinner.Text = $"Winner: {winner}";
                MessageBox.Show($"{winner} wins the battle!", "Battle Over");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private StudentHero CreateCharacter(string type, string name)
        {
            switch (type)
            {
                case "Debugger Dana":
                    return new DebuggerDana(name);
                case "QuizMaster Quincy":
                    return new QuizMasterQuincy(name);
                default:
                    throw new Exception("Invalid character type.");
            }
        }

        private void BattleLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelPlayer2Health_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Player1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Health_Click(object sender, EventArgs e)
        {

        }
    }
}
