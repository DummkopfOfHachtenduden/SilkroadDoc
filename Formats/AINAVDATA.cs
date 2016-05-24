1   byte    Version
4   uint    PointerPoints

//Connected point list of some sort...
2   ushort  RegionID
4   uint    roomCount
for (int i = 0; i < roomCount; i++)
{
    4   uint    RoomIndex       //related to DungeonObj 
    4   uint    unkUInt0        //some kind of connection count per point
    4   uint    unkUInt1        //identical to points within a group
    //...
}

//PointerPoints will get you here
2   ushort  RegionID                
4   uint    roomCount
for (uint i = 0; i < roomCount; i++)
{
    4   uint    pointCount
    for (uint i = 0; i < roomCount; i++)
    {
        12  Vector3 Point
    }
}

4   uint    unkUInt3        //Has been 0 in every file.