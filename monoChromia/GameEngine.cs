using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoChromia
{
    public class GameEngine
    {
        GraphicsEngine canvas;

        public GameEngine(GraphicsEngine _canvas)
        {
            GameObject thingie = new GameObject();
            canvas = _canvas;
        }

        public void tick()
        {
            for (int i = 0; i < GameObject.allObjects.Count(); i++)
            {
                canvas.addSprite(GameObject.allObjects[i].render());
            }
        }
    }
}
