1   byte    result
1   byte    updateType
if(updateType == StallUpdateType.UpdateItem)
{
    1   byte    Slot    //within Stall (0-9)
    2   ushort  StackCount
    8   ulong   Price
    2   ushort  errorCode
}
else if(updateType == StallUpdateType.AddItem || StallUpdateType.RemoveItem)
{
    2   ushort  errorCode
    
    while(true)
    {
        1   byte    registeredItem.Slot   //within Stall (0-9)
        if(registeredItem.Slot == byte.MaxValue)
            break;

        *   byte[]  registeredItem.<genericItemData> //depends on TypeIDs
        1   byte    registeredItem.SourceSlot //from OwnerInventory
        2   ushort  registeredItem.StackCount //sale stack count
        8   ulong   registeredItem.Price //sale price
    }
}
else if(updateType == StallUpdateType.FMarketRelated)
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
    //via 0x30BB - SERVER_AGENT_ENTITY_UPDATE_STALL_NAME
}