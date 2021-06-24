using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25__игра_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void start_game_Click(object sender, EventArgs e)
        {
            game_frame frame = new game_frame();
            frame.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
