1   byte    stallAction
if(stallAction == StallAction.Leave || stallAction == StallAction.Enter)
{
    4   uint    UniqueID
}
else if(stallAction == StallAction.Buy)
{
    1   byte    Slot    //within Stall (0-9)
    2   ushort  Name.Length
    *   string  Name
        
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