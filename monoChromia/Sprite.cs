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
    //NOTE: Instead of using a custom method, "die," impliment the IDisposible interface.
    public class Sprite : IDisposable
    {
        public Point Location { get; set; }
        public Image Frame {get; set;}
        public int Layer { get; set; }

        public Sprite(int _x, int _y)
        {
            Location = new Point(_x, _y);
            Frame = Image.FromFile(@".\ImageResources\derpghost.png");
            Layer = 4;
        }

        public Sprite(int _x, int _y, int _l)
        {
            Location = new Point(_x, _y);
            Frame = Image.FromFile(@".\ImageResources\derpghost.png");
            Layer = _l;
        }

        public Sprite(Point _loc)
        {
            Location = _loc;
            Frame = Image.FromFile(@".\ImageResources\derpghost.png");
            Layer = 4;
        }

        public Sprite(Point _loc, int _l)
        {
            Location = _loc;
            Frame = Image.FromFile(@".\ImageResources\derpghost.png");
            Layer = _l;
        }

        public Sprite(int _x, int _y, String _f)
        {
            Location = new Point(_x, _y);
            Frame = Image.FromFile(_f);
            Layer = 4;
        }

        public Sprite(int _x, int _y, String _f, int _l)
        {
            Location = new Point(_x, _y);
            Frame = Image.FromFile(_f);
            Layer = _l;
        }

        public Sprite(Point _loc, String _f)
        {
            Location = _loc;
            Frame = Image.FromFile(_f);
            Layer = 4;
        }

        public Sprite(Point _loc, String _f, int _l)
        {
            Location = _loc;
            Frame = Image.FromFile(_f);
            Layer = _l;
        }

        public Sprite(int _x, int _y, Image _f)
        {
            Location = new Point(_x, _y);
            Frame = _f;
            Layer = 4;
        }

        public Sprite(int _x, int _y, Image _f, int _l)
        {
            Location = new Point(_x, _y);
            Frame = _f;
            Layer = _l;
        }

        public Sprite(Point _loc, Image _f)
        {
            Location = _loc;
            Frame = _f;
            Layer = 4;
        }

        public Sprite(Point _loc, Image _f, int _l)
        {
            Location = _loc;
            Frame = _f;
            Layer = _l;
        }

        public void Dispose()
        {
            Frame.Dispose();
        }
    }
}
