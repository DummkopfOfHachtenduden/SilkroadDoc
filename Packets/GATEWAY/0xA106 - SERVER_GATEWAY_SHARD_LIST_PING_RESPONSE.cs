1   byte    result
if(result == 0x01)
{
    1   byte    Farm.ID
    4   uint    IPAddress //IPv4
}
else
{
    1   byte    errorCode
}