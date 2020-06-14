using System;
using System.Collections.Generic;

namespace PingleStudio.Runner.GameModule.RootModule.ControllerCreators
{
    public class GameSceneCreator : IControllerCreator
    {
        public Dictionary<Type, object> Execute()
        {
            return CreateNeededControllers();
        }

        private Dictionary<System.Type, object> CreateNeededControllers()
        {
            var moduleControllers = new Dictionary<System.Type, object>();

            // IEnvironmentController EnvironmentController = new EnvironmentController();
            // moduleControllers.Add(typeof(IEnvironmentController), EnvironmentController);
            // EnvironmentController.Init();
            
            return moduleControllers;
        }
    }
}
