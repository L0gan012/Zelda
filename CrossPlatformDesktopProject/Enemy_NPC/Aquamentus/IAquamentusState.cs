using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Enemy_NPC
{
    public interface IAquamentusState :IEnemy
    {

        void MouthOpen();
        void MouthClose();
        void UseProjectile();

    }
}
