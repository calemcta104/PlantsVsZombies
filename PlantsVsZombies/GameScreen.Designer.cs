namespace PlantsVsZombies
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.sunflowerButton = new System.Windows.Forms.Button();
            this.peaButton = new System.Windows.Forms.Button();
            this.sunflowerLabel = new System.Windows.Forms.Label();
            this.peaLabel = new System.Windows.Forms.Label();
            this.sunLabel = new System.Windows.Forms.Label();
            this.shovelButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 18;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // sunflowerButton
            // 
            this.sunflowerButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.sunflowerButton.Location = new System.Drawing.Point(25, 20);
            this.sunflowerButton.Name = "sunflowerButton";
            this.sunflowerButton.Size = new System.Drawing.Size(110, 140);
            this.sunflowerButton.TabIndex = 0;
            this.sunflowerButton.Text = "sun";
            this.sunflowerButton.UseVisualStyleBackColor = false;
            // 
            // peaButton
            // 
            this.peaButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.peaButton.Location = new System.Drawing.Point(141, 19);
            this.peaButton.Name = "peaButton";
            this.peaButton.Size = new System.Drawing.Size(110, 141);
            this.peaButton.TabIndex = 1;
            this.peaButton.Text = "pea";
            this.peaButton.UseVisualStyleBackColor = false;
            // 
            // sunflowerLabel
            // 
            this.sunflowerLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.sunflowerLabel.Location = new System.Drawing.Point(25, 170);
            this.sunflowerLabel.Name = "sunflowerLabel";
            this.sunflowerLabel.Size = new System.Drawing.Size(109, 25);
            this.sunflowerLabel.TabIndex = 2;
            this.sunflowerLabel.Text = "50";
            this.sunflowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peaLabel
            // 
            this.peaLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.peaLabel.Location = new System.Drawing.Point(142, 170);
            this.peaLabel.Name = "peaLabel";
            this.peaLabel.Size = new System.Drawing.Size(109, 25);
            this.peaLabel.TabIndex = 3;
            this.peaLabel.Text = "100";
            this.peaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunLabel
            // 
            this.sunLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.sunLabel.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLabel.ForeColor = System.Drawing.Color.Black;
            this.sunLabel.Location = new System.Drawing.Point(267, 20);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(305, 88);
            this.sunLabel.TabIndex = 4;
            this.sunLabel.Text = "0 Sun";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shovelButton
            // 
            this.shovelButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.shovelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shovelButton.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shovelButton.Location = new System.Drawing.Point(602, 20);
            this.shovelButton.Name = "shovelButton";
            this.shovelButton.Size = new System.Drawing.Size(261, 88);
            this.shovelButton.TabIndex = 5;
            this.shovelButton.Text = "Shovel";
            this.shovelButton.UseVisualStyleBackColor = false;
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pauseButton.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(1111, 19);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(115, 61);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.shovelButton);
            this.Controls.Add(this.sunLabel);
            this.Controls.Add(this.peaLabel);
            this.Controls.Add(this.sunflowerLabel);
            this.Controls.Add(this.peaButton);
            this.Controls.Add(this.sunflowerButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1250, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Button sunflowerButton;
        private System.Windows.Forms.Button peaButton;
        private System.Windows.Forms.Label sunflowerLabel;
        private System.Windows.Forms.Label peaLabel;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.Button shovelButton;
        private System.Windows.Forms.Button pauseButton;
    }
}
