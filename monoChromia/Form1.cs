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
        Globals global;
        CursorDisp mousePos;

        GraphicsEngine canvas;
        GameEngine game;

        int lastTick;

        //Font systemHeader;
        //Font planetHeader;

        public Form1()
        {
            lastTick = Environment.TickCount;

            InitializeComponent();
            global = new Globals();
            mousePos = new CursorDisp();
            canvas = new GraphicsEngine(gameWindow);
            game = new GameEngine(canvas);

            //systemHeader = new Font("Consolas", 14);
            //planetHeader = new Font("Consolas", 10);

            canvas.initializeBitmap();
        }

        private void Form1_MouseHandle(object sender, MouseEventArgs e)
        {

        }

        private void gameWindow_MouseEnter(object sender, System.EventArgs e)
        {
            // Hide the cursor when the mouse pointer enters the button.
            Cursor.Hide();
        }

        private void gameWindow_MouseLeave(object sender, System.EventArgs e)
        {
            // Show the cursor when the mouse pointer leaves the button.
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
            mousePos.Active = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePos.Active = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bool LMBisDown = mousePos.Active;
            canvas.frameUpdate(LMBisDown);

            game.tick();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}