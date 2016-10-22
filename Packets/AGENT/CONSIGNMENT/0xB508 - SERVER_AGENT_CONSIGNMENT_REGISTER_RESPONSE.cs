1   byte    result
if(result == 1)
{
    1   byte    itemCount
    foreach(item)
    {
        1   byte    item.SourceSlot
        1   byte    SaleStatus
        4   uint    PersonalID
        4   uint    item.RefItemID
        8   ulong   Deposit
        8   ulong   SellFee
        4   uint    EndDate //epoch
    }
}
else if(result == 2)
{
    2   ushort  errorCode
}