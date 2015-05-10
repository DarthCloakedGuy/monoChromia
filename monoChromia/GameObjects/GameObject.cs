using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoChromia
{
    public class GameObject
    {
        public static List<GameObject> allObjects = new List<GameObject>();

        double x;
        double y;
        int layer;

        Image defaultImage;

        public GameObject()
        {
            x = Globals.randint.Next(800);
            y = Globals.randint.Next(600);
            defaultImage = Image.FromFile(@".\\ImageResources\\derpghost.png");
            layer = 4;

            allObjects.Add(this);
        }

        public Sprite render()
        {
            Point loc = new Point((int)x, (int)y);
            Sprite spr = new Sprite(loc, defaultImage, layer);
            return spr;
        }
    }
}
