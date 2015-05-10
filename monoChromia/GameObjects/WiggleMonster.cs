using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoChromia.GameObjects
{
    class WiggleMonster : GameObject
    {
        private double OriginalX;
        private double OriginalY;

        private int XInterval;
        private int YInterval;

        private bool MoveLeft;
        private bool MoveUp;

        public WiggleMonster()
            : base()
        {
            OriginalX = X;
            OriginalY = Y;
            MoveLeft = true;
            MoveUp = true;
            var rand = new Random();
            XInterval = rand.Next(100);
            YInterval = rand.Next(100);
        }

        //TODO: This method is dumb. :D
        public override void DoNext()
        {
            if (MoveLeft)
            {
                X += 1;
                if (X - OriginalX > XInterval)
                    MoveLeft = false;
            }
            else
            {
                X -= 1;
                if (OriginalX - X > XInterval)
                    MoveLeft = true;
            }

            if (MoveUp)
            {
                Y += 1;
                if (Y - OriginalY > YInterval)
                    MoveUp = false;
            }
            else
            {
                Y -= 1;
                if (OriginalY - Y > YInterval)
                    MoveUp = true;
            }
        }
    }
}
