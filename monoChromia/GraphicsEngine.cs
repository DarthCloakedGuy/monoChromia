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
    public class GraphicsEngine
    {
        List<List<Sprite>> drawnObjects;

        Graphics drawTools;

        Bitmap pic;
        Image canvas;

        PictureBox gameWindow;

        public GraphicsEngine(PictureBox _box)
        {
            drawnObjects = new List<List<Sprite>>();
            for (int i = 0; i < 7; i++)
            {
                drawnObjects.Add(new List<Sprite>());
            }
            gameWindow = _box;
        }

        public void trackCursor(bool LMBisDown)
        {
            if (!LMBisDown)
            {
                Point loc = gameWindow.PointToClient(Cursor.Position);
                drawnObjects[0].Add(new Sprite(loc, @".\\ImageResources\\SwordCursor.png"));
            }
            if (LMBisDown)
            {
                Point loc = gameWindow.PointToClient(Cursor.Position);
                drawnObjects[0].Add(new Sprite(loc, @".\\ImageResources\\SwordCursorAlt.png"));
            }
        }

        public void initializeBitmap()
        {
            pic = new Bitmap(800, 600);

            pic.MakeTransparent(pic.GetPixel(10, 10));

            canvas = new Bitmap(pic);
            drawTools = Graphics.FromImage(canvas);
        }

        public void frameUpdate(bool _LMB)
        {
            //tool.DrawImage(Image.FromFile("Test.jpg"), 0, 0, 600, 600);
            canvas.Dispose();
            canvas = new Bitmap(pic);

            //drawLabels();
            trackCursor(_LMB);
            drawTools.Dispose();
            drawTools = Graphics.FromImage(canvas);

            drawTools.FillRectangle(Brushes.Black, 0, 0, 800, 600);
            for (int i = drawnObjects.Count() - 1; i >= 0; i--)
            {
                for (int j = 0; j < drawnObjects[i].Count(); j++)
                {
                    Point loc = new Point(drawnObjects[i][j].loc.X, drawnObjects[i][j].loc.Y);
                    Image img = drawnObjects[i][j].frame;
                    drawTools.DrawImage(img, loc);
                }
            }

            drawTools.Dispose();

            gameWindow.BackgroundImage = canvas;

            cleanup();

            //this.Refresh();
            //System.GC.Collect();


        }

        public void addSprite(Sprite _newsprite)
        {
            drawnObjects[_newsprite.layer].Add(_newsprite);
        }

        public void cleanup()
        {
            for (int i = 0; i < drawnObjects.Count(); i++)
            {
                for (int j = 0; j < drawnObjects[i].Count(); j++)
                {
                    drawnObjects[i][j].die();
                    drawnObjects[i].Remove(drawnObjects[i][j]);
                }
            }
        }
    }
}
