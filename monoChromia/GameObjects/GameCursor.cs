using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoChromia.GameObjects
{
    class GameCursor : GameObject
    {

        private int DEFAULT_STATE = 0;
        private Sprite[] States;

        public GameCursor()
        {
            States = new Sprite[] {
                new Sprite(new Point((int)X, (int)Y), @".\\ImageResources\\SwordCursor.png"),
                new Sprite(new Point((int)X, (int)Y), @".\\ImageResources\\SwordCursorAlt.png")
            };
            this.ShownSprite = States[DEFAULT_STATE];
        }

        public override void StateTransition(int newState)
        {
            this.ShownSprite = States[newState];
        }

        internal void UpdateLocation(System.Drawing.Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
    }
}
