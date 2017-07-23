using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_damage_sim
{
    public partial class mainForm : Form
    {
        // Set up a combat timer and start running combat
        Timer combatTimer = new Timer();

        public mainForm()
        {
            InitializeComponent();

            combatTimer.Interval = 1000;
            combatTimer.Tick += new EventHandler(CombatTickEvent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HitpointBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void startCombat_Click(object sender, EventArgs e)
        {
            // Start combat
            // In case someone decides to copy in an invalid value for either base damage or the starting HP, revalidate the fields
            Validate();

            // Set up the progress bar area to show the right data based on our starting HP entry
            Int32.TryParse(startHp.Text, out int startingHp);
            Int32.TryParse(baseDamage.Text, out int startingBaseDamage);

            hpProgressBar.Maximum = startingHp;
            hpProgressBar.Value = startingHp;
            currentHpDisplay.Text = startingHp.ToString();

            combatTimer.Start();
           
        }

        private void startHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only interested in integer values for this field
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void baseDamage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only interested in integer values for this field
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void startHp_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(startHp.Text, out int startingHp))
            {
                MessageBox.Show("Starting HP input is invalid. Enter an integer");
                startHp.ResetText();
            }
        }
        private void baseDamage_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(baseDamage.Text, out int baseDamageInt))
            {
                MessageBox.Show("Base Damage input is invalid. Enter an integer");
                baseDamage.ResetText();
            }
        }
        private void CombatTickEvent(object sender, EventArgs e)
        {
            int currentHp = hpProgressBar.Value;
            Int32.TryParse(baseDamage.Text, out int baseDamageInt);

            // Apply damage on the tick
            hpProgressBar.Value = currentHp > baseDamageInt ? currentHp -= baseDamageInt : 0;

            // Update the help text at the same time
            currentHpDisplay.Text = hpProgressBar.Value.ToString();
            if(hpProgressBar.Value == 0)
            {
                combatTimer.Stop();
            }
            
        }
        private void validate_Int(object sender, CancelEventArgs e)
        {
            // Only interested in integer values for this field
            if (!Int32.TryParse(startHp.Text, out int startingHp))
            {
                MessageBox.Show("Start HP input is invalid. Enter an integer");
                startHp.ResetText();
            }
            if (!Int32.TryParse(baseDamage.Text, out int startingBaseDamage))
            {
                MessageBox.Show("Base Damage input is invalid. Enter an integer");
                baseDamage.ResetText();
            }
        }

        private void resetCombat_Click(object sender, EventArgs e)
        {
            Int32.TryParse(startHp.Text, out int startingHp);
            hpProgressBar.Value = startingHp;
            currentHpDisplay.Text = startHp.Text;
            combatTimer.Stop();
        }
    }
}
