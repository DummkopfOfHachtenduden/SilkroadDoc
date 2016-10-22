1   byte    itemCount   //Maximum of 8 registations possible per request
foreach(item)
{
    1   byte    item.SourceSlot
    4   uint    SellCnt
    4   uint    item.RefItemID
    4   uint    item.TidGroupID
    8   ulong   Price
}