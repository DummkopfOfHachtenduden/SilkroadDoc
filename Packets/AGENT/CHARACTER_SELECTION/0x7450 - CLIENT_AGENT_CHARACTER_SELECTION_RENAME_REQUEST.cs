1   byte    renameAction
if(renameAction == CharacterSelectionRenameAction.CharacterRename ||
   renameAction == CharacterSelectionRenameAction.GuildRename)
{
    2   ushort  curName.Length
    *   string  curName
    2   ushort  newName.Length
    *   string  newName
}
else if(renameAction == CharacterSelectionRenameAction.GuildNameCheck)
{
    2   ushort  Name.Length
    *   string  Name
}