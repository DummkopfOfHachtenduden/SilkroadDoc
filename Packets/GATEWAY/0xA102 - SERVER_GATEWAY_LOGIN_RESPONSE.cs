1   byte    result
if(result == 0x01)
{
    4   uint    AgentServer.Token
    2   ushort  AgentServer.IP.Length
    *   string  AgentServer.IP
    2   ushort  AgentServer.Port
}
else if(result == 0x02)
{
    1   byte    errorCode
    if(errorCode == 0x01)
    {
        4   uint    MaxAttempts
        4   uint    CurAttempts
    }
    else if(errorCode == 0x02)
    {
        1   byte    blockType
        if(blockType == BlockType.Punishment)
        {
            2   ushort  punishment.Reason.Length
            *   string  punishment.Reason
            2   ushort  punishment.EndDate.Year
            2   ushort  punishment.EndDate.Month
            2   ushort  punishment.EndDate.Day
            2   ushort  punishment.EndDate.Hour
            2   ushort  punishment.EndDate.Minute
            2   ushort  punishment.EndDate.Second
            2   ushort  punishment.EndDate.Microsecond
        }
    }
}
else if(result == 0x03) //Custom Message as A102 result, not supported by every client.
{
    //I've not looked into this yet.
    1   byte    unkByte0
    1   byte    unkByte1
    2   ushort  Message.Length
    *   string  Message
    2   ushort  unkUShort0
}