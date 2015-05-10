using monoChromia.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monoChromia
{
    public partial class Form1 : Form
    {
        //TODO: I renamed a number of members and methods to meet the .NET naming style guidlines.

        private Globals GlobalInstance;
        private GraphicsEngine RawGraphicsEngine;
        private GameEngine Game;
        private GameCursor SwordCursor;
        private int LastTick;

        public Form1()
        {
            LastTick = Environment.TickCount;
            InitializeComponent();
            GlobalInstance = new Globals();
            Game = new GameEngine();
            SwordCursor = new GameCursor();
            Game.ObjectsInPlay.Add(SwordCursor);
            for (int i = 0; i < 50; i++)
                Game.ObjectsInPlay.Add(new WiggleMonster());
            RawGraphicsEngine = new GraphicsEngine();
        }

        private void Form1_MouseHandle(object sender, MouseEventArgs e)
        {

        }

        private void gameWindow_MouseEnter(object sender, System.EventArgs e)
        {
            Cursor.Hide();
        }

        private void gameWindow_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    {
                        break;
                    }
                case Keys.Q:
                    {

                        break;
                    }
                case Keys.PageDown:
                    {

                        break;
                    }
                case Keys.PageUp:
                    {
                        break;
                    }
                case Keys.Up:
                    {
                        break;
                    }
                case Keys.Down:
                    {
                        break;
                    }
                case Keys.Left:
                    {
                        break;
                    }
                case Keys.Right:
                    {
                        break;
                    }

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            SwordCursor.StateTransition(1);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SwordCursor.StateTransition(0);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.UpdateWorld();
            //NOTE: The cursor is a special game object for now.
            SwordCursor.UpdateLocation(gameWindow.PointToClient(Cursor.Position));
            gameWindow.BackgroundImage = RawGraphicsEngine.FrameUpdate(
                Game.GetVisibleObjects().
                Select(x => x.TransformedSprite()).ToList());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}