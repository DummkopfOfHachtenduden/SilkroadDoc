12  byte[]  Header                                         //JMXVDOF 0101 supported only
4   uint    pointerRoomObjects
4   uint    pointerObjectConnections
4   uint    pointerLinks
4   uint    pointerObjectGroups
4   uint    pointerIndexNames
4   uint    pointerUnk5                                    // Has been 0 in every file...
4   uint    pointerUnk6                                    // Has been 0 in every file...
4   uint    pointerDungeonBoundingBoxes                    
2   ushort  unk_ushort0                                    // Has been 0xFFFF in every file...
2   ushort  unk_ushort1                                    // Has been 0x0400 in every file...
2   ushort  dungeonNameLength                              
*   string  dungeonName                                    // Has been "Noname" in every file... -> used as projectName in MapEditor.
4   uint    unk_uint0                                      // Has been 0xFFFFFFFF in every file...
4   uint    unk_uint1                                      // Has been 0xFFFFFFFF in every file...
2   ushort  regionID                                       // Used in packets and database for whole Dungeon. Used in minimap_d as center- or origin-region (stores _default_).

//pointerDungeonBoundingBoxes will get you here                       
24  float[]  dungeon_AABB                                  // width = AABB[3] - AABB[0], height = AABB[4] - AABB[1], length = AABB[5] - AABB[2]
24  float[]  dungeon_OOBB                                  // width = OOBB[3] - OOBB[0], height = OOBB[4] - OOBB[1], length = OOBB[5] - OOBB[2]

//pointerRoomObjects will get you here
4   uint    roomObjectCounter
for (int roomObjectIndex = 0; roomObjectIndex < roomObjectCounter; roomObjectIndex++)
{
    2   ushort  roomObject.PathLength
    *   string  roomObject.Path    

    2   ushort  roomObject.NameLength
    *   string  roomObject.Name

    4   float   roomObject.unk_floot0                      // Has been 0 in every file...
    4   float   roomObject.X
    4   float   roomObject.Z
    4   float   roomObject.Y
    4   float   roomObject.YAW                             // Google it... and use this: 57.2957795 for calculation
    4   float   roomObject.PITCH                           // Google it... and don't ask for missing roll, this is no flight simulator...
    24  float[] roomObject.AABB                            // width = aabb[3] - aabb[0], height= aabb[4] - aabb[1], length = aabb[5] - aabb[2]
    4   float   roomObject.unk_float12                     // Seems fixed to -2,848866E+38    
    4   float   roomObject.unk_float13                     // Seems fixed to -2,288091E+38
    4   float   roomObject.unk_float14                     // Example: -150
    4   float   roomObject.unk_float15                     // Example: 1456
    4   float   roomObject.unk_float16                     // Example: 0,001

    1   byte    roomObject.extraFlagA                       
    if(roomObject.extraFlagA == 0x01)
    {
        4   float   roomObject.ExtraA.unk_float0           // Example: 750
        4   float   roomObject.ExtraA.unk_float1           // Example: 680
        4   float   roomObject.ExtraA.unk_float2           // Example: 50
        4   float   roomObject.ExtraA.unk_float3           // Example: 0,08        
    }

    1   byte roomObject.extraFlagB
    if(roomObject.extraFlagB == 0x02)
    {
        4   float   roomObject.ExtraB.unk_float0           // Example: 0,1871207
        4   float   roomObject.ExtraB.unk_float1           // Example: 0
        4   float   roomObject.ExtraB.unk_float2           // Example: -0,8803339
        4   float   roomObject.ExtraB.unk_float3           // Example: 0  
        4   float   roomObject.ExtraB.unk_float4           // Example: 2,932153
        4   float   roomObject.ExtraB.unk_float5           // Example: 0
        4   float   roomObject.ExtraB.unk_float6           // Example: 3,503246E-42        
    }

    4   uint    roomObject.unk_uint0                       // Has been 0 in every file...
    4   uint    roomObject.roomIndex                       // Used for roomNames   
    4   uint    roomObject.floorIndex                      // Used for floorNames

    4   uint    roomObject.connectedObjectCount            //List of directly-connected objects. Example: 70, 146
    for (int i = 0; i < roomObject.connectedObjectCount; i++)
    {
        4   uint    objectIndex
    }

    4   uint    roomObject.indirectConnectedObjectCount    //List of indirectly-connected objects. Example: 70, 4, 146, 80
        for (int i = 0; i < roomObject.indirectConnectedObjectCount; i++)
    {
        4   uint    objectIndex
    }

    4   uint    roomObject.entryCounter
    4   uint    roomObject.unk_uint1                        //Either 0 or 1
    for (int entryIndex = 0; entryIndex < roomObject.entryCounter; entryIndex++)
    {
        //Contains Flames, Stones, Jewelry, Water, and other stuff...        
        2   ushort  entry.NameLength
        *   string  entry.Name

        2   ushort  entry.PathLength
        *   string  entry.Path        

        4   float   entry.X
        4   float   entry.Z
        4   float   entry.Y     

        4   float   entry.Roll
        4   float   entry.Yaw
        4   float   entry.Pitch    

        4   float   entry.ScaleWidth
        4   float   entry.ScaleHeight
        4   float   entry.ScaleLength

        4   uint    entry.extraFlag                        // I've seen this as 0x00 for Flames (Torch & Lamps), 0x02 for Stones (impassable), 0x04 for Water
        if(entry.extraFlag == 0x04) //Water...
        {
            4   uint    waterExta
        }

        4   uint    entry.ID
        4   float   entry.unk_float0                         
        //1962.75232 for out_obj_stone
        //902.9495 for out_obj_door
        //-3.18711172E+38 and similar for water        
    }

    4   uint    roomObject.pointCounter
    for (int pointIndex = 0; pointIndex < roomObject.pointCounter; pointIndex++)
    {
        2   ushort  point.NameLength
        *   string  point.Name 

        4   float   point.X
        4   float   point.Z
        4   float   point.Y

        4   float   point.Roll
        4   float   point.Yaw
        4   float   point.Pitch

        4   float   point.Width
        4   float   point.Height
        4   float   point.Length

        4   float   point.float09                          // also Roll        
        4   float   point.float10                          // also Yaw
        4   float   point.float11                          // also Pitch
        4   float   point.float12                          // Example: 0,8
        4   float   point.float13                          // Example: 0,007
        4   float   point.float14                          // Example: 3E-05
    } 
}

