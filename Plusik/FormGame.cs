using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plusik
{
    public partial class FormGame : Form
    {
        int userNumber = 1, targetNumber = 15, steps = 0;
        Random rnd = new Random();

        int CountSteps(int x)
        {
            int stepsLoc = 0;
            while (x > 1)
            {
                if (x % 2 == 0) x = x / 2;
                else x = x - 1;
                stepsLoc++;
            }
            return stepsLoc;
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void buttonPLus_Click(object sender, EventArgs e)
        {
            userNumber += 1;
            steps += 1;
            if (userNumber > targetNumber)
            {
                MessageBox.Show("Проиграл!");
                userNumber = 1;
                targetNumber = rnd.Next(10, 100);
            }
            else
                if (userNumber == targetNumber)
                    if (steps == CountSteps(targetNumber))
                        MessageBox.Show("ВЫИГРАЛ!");
                    else
                        MessageBox.Show("Можно быстрее!");
            labelUser.Text = userNumber.ToString();
            labelTarget.Text = targetNumber.ToString();
            labelSteps.Text = steps.ToString();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            userNumber *= 2;
            steps += 1;
            if (userNumber > targetNumber)
            {
                MessageBox.Show("Проиграл!");
                userNumber = 1;
                targetNumber = rnd.Next(10, 100);
            }
            else
                if (userNumber == targetNumber)
                MessageBox.Show("ВЫИГРАЛ!");
            labelUser.Text = userNumber.ToString();
            labelTarget.Text = targetNumber.ToString();
            labelSteps.Text = steps.ToString();
        
    }
    }
}
