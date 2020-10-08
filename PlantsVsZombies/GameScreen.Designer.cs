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
            this.row2Space1Button = new System.Windows.Forms.Button();
            this.row1Space1Button = new System.Windows.Forms.Button();
            this.row1Space2Button = new System.Windows.Forms.Button();
            this.row1Space3Button = new System.Windows.Forms.Button();
            this.row1Space4Button = new System.Windows.Forms.Button();
            this.row1Space5Button = new System.Windows.Forms.Button();
            this.row2Space2Button = new System.Windows.Forms.Button();
            this.row2Space3Button = new System.Windows.Forms.Button();
            this.row2Space4Button = new System.Windows.Forms.Button();
            this.row2Space5Button = new System.Windows.Forms.Button();
            this.sunflowerTimer = new System.Windows.Forms.Timer(this.components);
            this.peashooterTimer = new System.Windows.Forms.Timer(this.components);
            this.zombieTimer = new System.Windows.Forms.Timer(this.components);
            this.placeCancelButton = new System.Windows.Forms.Button();
            this.noSunLabel = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // sunflowerButton
            // 
            this.sunflowerButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.sunflowerButton.BackgroundImage = global::PlantsVsZombies.Properties.Resources.sunflowerLeft;
            this.sunflowerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sunflowerButton.Location = new System.Drawing.Point(3, 4);
            this.sunflowerButton.Name = "sunflowerButton";
            this.sunflowerButton.Size = new System.Drawing.Size(110, 140);
            this.sunflowerButton.TabIndex = 0;
            this.sunflowerButton.UseVisualStyleBackColor = false;
            this.sunflowerButton.Click += new System.EventHandler(this.sunflowerButton_Click);
            // 
            // peaButton
            // 
            this.peaButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.peaButton.BackgroundImage = global::PlantsVsZombies.Properties.Resources.peashooter;
            this.peaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.peaButton.Location = new System.Drawing.Point(119, 1);
            this.peaButton.Name = "peaButton";
            this.peaButton.Size = new System.Drawing.Size(110, 141);
            this.peaButton.TabIndex = 1;
            this.peaButton.UseVisualStyleBackColor = false;
            this.peaButton.Click += new System.EventHandler(this.peaButton_Click);
            // 
            // sunflowerLabel
            // 
            this.sunflowerLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.sunflowerLabel.Location = new System.Drawing.Point(3, 147);
            this.sunflowerLabel.Name = "sunflowerLabel";
            this.sunflowerLabel.Size = new System.Drawing.Size(106, 25);
            this.sunflowerLabel.TabIndex = 2;
            this.sunflowerLabel.Text = "50";
            this.sunflowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peaLabel
            // 
            this.peaLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.peaLabel.Location = new System.Drawing.Point(120, 147);
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
            this.sunLabel.Location = new System.Drawing.Point(235, 4);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(306, 74);
            this.sunLabel.TabIndex = 4;
            this.sunLabel.Text = "0 Sun";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shovelButton
            // 
            this.shovelButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.shovelButton.BackgroundImage = global::PlantsVsZombies.Properties.Resources.shovel;
            this.shovelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shovelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shovelButton.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shovelButton.Location = new System.Drawing.Point(547, 4);
            this.shovelButton.Name = "shovelButton";
            this.shovelButton.Size = new System.Drawing.Size(208, 75);
            this.shovelButton.TabIndex = 5;
            this.shovelButton.UseVisualStyleBackColor = false;
            this.shovelButton.Click += new System.EventHandler(this.shovelButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pauseButton.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(896, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(115, 61);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // row2Space1Button
            // 
            this.row2Space1Button.Location = new System.Drawing.Point(189, 556);
            this.row2Space1Button.Name = "row2Space1Button";
            this.row2Space1Button.Size = new System.Drawing.Size(72, 48);
            this.row2Space1Button.TabIndex = 7;
            this.row2Space1Button.Text = "HERE?";
            this.row2Space1Button.UseVisualStyleBackColor = true;
            this.row2Space1Button.Visible = false;
            this.row2Space1Button.Click += new System.EventHandler(this.row2Space1Button_Click);
            // 
            // row1Space1Button
            // 
            this.row1Space1Button.Location = new System.Drawing.Point(189, 320);
            this.row1Space1Button.Name = "row1Space1Button";
            this.row1Space1Button.Size = new System.Drawing.Size(72, 48);
            this.row1Space1Button.TabIndex = 8;
            this.row1Space1Button.Text = "HERE?";
            this.row1Space1Button.UseVisualStyleBackColor = true;
            this.row1Space1Button.Visible = false;
            this.row1Space1Button.Click += new System.EventHandler(this.row1Space1Button_Click);
            // 
            // row1Space2Button
            // 
            this.row1Space2Button.Location = new System.Drawing.Point(288, 320);
            this.row1Space2Button.Name = "row1Space2Button";
            this.row1Space2Button.Size = new System.Drawing.Size(72, 48);
            this.row1Space2Button.TabIndex = 9;
            this.row1Space2Button.Text = "HERE?";
            this.row1Space2Button.UseVisualStyleBackColor = true;
            this.row1Space2Button.Visible = false;
            this.row1Space2Button.Click += new System.EventHandler(this.row1Space2Button_Click);
            // 
            // row1Space3Button
            // 
            this.row1Space3Button.Location = new System.Drawing.Point(389, 320);
            this.row1Space3Button.Name = "row1Space3Button";
            this.row1Space3Button.Size = new System.Drawing.Size(72, 48);
            this.row1Space3Button.TabIndex = 10;
            this.row1Space3Button.Text = "HERE?";
            this.row1Space3Button.UseVisualStyleBackColor = true;
            this.row1Space3Button.Visible = false;
            this.row1Space3Button.Click += new System.EventHandler(this.row1Space3Button_Click);
            // 
            // row1Space4Button
            // 
            this.row1Space4Button.Location = new System.Drawing.Point(487, 320);
            this.row1Space4Button.Name = "row1Space4Button";
            this.row1Space4Button.Size = new System.Drawing.Size(72, 48);
            this.row1Space4Button.TabIndex = 11;
            this.row1Space4Button.Text = "HERE?";
            this.row1Space4Button.UseVisualStyleBackColor = true;
            this.row1Space4Button.Visible = false;
            this.row1Space4Button.Click += new System.EventHandler(this.row1Space4Button_Click);
            // 
            // row1Space5Button
            // 
            this.row1Space5Button.Location = new System.Drawing.Point(590, 320);
            this.row1Space5Button.Name = "row1Space5Button";
            this.row1Space5Button.Size = new System.Drawing.Size(72, 48);
            this.row1Space5Button.TabIndex = 12;
            this.row1Space5Button.Text = "HERE?";
            this.row1Space5Button.UseVisualStyleBackColor = true;
            this.row1Space5Button.Visible = false;
            this.row1Space5Button.Click += new System.EventHandler(this.row1Space5Button_Click);
            // 
            // row2Space2Button
            // 
            this.row2Space2Button.Location = new System.Drawing.Point(288, 556);
            this.row2Space2Button.Name = "row2Space2Button";
            this.row2Space2Button.Size = new System.Drawing.Size(72, 48);
            this.row2Space2Button.TabIndex = 13;
            this.row2Space2Button.Text = "HERE?";
            this.row2Space2Button.UseVisualStyleBackColor = true;
            this.row2Space2Button.Visible = false;
            this.row2Space2Button.Click += new System.EventHandler(this.row2Space2Button_Click);
            // 
            // row2Space3Button
            // 
            this.row2Space3Button.Location = new System.Drawing.Point(389, 556);
            this.row2Space3Button.Name = "row2Space3Button";
            this.row2Space3Button.Size = new System.Drawing.Size(72, 48);
            this.row2Space3Button.TabIndex = 14;
            this.row2Space3Button.Text = "HERE?";
            this.row2Space3Button.UseVisualStyleBackColor = true;
            this.row2Space3Button.Visible = false;
            this.row2Space3Button.Click += new System.EventHandler(this.row2Space3Button_Click);
            // 
            // row2Space4Button
            // 
            this.row2Space4Button.Location = new System.Drawing.Point(487, 556);
            this.row2Space4Button.Name = "row2Space4Button";
            this.row2Space4Button.Size = new System.Drawing.Size(72, 48);
            this.row2Space4Button.TabIndex = 15;
            this.row2Space4Button.Text = "HERE?";
            this.row2Space4Button.UseVisualStyleBackColor = true;
            this.row2Space4Button.Visible = false;
            this.row2Space4Button.Click += new System.EventHandler(this.row2Space4Button_Click);
            // 
            // row2Space5Button
            // 
            this.row2Space5Button.Location = new System.Drawing.Point(590, 556);
            this.row2Space5Button.Name = "row2Space5Button";
            this.row2Space5Button.Size = new System.Drawing.Size(72, 48);
            this.row2Space5Button.TabIndex = 16;
            this.row2Space5Button.Text = "HERE?";
            this.row2Space5Button.UseVisualStyleBackColor = true;
            this.row2Space5Button.Visible = false;
            this.row2Space5Button.Click += new System.EventHandler(this.row2Space5Button_Click);
            // 
            // sunflowerTimer
            // 
            this.sunflowerTimer.Interval = 5000;
            this.sunflowerTimer.Tick += new System.EventHandler(this.sunflowerTimer_Tick);
            // 
            // peashooterTimer
            // 
            this.peashooterTimer.Interval = 4500;
            this.peashooterTimer.Tick += new System.EventHandler(this.peashooterTimer_Tick);
            // 
            // zombieTimer
            // 
            this.zombieTimer.Interval = 8500;
            this.zombieTimer.Tick += new System.EventHandler(this.zombieTimer_Tick);
            // 
            // placeCancelButton
            // 
            this.placeCancelButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.placeCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.placeCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.placeCancelButton.Font = new System.Drawing.Font("Cooper Black", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeCancelButton.ForeColor = System.Drawing.Color.Maroon;
            this.placeCancelButton.Location = new System.Drawing.Point(771, 4);
            this.placeCancelButton.Name = "placeCancelButton";
            this.placeCancelButton.Size = new System.Drawing.Size(119, 74);
            this.placeCancelButton.TabIndex = 17;
            this.placeCancelButton.Text = "X";
            this.placeCancelButton.UseVisualStyleBackColor = false;
            this.placeCancelButton.Click += new System.EventHandler(this.placeCancelButton_Click);
            // 
            // noSunLabel
            // 
            this.noSunLabel.BackColor = System.Drawing.Color.Transparent;
            this.noSunLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSunLabel.ForeColor = System.Drawing.Color.White;
            this.noSunLabel.Location = new System.Drawing.Point(236, 82);
            this.noSunLabel.Name = "noSunLabel";
            this.noSunLabel.Size = new System.Drawing.Size(305, 60);
            this.noSunLabel.TabIndex = 18;
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.resumeButton.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.Location = new System.Drawing.Point(518, 222);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(123, 72);
            this.resumeButton.TabIndex = 19;
            this.resumeButton.Text = "Resume?";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PlantsVsZombies.Properties.Resources.pVzBackgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.noSunLabel);
            this.Controls.Add(this.placeCancelButton);
            this.Controls.Add(this.row2Space5Button);
            this.Controls.Add(this.row2Space4Button);
            this.Controls.Add(this.row2Space3Button);
            this.Controls.Add(this.row2Space2Button);
            this.Controls.Add(this.row1Space5Button);
            this.Controls.Add(this.row1Space4Button);
            this.Controls.Add(this.row1Space3Button);
            this.Controls.Add(this.row1Space2Button);
            this.Controls.Add(this.row1Space1Button);
            this.Controls.Add(this.row2Space1Button);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.shovelButton);
            this.Controls.Add(this.sunLabel);
            this.Controls.Add(this.peaLabel);
            this.Controls.Add(this.sunflowerLabel);
            this.Controls.Add(this.peaButton);
            this.Controls.Add(this.sunflowerButton);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1110, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
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
        private System.Windows.Forms.Button row2Space1Button;
        private System.Windows.Forms.Button row1Space1Button;
        private System.Windows.Forms.Button row1Space2Button;
        private System.Windows.Forms.Button row1Space3Button;
        private System.Windows.Forms.Button row1Space4Button;
        private System.Windows.Forms.Button row1Space5Button;
        private System.Windows.Forms.Button row2Space2Button;
        private System.Windows.Forms.Button row2Space3Button;
        private System.Windows.Forms.Button row2Space4Button;
        private System.Windows.Forms.Button row2Space5Button;
        private System.Windows.Forms.Timer sunflowerTimer;
        private System.Windows.Forms.Timer peashooterTimer;
        private System.Windows.Forms.Timer zombieTimer;
        private System.Windows.Forms.Button placeCancelButton;
        private System.Windows.Forms.Label noSunLabel;
        private System.Windows.Forms.Button resumeButton;
    }
}
