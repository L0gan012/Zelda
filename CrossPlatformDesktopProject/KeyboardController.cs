using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint0
{
    class KeyboardController : IController
    {
        //Instance variables
        private Dictionary<Keys, ICommand> commandDictionary;

        //Constructor with game instance parameter
        public KeyboardController(Dictionary<Keys, ICommand> keyboardCommands)
        {
            commandDictionary = keyboardCommands;
        }

        //Executes a command based on keyboard presses
        public void Update()
        {
            //Gets the pressed keys
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            //Loops through the pressed keys and if it is in the dictionary execute its given command
            foreach (Keys key in pressedKeys)
            {
                if (commandDictionary.ContainsKey(key))
                {
                    commandDictionary[key].Execute();
                }
            }
        }
    }
}
