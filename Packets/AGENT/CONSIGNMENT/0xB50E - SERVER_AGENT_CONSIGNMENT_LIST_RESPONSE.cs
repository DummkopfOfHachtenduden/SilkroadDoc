1   byte    result
if(result == 1)
{
    1   byte    itemCount
    foreach(item)
    {
        4   uint    PersonalID
        1   byte    SaleStatus
        4   uint    RefItemID
        4   uint    SellCnt
        8   ulong   Price
        8   ulong   Deposit
        8   ulong   SellFee
        4   uint    EndDate //epoch
    }
}
else if(result == 2)
{
    2   ushort  errorCode
}