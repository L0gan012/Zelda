using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    //Controller Interface
    public interface IController
    {
        //Updates the controller
        void Update();
        void RegisterCommand();
    }
}
