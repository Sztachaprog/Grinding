using System;

namespace SavingInterface
{
    interface IDisplayable
    {
        string HeaderSymbol { get; }
        void Display();
    }

}