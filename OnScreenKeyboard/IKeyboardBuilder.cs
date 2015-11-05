﻿using System.Xml.Linq;

namespace OnScreenKeyboard
{
    internal interface IKeyboardBuilder
    {
        void Build(XDocument definition, Keyboard keyboard);
    }
}