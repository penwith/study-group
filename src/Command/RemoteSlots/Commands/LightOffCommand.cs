﻿using RemoteSlots.Receivers;

namespace RemoteSlots.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _light.Off();
        }
    }
}
