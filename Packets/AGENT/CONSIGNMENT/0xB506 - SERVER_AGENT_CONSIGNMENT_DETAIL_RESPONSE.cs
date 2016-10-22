1   byte    result
if(result == 1)
{
    1   byte    DetailType
    2   ushort  Seller.Length
    *   string  Seller
    4   uint    PersonalID
    *   object  item.<genericItemData>
}
else if(result == 2)
{
    2   ushort  errorCode
}