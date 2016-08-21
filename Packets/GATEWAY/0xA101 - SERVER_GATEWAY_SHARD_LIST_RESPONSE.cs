//Farm
while(true)
{
    1   bool    hasEntries
    if(!hasEntries) 
        break;

    1   byte    farm.ID 
    2   ushort  farm.Name.Length
    *   string  farm.Name 
}

//Shards
while(true)
{
    1   bool    hasEntries
    if(!hasEntries) 
        break;

    2   ushort  shard.ID
    2   ushort  shard.Name.Length
    *   string  shard.Name
    2   ushort  shard.OnlineCount
    2   ushort  shard.Capacity
    1   bool    shard.IsOperating
    1   byte    shard.FarmID
}