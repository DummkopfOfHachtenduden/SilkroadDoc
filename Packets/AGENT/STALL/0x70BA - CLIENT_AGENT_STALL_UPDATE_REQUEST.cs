1   byte    updateType
if(updateType == StallUpdateType.UpdateItem)
{
    1   byte    Slot    //within Stall (0-9)
    2   ushort  StackCount
    8   ulong   Price
    2   ushort  unkUShort0
}
else if(updateType == StallUpdateType.AddItem)
{
    1   byte    Slot    //within Stall (0-9)
    1   byte    SourceSlot //from ownerInventory
    2   ushort  StackCount
    8   ulong   Price
    4   uint    FleaMarketNetworkTidGroup
    2   ushort  unkUShort0
}
else if(updateType == StallUpdateType.RemoveItem)
{
    1   byte    Slot    //within Stall (0-9)
    2   ushort  unkUShort0
}
else if(updateType == StallUpdateType.FleaMarketMode)
{
    1   byte    fleaMarketMode  //no noticable effects 1 and 2 responded with success, everything > 3 with errorCode 0x3C2B
}
else if(updateType == StallUpdateType.State)
{
    1   bool    IsOpen
    2   ushort  stallNetworkResult //01 00 = Registering of stall items at stall network is successful
}
else if(updateType == StallUpdateType.Message)
{
    2   ushort  Message.Length
    *   string  Message
}
else if(updateType == StallUpdateType.Name)
{
    2   ushort  Name.Length
    *   string  Name
}