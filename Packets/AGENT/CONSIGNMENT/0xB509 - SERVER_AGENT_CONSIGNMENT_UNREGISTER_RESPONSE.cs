1   byte    result
if(result == 1)
{
    1   byte    itemCount
    foreach(item)
    {
        4   uint    PersonalID
        1   byte    item.Slot
        *   object  item.<genericItemData>
    }
}
else if(result == 2)
{
    2   ushort  errorCode
}