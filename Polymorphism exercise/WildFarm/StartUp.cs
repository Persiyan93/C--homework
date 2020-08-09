using System;
using WildFarm.COre;
using WildFarm.COre.Contracts;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Iengine engine = new Engine();
            engine.Run();
        }
    }
}
