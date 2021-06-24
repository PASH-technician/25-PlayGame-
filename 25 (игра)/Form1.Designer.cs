
namespace _25__игра_
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_game = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_game
            // 
            this.start_game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_game.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_game.Location = new System.Drawing.Point(12, 12);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(343, 68);
            this.start_game.TabIndex = 0;
            this.start_game.Text = "Начать игру";
            this.start_game.UseVisualStyleBackColor = true;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(12, 105);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(342, 76);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 193);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start_game);
            this.MaximumSize = new System.Drawing.Size(385, 240);
            this.MinimumSize = new System.Drawing.Size(385, 240);
            this.Name = "Main";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_game;
        private System.Windows.Forms.Button exit;
    }
}

