1   byte    action
if(action == CharacterSelectionAction.Create)
{
    2   ushort  Name.Length
    *   string  Name
    4   uint    RefObjID
    1   byte    Scale
    4   uint    RefItemID // EQUIP_SLOT_MAIL
    4   uint    RefItemID // EQUIP_SLOT_PANTS
    4   uint    RefItemID // EQUIP_SLOT_BOOTS
    4   uint    RefItemID // EQUIP_SLOT_WEAPON
}
else if(action == CharacterSelectionAction.Delete || 
        action == CharacterSelectionAction.CheckName || 
        action == CharacterSelectionAction.Restore)
{
    2   ushort  Name.Length
    *   string  Name
}