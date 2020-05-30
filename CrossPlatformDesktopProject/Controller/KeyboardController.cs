using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2.Command;
using System.Collections.Generic;

namespace Sprint2.Controller
{
    class KeyboardController : IController
    {
        //Instance variables
        public Dictionary<Keys, ICommand> commandDictionary;
        public Game1 game;

        //Constructor with game instance parameter
        public KeyboardController(Game1 game)
        {
            commandDictionary = new Dictionary<Keys, ICommand>();
            this.game = game;
        }

        //Registers commands for corresponding command
        public void RegisterCommand()
        {
            commandDictionary.Add(Keys.Q, new ExitCommand(game));
            commandDictionary.Add(Keys.Up, new MoveUpCommand(game));
            commandDictionary.Add(Keys.E, new DamageCommand(game));
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
