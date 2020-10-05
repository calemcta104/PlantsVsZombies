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

namespace PlantsVsZombies
{
    public partial class GameScreen : UserControl
    {
        //TODO - code peas and damage
        #region Variables
        List<zombie> zombieList = new List<zombie>();
        List<sunflower> sunflowerList = new List<sunflower>();
        List<peashooter> peashooterList = new List<peashooter>();

        Boolean sunflowerPlaceMode = false;
        Boolean peashooterPlaceMode = false;
        Boolean shovelMode = false;
        int sun = 0;

        int plantSize = 50;
        int health = 3;
        int zombieSize = 50;
        int zombieSpeed = 2;

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
            //start zombie timer
            zombieTimer.Enabled = true;
        }

        public void ZombiePlace()
        {
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
                e.Graphics.DrawImage(Properties.Resources.sunflowerLeft, s.x, s.y);
            }
            foreach (peashooter p in peashooterList)
            {
                e.Graphics.DrawImage(Properties.Resources.peashooter, p.x, p.y);
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
            //check for collision of zombies and peas
            //check for collision of plants and zombies

            //updating sun label
            sunLabel.Text = sun + " Sun";


            // creating rectangles for plants
            for (int i = 0; i < peashooterList.Count && i < sunflowerList.Count && i < zombieList.Count; i++)
            {
                Rectangle peashooterRec = new Rectangle(peashooterList[i].x, peashooterList[i].y, plantSize, plantSize);
                Rectangle sunflowerRec = new Rectangle(sunflowerList[i].x, sunflowerList[i].y, plantSize, plantSize);
                Rectangle zombieRec = new Rectangle(zombieList[i].x, zombieList[i].y, zombieSize, zombieSize);
                if (zombieRec.IntersectsWith(sunflowerRec) || zombieRec.IntersectsWith(peashooterRec))
                {
                    gameLoop.Enabled = false;
                }
            }

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
                }
            }
            Refresh();
        }


        private void sunflowerTimer_Tick(object sender, EventArgs e)
        {
            sun += 50;
        }

        private void zombieTimer_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        #region place buttons
        private void row1Space1Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
            peashooter pea1 = new peashooter(plantSize, 190 - plantSize, laneOneHeight + plantSize * 2);
            peashooterList.Add(pea1);
            peashooterTimer.Enabled = true;
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower1 = new sunflower(plantSize, 190 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower1);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
            //remove plant
            }
        }

        private void row1Space2Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea2 = new peashooter(plantSize, 260 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea2);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower2 = new sunflower(plantSize, 260 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower2);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row1Space3Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea3 = new peashooter(plantSize, 340 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea3);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower3 = new sunflower(plantSize, 340 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower3);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row1Space4Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea4 = new peashooter(plantSize, 410 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea4);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower4 = new sunflower(plantSize, 410 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower4);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row1Space5Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea5 = new peashooter(plantSize, 485 - plantSize, laneOneHeight + plantSize * 2);
                peashooterList.Add(pea5);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower5 = new sunflower(plantSize, 485 - plantSize, laneOneHeight + plantSize * 2);
                sunflowerList.Add(sunflower5);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row2Space1Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea6 = new peashooter(plantSize, 190 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea6);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower6 = new sunflower(plantSize, 190 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower6);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row2Space2Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea7 = new peashooter(plantSize, 260 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea7);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower7 = new sunflower(plantSize, 260 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower7);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row2Space3Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea8 = new peashooter(plantSize, 340 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea8);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower8 = new sunflower(plantSize, 340 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower8);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row2Space4Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea9 = new peashooter(plantSize, 410 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea9);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower9 = new sunflower(plantSize, 410 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower9);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }

        private void row2Space5Button_Click(object sender, EventArgs e)
        {
            if (peashooterPlaceMode == true)
            {
                peashooter pea10 = new peashooter(plantSize, 485 - plantSize, laneTwoHeight + plantSize * 2);
                peashooterList.Add(pea10);
                if (peashooterTimer.Enabled == false)
                { peashooterTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (sunflowerPlaceMode == true)
            {
                sunflower sunflower10 = new sunflower(plantSize, 485 - plantSize, laneTwoHeight + plantSize * 2);
                sunflowerList.Add(sunflower10);
                if (sunflowerTimer.Enabled == false)
                { sunflowerTimer.Enabled = true; }
                PlaceCancel();
            }
            else if (shovelMode == true)
            {
                //remove plant
            }
        }
        #endregion
    }
}
