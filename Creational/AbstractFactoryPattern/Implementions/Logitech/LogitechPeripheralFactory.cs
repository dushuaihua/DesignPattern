﻿using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Implementions;

public class LogitechPeripheralFactory : IPeripheralFactory
{
    public Keyboard CreateKeyboard()
    {
        return new LogitechKeyboard();
    }

    public Mouse CreateMouse()
    {
        return new LogitechMouse();
    }
}
