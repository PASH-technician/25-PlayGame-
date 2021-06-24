
namespace _25__игра_
{
    partial class game_frame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSquare = new System.Windows.Forms.Timer(this.components);
            this.timerTriangle = new System.Windows.Forms.Timer(this.components);
            this.timerHexagon = new System.Windows.Forms.Timer(this.components);
            this.hexagon = new System.Windows.Forms.PictureBox();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            this.counter_square = new System.Windows.Forms.Label();
            this.counter_triangle = new System.Windows.Forms.Label();
            this.counter_hexagon = new System.Windows.Forms.Label();
            this.counter_score = new System.Windows.Forms.Label();
            this.hexagon_group = new System.Windows.Forms.FlowLayoutPanel();
            this.triangle_group = new System.Windows.Forms.FlowLayoutPanel();
            this.square_group = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.hexagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.hexagon_group.SuspendLayout();
            this.triangle_group.SuspendLayout();
            this.square_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счётчик:";
            // 
            // timerSquare
            // 
            this.timerSquare.Interval = 1000;
            this.timerSquare.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTriangle
            // 
            this.timerTriangle.Interval = 1000;
            this.timerTriangle.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerHexagon
            // 
            this.timerHexagon.Interval = 1000;
            this.timerHexagon.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // hexagon
            // 
            this.hexagon.BackColor = System.Drawing.SystemColors.Control;
            this.hexagon.Image = global::_25__игра_.Properties.Resources.hexagon_clipart_pdf_18;
            this.hexagon.Location = new System.Drawing.Point(26, 3);
            this.hexagon.MaximumSize = new System.Drawing.Size(100, 100);
            this.hexagon.MinimumSize = new System.Drawing.Size(100, 100);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(100, 100);
            this.hexagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hexagon.TabIndex = 5;
            this.hexagon.TabStop = false;
            this.hexagon.Click += new System.EventHandler(this.hexagon_Click);
            // 
            // triangle
            // 
            this.triangle.Image = global::_25__игра_.Properties.Resources.triangle_PNG34;
            this.triangle.Location = new System.Drawing.Point(26, 3);
            this.triangle.MaximumSize = new System.Drawing.Size(100, 100);
            this.triangle.MinimumSize = new System.Drawing.Size(100, 100);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(100, 100);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 6;
            this.triangle.TabStop = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // square
            // 
            this.square.Image = global::_25__игра_.Properties.Resources.clipart_shapes_four_18;
            this.square.Location = new System.Drawing.Point(26, 3);
            this.square.MaximumSize = new System.Drawing.Size(100, 100);
            this.square.MinimumSize = new System.Drawing.Size(100, 100);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(100, 100);
            this.square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.square.TabIndex = 7;
            this.square.TabStop = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // counter_square
            // 
            this.counter_square.AutoSize = true;
            this.counter_square.BackColor = System.Drawing.Color.Red;
            this.counter_square.Location = new System.Drawing.Point(3, 0);
            this.counter_square.Name = "counter_square";
            this.counter_square.Size = new System.Drawing.Size(17, 20);
            this.counter_square.TabIndex = 8;
            this.counter_square.Text = "0";
            // 
            // counter_triangle
            // 
            this.counter_triangle.AutoSize = true;
            this.counter_triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.counter_triangle.Location = new System.Drawing.Point(3, 0);
            this.counter_triangle.Name = "counter_triangle";
            this.counter_triangle.Size = new System.Drawing.Size(17, 20);
            this.counter_triangle.TabIndex = 9;
            this.counter_triangle.Text = "0";
            // 
            // counter_hexagon
            // 
            this.counter_hexagon.AutoSize = true;
            this.counter_hexagon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.counter_hexagon.Location = new System.Drawing.Point(3, 0);
            this.counter_hexagon.Name = "counter_hexagon";
            this.counter_hexagon.Size = new System.Drawing.Size(17, 20);
            this.counter_hexagon.TabIndex = 10;
            this.counter_hexagon.Text = "0";
            // 
            // counter_score
            // 
            this.counter_score.AutoSize = true;
            this.counter_score.Location = new System.Drawing.Point(75, 10);
            this.counter_score.Name = "counter_score";
            this.counter_score.Size = new System.Drawing.Size(17, 20);
            this.counter_score.TabIndex = 12;
            this.counter_score.Text = "0";
            // 
            // hexagon_group
            // 
            this.hexagon_group.Controls.Add(this.counter_hexagon);
            this.hexagon_group.Controls.Add(this.hexagon);
            this.hexagon_group.Location = new System.Drawing.Point(75, 287);
            this.hexagon_group.Name = "hexagon_group";
            this.hexagon_group.Size = new System.Drawing.Size(130, 100);
            this.hexagon_group.TabIndex = 13;
            // 
            // triangle_group
            // 
            this.triangle_group.Controls.Add(this.counter_triangle);
            this.triangle_group.Controls.Add(this.triangle);
            this.triangle_group.Location = new System.Drawing.Point(202, 87);
            this.triangle_group.Name = "triangle_group";
            this.triangle_group.Size = new System.Drawing.Size(129, 104);
            this.triangle_group.TabIndex = 14;
            // 
            // square_group
            // 
            this.square_group.Controls.Add(this.counter_square);
            this.square_group.Controls.Add(this.square);
            this.square_group.Location = new System.Drawing.Point(506, 287);
            this.square_group.Name = "square_group";
            this.square_group.Size = new System.Drawing.Size(129, 103);
            this.square_group.TabIndex = 15;
            // 
            // game_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.square_group);
            this.Controls.Add(this.triangle_group);
            this.Controls.Add(this.hexagon_group);
            this.Controls.Add(this.counter_score);
            this.Controls.Add(this.label1);
            this.Name = "game_frame";
            this.Text = "Игровое поле";
            this.Load += new System.EventHandler(this.game_frame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hexagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.hexagon_group.ResumeLayout(false);
            this.hexagon_group.PerformLayout();
            this.triangle_group.ResumeLayout(false);
            this.triangle_group.PerformLayout();
            this.square_group.ResumeLayout(false);
            this.square_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSquare;
        private System.Windows.Forms.Timer timerTriangle;
        private System.Windows.Forms.Timer timerHexagon;
        private System.Windows.Forms.PictureBox hexagon;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox square;
        private System.Windows.Forms.Label counter_square;
        private System.Windows.Forms.Label counter_triangle;
        private System.Windows.Forms.Label counter_hexagon;
        private System.Windows.Forms.Label counter_score;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel triangle_group;
        private System.Windows.Forms.FlowLayoutPanel square_group;
        private System.Windows.Forms.FlowLayoutPanel hexagon_group;
    }
}