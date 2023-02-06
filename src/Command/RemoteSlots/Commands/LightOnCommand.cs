﻿using RemoteSlots.Receivers;

namespace RemoteSlots.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _light.On();
        }
    }
}
