1   byte    ContentID
1   byte    DivisionCount
foreach(Division)
{
    4   uint    Division.Name.Length
    *   string  Division.Name
    1   byte    nullTerminator  //0
    
    1   byte    Division.GatewayCount
    foreach(Gateway)
    {
        4   uint    IP.Length
        *   string  IP
        1   byte    nullTerminator  //0
    }
}