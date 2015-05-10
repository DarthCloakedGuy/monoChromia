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
    public class Sprite
    {
        public Point loc;
        public Image frame;
        public int layer;

        public Sprite(int _x, int _y)
        {
            loc = new Point(_x, _y);
            frame = Image.FromFile("derpghost.png");
            layer = 4;
        }

        public Sprite(int _x, int _y, int _l)
        {
            loc = new Point(_x, _y);
            frame = Image.FromFile("derpghost.png");
            layer = _l;
        }

        public Sprite(Point _loc)
        {
            loc = _loc;
            frame = Image.FromFile("derpghost.png");
            layer = 4;
        }

        public Sprite(Point _loc, int _l)
        {
            loc = _loc;
            frame = Image.FromFile("derpghost.png");
            layer = _l;
        }

        public Sprite(int _x, int _y, String _f)
        {
            loc = new Point(_x, _y);
            frame = Image.FromFile(_f);
            layer = 4;
        }

        public Sprite(int _x, int _y, String _f, int _l)
        {
            loc = new Point(_x, _y);
            frame = Image.FromFile(_f);
            layer = _l;
        }

        public Sprite(Point _loc, String _f)
        {
            loc = _loc;
            frame = Image.FromFile(_f);
            layer = 4;
        }

        public Sprite(Point _loc, String _f, int _l)
        {
            loc = _loc;
            frame = Image.FromFile(_f);
            layer = _l;
        }

        public Sprite(int _x, int _y, Image _f)
        {
            loc = new Point(_x, _y);
            frame = _f;
            layer = 4;
        }

        public Sprite(int _x, int _y, Image _f, int _l)
        {
            loc = new Point(_x, _y);
            frame = _f;
            layer = _l;
        }

        public Sprite(Point _loc, Image _f)
        {
            loc = _loc;
            frame = _f;
            layer = 4;
        }

        public Sprite(Point _loc, Image _f, int _l)
        {
            loc = _loc;
            frame = _f;
            layer = _l;
        }

        public void die()
        {
            frame.Dispose();
        }
    }
}
