using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoChromia
{
    public class GameEngine
    {
        public List<GameObject> ObjectsInPlay { get; set; }

        public GameEngine()
        {
            ObjectsInPlay = new List<GameObject>();
        }

        //TODO: In order to do collision detection and such, the GameEngine needs some
        // knowledge of what sprites each object has, so it can construct hit-boxes
        // and do other, more refined pixel-by-pixel tests.
        // Though, perhaps that should be a job for the GameObjects themselves.
        // When given another GameObject say whether any of their pixels overlap...

        //TODO: Impliment some method of getting the game objects to communicate with each-other.
        // Like, a monster is on the screen and wants to eat the player.
        // The monster needs some way of detecting the player.

        public void UpdateWorld()
        {
            //TODO: Might want to seperate this out into objects that need updates and those that don't.
            foreach (var gameObject in ObjectsInPlay)
                gameObject.DoNext();
        }

        public IEnumerable<GameObject> GetVisibleObjects()
        {
            //TODO: This should only get the visible objects. :D
            return ObjectsInPlay;
        }
    }
}
