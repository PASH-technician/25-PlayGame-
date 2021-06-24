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
    public partial class game_frame : Form
    {

        private int timerCounter1 = 0;
        private int timerCounter2 = 0;
        private int timerCounter3 = 0;

        private int timerEnd1 = 0;
        private int timerEnd2 = 0;
        private int timerEnd3 = 0;

        private Random rand = new Random();
        public game_frame()
        {
            InitializeComponent();

            this.triangle.Visible = false;
            this.counter_triangle.Visible = false;

            this.hexagon.Visible = false;
            this.counter_hexagon.Visible = false;

            this.square.Visible = false;
            this.counter_square.Visible = false;
        }

        private void create_square()
        {
            this.square.Visible = true;
            this.counter_square.Visible = true;
            
            int figureX = rand.Next(0, this.Width - this.square.Width);
            int figureY = rand.Next(0, this.Height - this.square.Height);

            this.square_group.Location = new Point(Math.Abs(figureX), Math.Abs(figureY));
            
            timerEnd1 = rand.Next(2, 5);
            this.counter_square.Text = timerEnd1.ToString();

            this.timerSquare.Enabled = true;
            this.timerSquare.Start();
        }

        private void create_triangle()
        {
            this.triangle.Visible = true;
            this.counter_triangle.Visible = true;
            int figureX = rand.Next(0, this.Width - this.triangle.Width);
            int figureY = rand.Next(0, this.Height - this.triangle.Height);

            this.triangle_group.Location = new Point(Math.Abs(figureX), Math.Abs(figureY));
            
            timerEnd2 = rand.Next(2, 5);
            this.counter_triangle.Text = timerEnd2.ToString();

            this.timerTriangle.Enabled = true;
            this.timerTriangle.Start();
        }

        private void create_hexagon()
        {
            this.hexagon.Visible = true;
            this.counter_hexagon.Visible = true;
            
            int figureX = rand.Next(0, this.Width - this.hexagon.Width);
            int figureY = rand.Next(0, this.Height - this.hexagon.Height);

            this.hexagon_group.Location = new Point(Math.Abs(figureX), Math.Abs(figureY));
            
            timerEnd3 = rand.Next(2, 5);
            this.counter_hexagon.Text = timerEnd3.ToString();

            this.timerHexagon.Enabled = true;
            this.timerHexagon.Start();
        }

        private void create_random_figure()
        {
            switch (rand.Next(1, 3))
            {
                case 1:
                    create_square();
                    break;
                case 2:
                    create_triangle();
                    break;
                case 3:
                    create_hexagon();
                    break;
            }
        }

        private void game_frame_Load(object sender, EventArgs e)
        {
            create_random_figure();
        }

        private void square_Click(object sender, EventArgs e)
        {
            timerSquare.Stop();
            this.square.Visible = false;
            this.counter_square.Visible = false;
            int time = timerEnd1 - timerCounter1;
            timerCounter1 = 0;
            counter_score.Text = (Convert.ToSingle(counter_score.Text) + time).ToString();
            create_random_figure();
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            timerTriangle.Stop();
            this.triangle.Visible = false;
            this.counter_triangle.Visible = false;
            int time = timerEnd2 - timerCounter2;
            timerCounter2 = 0;
            counter_score.Text = (Convert.ToSingle(counter_score.Text) + time).ToString();
            create_random_figure();
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            timerHexagon.Stop();
            this.hexagon.Visible = false;
            this.counter_hexagon.Visible = false;
            int time = timerEnd3 - timerCounter3;
            timerCounter3 = 0;
            counter_score.Text = (Convert.ToSingle(counter_score.Text) + time).ToString();
            create_random_figure();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter1 += 1;
            counter_square.Text = (timerEnd1 - timerCounter1).ToString();
            if(timerCounter1 == timerEnd1)
            {
                this.Hide();
                MessageBox.Show("Игра окончена!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerCounter2 += 1;
            counter_triangle.Text = (timerEnd2 - timerCounter2).ToString();
            if (timerCounter2 == timerEnd2)
            {
                this.Hide();
                MessageBox.Show("Игра окончена!");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timerCounter3 += 1;
            counter_hexagon.Text = (timerEnd3 - timerCounter3).ToString();
            if (timerCounter3 == timerEnd3)
            {
                this.Hide();
                MessageBox.Show("Игра окончена!");
            }
        }
    }
}
