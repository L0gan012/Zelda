using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2.Command;
using System.Collections.Generic;

namespace Sprint2.Controller
{
    class KeyboardController : IController
    {
        //Instance variables
        private Dictionary<Keys, ICommand> commandDictionary;
        private ICommand idle;
        private Game1 game;

        //Constructor with game instance parameter
        public KeyboardController(Game1 game)
        {
            commandDictionary = new Dictionary<Keys, ICommand>();
            this.game = game;
        }

        /// <summary>
        /// Registers commands for corresponding command
        /// </summary>
        public void RegisterCommand()
        {
            //quit and reset commands
            commandDictionary.Add(Keys.Q, new ExitCommand(game));


            //directional commands, arrow keys
            commandDictionary.Add(Keys.Up, new MoveUpCommand(game));
            commandDictionary.Add(Keys.Down, new MoveDownCommand(game));
            commandDictionary.Add(Keys.Left, new MoveLeftCommand(game));
            commandDictionary.Add(Keys.Right, new MoveRightCommand(game));

            //wasd keys
            commandDictionary.Add(Keys.W, new MoveUpCommand(game));
            commandDictionary.Add(Keys.S, new MoveDownCommand(game));
            commandDictionary.Add(Keys.A, new MoveLeftCommand(game));
            commandDictionary.Add(Keys.D, new MoveRightCommand(game));

            //attack commands
            commandDictionary.Add(Keys.Z, new AttackCommand(game));
            commandDictionary.Add(Keys.N, new AttackCommand(game));

            //item commands
            commandDictionary.Add(Keys.I, new ItemFowardCommand(game));
            commandDictionary.Add(Keys.U, new ItemBackCommand(game));

            //enemy and npc commands
            commandDictionary.Add(Keys.O, new EnemyFowardCommand(game));
            commandDictionary.Add(Keys.P, new EnemyBackCommand(game));

            //block commands
            commandDictionary.Add(Keys.T, new BlockBackCommand(game));
            commandDictionary.Add(Keys.Y, new BlockFowardCommand(game));

            this.idle = new SetIdleCommand(game);
        }

        /// <summary>
        /// Executes a command based on keyboard presses
        /// </summary>
        public void Update()
        {
            //Gets the pressed keys
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();


            //if nothing is pressed, set player to be in an idle state
            if (pressedKeys.Length == 0)
            {
                idle.Execute();
            }
            else
            {
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
}
