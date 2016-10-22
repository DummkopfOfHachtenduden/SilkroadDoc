1   byte    result
if(result == 1)
{
    1   byte    entryCount
    1   byte    pageCount
    foreach(entry)
    {
        4   uint    PersonalID
        2   ushort  Seller.Length
        *   string  Seller
        1   byte    SaleStatus
        4   uint    RefItemID
        4   uint    SellCnt
        8   ulong   Price
        4   uint    RegDate //epoch
    }
}
else if(result == 2)
{
    2   ushort  errorCode
}