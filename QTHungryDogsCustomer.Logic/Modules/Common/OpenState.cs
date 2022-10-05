﻿namespace QTHungryDogsCustomer.Logic.Modules.Common
{
    [Flags]
    public enum OpenState
    {
        NoDefinition = 0,
        Open = 1,                       // 0b0000_0001
        OpenNow = 2 * Open,             // 0b0000_0010
        IsBusy = 2 * OpenNow,           // 0b0000_0100
        Closed = 2 * IsBusy,            // 0b0000_1000
        ClosedNow = 2 * Closed,         // 0b0001_0000
        ClosedPermanent = 2 * ClosedNow,// 0b0010_0000

        ClosedState = Closed + ClosedNow + ClosedPermanent,             // 0b0011_1000
        OpenState = Open + OpenNow,                                     // 0b0000_0011
        SpecialState = OpenNow + IsBusy + ClosedPermanent + ClosedNow,  // 0b0011_0110
    }
}
