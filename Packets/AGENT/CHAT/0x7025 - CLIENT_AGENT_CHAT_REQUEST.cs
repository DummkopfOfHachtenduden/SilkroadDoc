1   byte    chatType
1   byte    chatIndex
if(chatType == ChatType.PM)
{
    2   ushort  reciver.Length
    *   string  reciver
}
2   ushort  message.Length
*   string  message