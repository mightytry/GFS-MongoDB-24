using PictureToPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFS_MongoDB
{
    public partial class Form1 : Form
    {
        Config config;

        public Form1()
        {
            InitializeComponent();
            config = new Config();
            Load();
        }
        private void Load()
        {
            SetAufgabe(config.Data.Aufgabe, config.Data.Hint);
            if (config.Data.Hint)
            {
                HintLB.Text = Aufgaben.Aufgabens[config.Data.Aufgabe].Hint;
            }
            HintTriesLB.Text = config.Data.Hints.ToString();
            TriesLB.Text = config.Data.WrongCount.ToString();
        }

        public void SetAufgabe(int aufgabe, bool hint)
        {
            config.Data.Aufgabe = aufgabe;
            config.Data.Hint = hint;
            config.Save();
            DescriptionLB.Text = Aufgaben.Aufgabens[aufgabe].Description;
            WantedLB.Text = Aufgaben.Aufgabens[aufgabe].WantedSolutionInput;
            CurrentLB.Text = $"{aufgabe+1}/{Aufgaben.Aufgabens.Length}";
        }

        private void TryBT_Click(object sender, EventArgs e)
        {
            if (Aufgaben.Aufgabens[config.Data.Aufgabe].CheckSolution(InputLB.Text))
            {
                if (config.Data.Aufgabe == Aufgaben.Aufgabens.Length - 1)
                {
                    MessageBox.Show("Du hast alle Aufgaben gelöst!");
                    return;
                }
                config.Data.Aufgabe++;
                config.Save();
                SetAufgabe(config.Data.Aufgabe, false);
                InputLB.Text = "";
            }
            else
            {
                config.Data.WrongCount++;
                config.Save();
                TriesLB.Text = config.Data.WrongCount.ToString();
            }
        }

        private void HintBT_Click(object sender, EventArgs e)
        {
            if (!config.Data.Hint)
            {
                HintLB.Text = Aufgaben.Aufgabens[config.Data.Aufgabe].Hint;
                config.Data.Hint = true;
                config.Data.Hints++;
                HintTriesLB.Text = config.Data.Hints.ToString();
                config.Save();
            }
        }

        private void InputLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TryBT_Click(null, null);
            }
        }
    }
}
