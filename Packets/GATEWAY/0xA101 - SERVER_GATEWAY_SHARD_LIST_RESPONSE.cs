//GlobalOperations
while(true)
{
    1   bool    hasEntries
    if(!hasEntries) 
        break;

        //srGlobalOperation.ini
    1   byte    operation.ID 
    2   ushort  operation.Name.Length
    *   string  operation.Name 
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
    1   byte    shard.Operation.ID  
}