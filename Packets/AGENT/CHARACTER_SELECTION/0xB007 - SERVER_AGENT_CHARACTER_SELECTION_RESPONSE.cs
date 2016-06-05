1   byte    action
1   byte    result
if(result == 0x01 && type == CharacterSelectionAction.List)
{
    1   byte    characterCount
    foreach(character)
    {
        4   uint    character.RefObjID
        2   ushort  character.Name.Length
        *   string  character.Name
        1   byte    character.Scale
        1   byte    character.CurLevel
        8   ulong   character.ExpOffset
        2   ushort  character.Strength
        2   ushort  character.Intelligence
        2   ushort  character.StatPoint
        4   uint    character.CurHP 
        4   uint    character.CurMP
        1   bool    isDeleting
        if(isDeleting)
        {
            4   uint    character.DeleteTime    //in Minutes
        }

        1   byte    guildMemberClass
        1   bool    isGuildRenameRequired
        if(isGuildRenameRequired)
        {
            2   ushort  CurGuildName.Length
            *   string  CurGuildName
        }       
        1   byte    academyMemberClass

        1   byte    itemCount
        foreach(item)
        {
            4   uint    item.RefItemID
            1   byte    item.Plus
        }

        1   byte    avatarItemCount
        foreach(avatarItem)
        {
            4   uint    avatarItem.RefItemID
            1   byte    avatarItem.Plus
        }
    }
}
else if(result == 0x02)
{
    2   ushort  errorCode
}