1   byte    result
if(result == 1)
{
    4   uint    UniqueID
    2   ushort  Message.Length
    *   string  Message
    1   bool    IsOpen
    1   byte    fleaMarketMode

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

    1   byte    peopleCount
    *   uint[]  peopleUniqueIDs
}
else
{
    2   ushort  errorCode
}