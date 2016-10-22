1   byte    itemCount
foreach(item)
{
    4   uint    PersonalID
    4   uint    RefItemID
    1   byte    SaleStatus  //0xFF which is a valid status crashes client due to invalid implementation.
    4   uint    EndDate //epoch
}