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

        public double X { get; set; }
        public double Y { get; set; }
        public Sprite ShownSprite { get; set; }

        //TODO: Based on game object state, choose which sprite will render next.

        public GameObject(int layer, Point p) { }

        public GameObject()
        {
            X = Globals.randint.Next(800);
            Y = Globals.randint.Next(600);
            ShownSprite = new Sprite((int)X, (int)Y);
            allObjects.Add(this);
        }

        public virtual void StateTransition(int state) { }

        public Sprite TransformedSprite()
        {
            ShownSprite.Location = new Point((int)X, (int)Y); 
            return ShownSprite;
        }

        public virtual void DoNext() { }
    }
}
