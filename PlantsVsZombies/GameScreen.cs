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

        //TODO - make classes for sunflower, peashooter, and maybe walnut
        //TODO - make class for zombies
        //TODO - code zombie movement
        //TODO - code peas and damage
        //TODO - sun mechanic
        //TODO - 

        Random randGen = new Random();


        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses - decide how buttons work also
            //switch (e.KeyCode)
            //{
            //    case Keys.Left:
            //        leftArrowDown = true;
            //        break;
            //    case Keys.Right:
            //        rightArrowDown = true;
            //        break;
            //    case Keys.Up:
            //        upArrowDown = true;
            //        break;
            //    case Keys.Down:
            //        downArrowDown = true;
            //        break;
            //}
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases - decide how buttons work
            //switch (e.KeyCode)
            //{
            //    case Keys.Left:
            //        leftArrowDown = false;
            //        break;
            //    case Keys.Right:
            //        rightArrowDown = false;
            //        break;
            //    case Keys.Up:
            //        upArrowDown = false;
            //        break;
            //    case Keys.Down:
            //        downArrowDown = false;
            //        break;
            //}
        }

        public void OnStart()
        {
            //start zombie timer
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //update movement of zombies
            //update movement of peas
            //check for collision of zombies and peas
            //check for collision of plants and zombies
            //when plants are placed start plant timers


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //drawimage for zombies and plants and peas


        }

    }
}
