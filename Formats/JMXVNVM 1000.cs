    2   ushort  EventZoneFlag   //0 = No, 256 = collision works when your character has CTF suit (red/blue ones)12  char[]  Header          //JMXVNVM 1000

//NavigationEntries
2   ushort    entryCount
for (int entryIndex = 0; entryIndex < entryCount; entryIndex++)
{
    4   uint    ID
    12  Vector3 Position
    2   ushort  CollisionFlag   //0x00 = No, 0xFFFF = Yes
    4   float   Yaw 
    2   ushort  UniqueID
    2   ushort  unkUShort0      //
    2   ushort  EventZoneFlag   //0 = No, 256 = collision works when your character has CTF suit (red/blue ones)
    2   ushort  RegionID
    2   ushort  mountPointCount
    for (int i = 0; i < mountPointCount; i++)
    {   
        6   byte[]  mountPointData      //where you can enter the object (bridges etc..)
    }
}

//NavigationCells
4   uint    cellCount
4   uint    cellExtraCount
for (int cellIndex= 0; cellIndex< cellCount; cellIndex++)
{
    8   Vector2 Min
    8   Vector2 Max 

    1   byte    entryCount
    for (int i = 0; i < entryCount; i++)
    {
        2   ushort  entryIndex
    }
}

//NavigationRegionLinks
4   uint    regionLinkCount
for (int linkIndex = 0; linkIndex < regionLinkCount; linkIndex++)
{
    8   Vector2 Min
    8   Vector2 Max 

    1   byte    LineFlag
    1   byte    LineSource
    1   byte    LineDestination

    2   ushort  CellSource
    2   ushort  CellDestination

    2   ushort  RegionSource
    2   ushort  RegionDestination
}

//NavigationCellLinks
4   uint    cellLinkCount
for (int linkIndex = 0; linkIndex < cellLinkCount; linkIndex++)
{
    8   Vector2 Min
    8   Vector2 Max 

    1   byte    LineFlag
    1   byte    LineSource
    1   byte    LineDestination

    2   ushort  CellSource
    2   ushort  CellDestination
}

//TextureMap
for (int x = 0; x < 96; x++)
{
    for (int y = 0; y < 96; y++)
    {
        2   ushort  w1
        2   ushort  w2
        2   ushort  w3
        2   ushort  w4      //TextureID
    }
}

//HeightMap
for (int i = 0; i < 97 * 97; i++)
{
    4   float   Height
}