//pointerLinks will get you here
4   uint    unk_uint2
4   uint    unk_uint3
4   uint    unk_uint4
4   uint    linkCounter
for (int linkIndex = 0; linkIndex < linkCounter; linkIndex++)
{
    4   uint    link.ID
    4   uint    link.connectionCount
    for (int i = 0; i < link.connectionCount; i++)
    {
        4   uint    objectIndex
    }
}

//pointerObjectConnections will get you here
4   uint    objectConnectionCounter                        //Always equal to roomObjectCounter?
for (int objectIndex = 0; objectIndex < objectConnectionCounter; objectIndex++)
{
    4   uint    connectedObjectCount
    for (int i = 0; i < connectedObjectCount; i++)
    {
        4   uint    connectedObjectIndex
    }
}

//pointerIndexNames will get you here
4   uint    roomCounter
for (int roomIndex = 0; roomIndex < roomCounter; roomIndex++)
{
    //Some of them might be empty but thats no problem...
    2   ushort  roomNameLength
    *   string  roomName
}
4   uint    floorCounter
for (int floorIndex = 0; floorIndex < roomCounter; floorIndex++)
{
    //Some of them might be empty but thats no problem...
    2   ushort  floorNameLength
    *   string  floorName
}

//pointerObjectGroups
4   uint    objectGroupCounter
for (int i = 0; i < objectGroupCounter; i++)
{
    2   ushort  group.NameLength
    *   string  group.Name
    4   uint    group.Flag                                 //0 or 1 -> Service?
    4   uint    group.objectCount
    for (int ii = 0; ii < group.objectCount; ii++)
    {
        4   uint    objectIndex
    }
}
//EOF