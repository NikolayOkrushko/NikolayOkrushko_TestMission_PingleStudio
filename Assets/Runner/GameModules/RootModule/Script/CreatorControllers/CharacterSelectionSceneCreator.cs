﻿/*
    creating controllers for CharacterSelection scene.
*/
using System;
using System.Collections.Generic;

namespace PingleStudio.Runner.GameModule.RootModule.ControllerCreators
{
    public class CharacterSelectionSceneCreator : IControllerCreator
    {
        public Dictionary<Type, object> Execute()
        {
            return CreateNeededControllers();
        }


        private Dictionary<System.Type, object> CreateNeededControllers()
        {
            var moduleControllers = new Dictionary<System.Type, object>();
            //ARModule.IARController ARController = new ARModule.ARController();
            //ARController.Init(ARModule.TrackingMode.Normal);
            //moduleControllers.Add(typeof(ARModule.IARController), ARController);

            return moduleControllers;
        }
    }
}
