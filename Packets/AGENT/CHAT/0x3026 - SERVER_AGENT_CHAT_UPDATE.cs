1   byte    chatType
if(chatType == ChatType.All ||
   chatType == ChatType.AllGM ||
   chatType == ChatType.NPC)
{
    4   uint    message.Sender.UniqueID
}
else if(chatType == ChatType.PM ||
        chatType == ChatType.Party ||
        chatType == ChatType.Guild ||
        chatType == ChatType.Global ||
        chatType == ChatType.Stall ||
        chatType == ChatType.Union ||
        chatType == ChatType.Accademy)        
{
    2   ushort  message.Sender.Name.Length
    *   string  message.Sender.Name
}
2   ushort  message.Length
*   string  message