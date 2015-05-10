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
        public int LAYER_COUNT = 7;

        private Graphics DrawingSurface;
        private Bitmap ScreenTemplate;
        private Image CurrentScreen;

        public GraphicsEngine()
        {
            ScreenTemplate = new Bitmap(800, 600);
            ScreenTemplate.MakeTransparent(ScreenTemplate.GetPixel(10, 10));
            CurrentScreen = new Bitmap(ScreenTemplate);
        }

        public Image FrameUpdate(List<Sprite> visibleSprites)
        {
            //NOTE: This was changed to return the current screen because the
            // graphics engine doesn't need to know what sort of element you're
            // displaying the image on. For example, you might want to display the
            // image one some other element type.
            CurrentScreen.Dispose();
            CurrentScreen = new Bitmap(ScreenTemplate);
            if (DrawingSurface != null)
                DrawingSurface.Dispose();
            DrawingSurface = Graphics.FromImage(CurrentScreen);
            DrawingSurface.FillRectangle(Brushes.Black, 0, 0, 800, 600);
            for (int i = 0; i < LAYER_COUNT; i++)
            {
                foreach (var sprite in visibleSprites.Where(x => x.Layer == i))
                {
                    DrawingSurface.DrawImage(sprite.Frame, sprite.Location.X, sprite.Location.Y);
                }
            }
            return CurrentScreen;
        }
    }
}
