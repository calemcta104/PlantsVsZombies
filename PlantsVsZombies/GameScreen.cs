//October 5, 2020
//Calem McTavish
//Plants vs Zombies game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PlantsVsZombies
{
    public partial class GameScreen : UserControl
    {
        #region Variables
        //lists for classes
        List<zombie> zombieList = new List<zombie>();
        List<sunflower> sunflowerList = new List<sunflower>();
        List<peashooter> peashooterList = new List<peashooter>();
        List<Pea> peaList = new List<Pea>();

        Boolean sunflowerPlaceMode = false;
        Boolean peashooterPlaceMode = false;
        Boolean shovelMode = false;
        Boolean peaShot = false;

        //starting sun amount
        int sun = 50;

        //plant and zombie starting values
        int plantSize = 50;
        int health = 1;
        int zombieSize = 100;
        int zombieSpeed = 1;
        int peaSpeed = 7;
        int peaSize = 10;

        //lane heights for placing
        int laneOneHeight = 90;
        int laneTwoHeight = 270;

        Random randGen = new Random();
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            ZombiePlace();
        }

        public void OnStart()
        {
            zombieTimer.Enabled = true;
            resumeButton.Visible = false;
        }

        public void ZombiePlace()
        {
            //randomizes which lane the zombie will spawn in
            int rand = randGen.Next(1, 3);
            if (rand == 1)
            {
                zombie zombie1 = new zombie(zombieSize, 800, laneOneHeight, health);
                zombieList.Add(zombie1);
            }
            if (rand == 2)
            {
                zombie zombie2 = new zombie(zombieSize, 800, laneTwoHeight, health);
                zombieList.Add(zombie2);
            }

        }

        #region place buttons visable
        public void PeashooterPlace()
        {
            row1Space1Button.Visible = true;
            row1Space2Button.Visible = true;
            row1Space3Button.Visible = true;
            row1Space4Button.Visible = true;
            row1Space5Button.Visible = true;
            row2Space1Button.Visible = true;
            row2Space2Button.Visible = true;
            row2Space3Button.Visible = true;
            row2Space4Button.Visible = true;
            row2Space5Button.Visible = true;
        }
        public void SunflowerPlace()
        {
            row1Space1Button.Visible = true;
            row1Space2Button.Visible = true;
            row1Space3Button.Visible = true;
            row1Space4Button.Visible = true;
            row1Space5Button.Visible = true;
            row2Space1Button.Visible = true;
            row2Space2Button.Visible = true;
            row2Space3Button.Visible = true;
            row2Space4Button.Visible = true;
            row2Space5Button.Visible = true;
        }
        public void Shovel()
        {
            row1Space1Button.Visible = true;
            row1Space2Button.Visible = true;
            row1Space3Button.Visible = true;
            row1Space4Button.Visible = true;
            row1Space5Button.Visible = true;
            row2Space1Button.Visible = true;
            row2Space2Button.Visible = true;
            row2Space3Button.Visible = true;
            row2Space4Button.Visible = true;
            row2Space5Button.Visible = true;
        }
        public void PlaceCancel()
        {
            shovelMode = false;
            peashooterPlaceMode = false;
            sunflowerPlaceMode = false;

            row1Space1Button.Visible = false;
            row1Space2Button.Visible = false;
            row1Space3Button.Visible = false;
            row1Space4Button.Visible = false;
            row1Space5Button.Visible = false;
            row2Space1Button.Visible = false;
            row2Space2Button.Visible = false;
            row2Space3Button.Visible = false;
            row2Space4Button.Visible = false;
            row2Space5Button.Visible = false;
        }
        #endregion

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //drawimage for zombies and plants and peas
            foreach (zombie z in zombieList)
            {
                e.Graphics.DrawImage(Properties.Resources.ZombieEye, z.x, z.y);
            }
            foreach (sunflower s in sunflowerList)
            {
                //randomizing which sunfower sprite will appear
                int rand = randGen.Next(1, 4);
                if (rand == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.sunflowerLeft, s.x, s.y);
                }
                if (rand == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.sunflowerRightFix, s.x, s.y);
                }
                if (rand == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.sunflowerUp, s.x, s.y);
                }

            }
            foreach (peashooter p in peashooterList)
            {
                e.Graphics.DrawImage(Properties.Resources.peashooter, p.x, p.y);
            }
            foreach (Pea pe in peaList)
            {
                e.Graphics.DrawImage(Properties.Resources.pea_go, pe.x, pe.y);
            }
        }

        #region HUD buttons
        private void peaButton_Click(object sender, EventArgs e)
        {
            peashooterPlaceMode = true;
            sunflowerPlaceMode = false;
            shovelMode = false;
        }

        private void sunflowerButton_Click(object sender, EventArgs e)
        {
            sunflowerPlaceMode = true;
            shovelMode = false;
            peashooterPlaceMode = false;
        }

        private void shovelButton_Click(object sender, EventArgs e)
        {
            shovelMode = true;
            sunflowerPlaceMode = false;
            peashooterPlaceMode = false;
        }

        private void placeCancelButton_Click(object sender, EventArgs e)
        {
            PlaceCancel();
        }
        #endregion

        #region timer ticks

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update movement of zombies
            foreach (zombie z in zombieList)
            {
                z.Move(zombieSpeed);
            }

            //update movement of peas
            if (peaShot == true && zombieList.Count >= 1)
            {
                foreach (peashooter p in peashooterList)
                {
                    Pea pea1 = new Pea(peaSize, p.x + 45, p.y - 15);
                    peaList.Add(pea1);
                }
                peaShot = false;
            }
            foreach (Pea pe in peaList)
            {
                pe.Shoot(peaSpeed);
            }

            //updating sun label
            sunLabel.Text = sun + " Sun";

            // collisions
            Collisions();

            //checking to see if places modes are activated
            if (peashooterPlaceMode == true)
            {
                PeashooterPlace();
            }
            if (sunflowerPlaceMode == true)
            {
                SunflowerPlace();
            }
            if (shovelMode == true)
            {
                Shovel();
            }

            //end game
            foreach (zombie z in zombieList)
            {
                if (z.x < 0)
                {
                    gameLoop.Enabled = false;
                    sunflowerTimer.Enabled = false;
                    peashooterTimer.Enabled = false;
                    zombieTimer.Enabled = false;
                    Thread.Sleep(1000);

                    peaLabel.Visible = false;
                    sunflowerLabel.Visible = false;
                    sunLabel.Visible = false;
                    noSunLabel.Visible = false;
                    sunflowerButton.Visible = false;
                    peaButton.Visible = false;
                    shovelButton.Visible = false;
                    placeCancelButton.Visible = false;
                    pauseButton.Visible = false;
                    PlaceCancel();

                    MainScreen ms = new MainScreen();

                    this.Controls.Add(ms);

                    ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
                }
            }
            Refresh();
        }

        private void sunflowerTimer_Tick(object sender, EventArgs e)
        {
            //the more sunflowers you get the more sun you get
            if (sunflowerList.Count >= 1)
            {
                foreach (sunflower s in sunflowerList)
                {
                    sun += 50;
                }

            }
        }
        private void zombieTimer_Tick(object sender, EventArgs e)
        {
            ZombiePlace();
            if (zombieTimer.Interval >= 4500)
            {
                zombieTimer.Interval -= 500;
            }
        }
        private void peashooterTimer_Tick(object sender, EventArgs e)
        {
            peaShot = true;
        }
        #endregion

        public void Collisions()
        {

            foreach (zombie z in zombieList)
            {
                Rectangle zombieRec = new Rectangle(z.x, z.y, zombieSize, zombieSize + 50);


                //check for collision of peashooters and zombies
                foreach (peashooter p in peashooterList)
                {
                    Rectangle peashooterRec = new Rectangle(p.x, p.y, plantSize, plantSize);
                    if (zombieRec.IntersectsWith(peashooterRec))
                    {
                        //gameLoop.Enabled = false;
                        peashooterList.Remove(p);
                        return;
                    }
                }
                //check for collision of zombies and peas
                foreach (Pea pe in peaList)
                {
                    Rectangle peaRec = new Rectangle(pe.x, pe.y, plantSize, plantSize);
                    if (zombieRec.IntersectsWith(peaRec))
                    {
                        peaList.Remove(pe);
                        zombieList.Remove(z);
                        return;
                    }
                    else if (peaRec.X > this.Width)
                    {
                        peaList.Remove(pe);
                        return;
                    }
                }

                //check for collision of sunflowers and zombies
                foreach (sunflower s in sunflowerList)
                {
                    Rectangle sunflowerRec = new Rectangle(s.x, s.y, plantSize, plantSize);

                    if (zombieRec.IntersectsWith(sunflowerRec))
                    {
                        //gameLoop.Enabled = false;
                        sunflowerList.Remove(s);
                        return;
                    }
                }

            }
        }

        #region place buttons
        private void row1Space1Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea1 = new peashooter(plantSize, 190 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea1);
                peashooterTimer.Enabled = true;
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower1 = new sunflower(plantSize, 190 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower1);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {

                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row1Space2Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea2 = new peashooter(plantSize, 260 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea2);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower2 = new sunflower(plantSize, 260 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower2);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row1Space3Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea3 = new peashooter(plantSize, 340 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea3);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower3 = new sunflower(plantSize, 340 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower3);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row1Space4Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea4 = new peashooter(plantSize, 410 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea4);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower4 = new sunflower(plantSize, 410 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower4);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row1Space5Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea5 = new peashooter(plantSize, 485 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea5);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower5 = new sunflower(plantSize, 485 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower5);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row2Space1Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea6 = new peashooter(plantSize, 190 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea6);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower6 = new sunflower(plantSize, 190 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower6);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row2Space2Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea7 = new peashooter(plantSize, 260 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea7);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower7 = new sunflower(plantSize, 260 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower7);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row2Space3Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea8 = new peashooter(plantSize, 340 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea8);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower8 = new sunflower(plantSize, 340 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower8);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row2Space4Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea9 = new peashooter(plantSize, 410 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea9);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower9 = new sunflower(plantSize, 410 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower9);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        private void row2Space5Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true && sun >= 100)
            {
                peashooter pea10 = new peashooter(plantSize, 485 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea10);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
                sun -= 100;
            }
            else if (sunflowerPlaceMode == true && sun >= 50)
            {
                sunflower sunflower10 = new sunflower(plantSize, 485 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower10);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
                sun -= 50;
            }
            else if (shovelMode == true)
            {
                foreach (peashooter p in peashooterList)
                {
                    peashooterList.Remove(p);
                    return;
                }
                foreach (sunflower s in sunflowerList)
                {
                    sunflowerList.Remove(s);
                    return;
                }
            }
        }

        #endregion

        #region pause
        private void pauseButton_Click(object sender, EventArgs e)
        {
            gameLoop.Enabled = false;
            resumeButton.Visible = true;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            gameLoop.Enabled = true;
            resumeButton.Visible = false;
        }
        #endregion
    }
}
