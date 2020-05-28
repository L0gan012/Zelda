using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint0
{
    class MouseController : IController
    {
        //Instance variables
        private Dictionary<Rectangle, ICommand> commandDictionary;

        //Constructor with game instance parameter
        public MouseController(Dictionary<Rectangle, ICommand> mouseCommands)
        {
            commandDictionary = mouseCommands;
        }

        //Updates based on mouse presses and location
        public void Update()
        {
            //Loops through all of the key command pairs in the dictionary
            foreach (KeyValuePair<Rectangle, ICommand> pair in commandDictionary)
            {
                //Gets the position of the mouse
                int xLocation = Mouse.GetState().X;
                int yLocation = Mouse.GetState().Y;

                //If the left mouse button was pressed execute the command for the corresponding quadrant
                if(pair.Key.Contains(xLocation, yLocation) && Mouse.GetState().LeftButton.Equals(ButtonState.Pressed))
                {
                    pair.Value.Execute();
                } 
                //If the right mouse button was pressed execute the exit command
                else if (pair.Key.Equals(new Rectangle()) && Mouse.GetState().RightButton.Equals(ButtonState.Pressed))
                {
                    pair.Value.Execute();
                }
            }
        }
    }
}
