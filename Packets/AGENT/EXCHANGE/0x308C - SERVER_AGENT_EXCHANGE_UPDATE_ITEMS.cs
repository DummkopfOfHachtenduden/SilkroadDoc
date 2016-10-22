4   uint    uniqueID    //of list owner
1   byte    itemCount
foreach(item)
{
    1   byte    item.SourceSlot //from inventory
    1   byte    item.ExchangeSlot   //0-11 in exchange window
    *   object  item.<genericItemData>    
}