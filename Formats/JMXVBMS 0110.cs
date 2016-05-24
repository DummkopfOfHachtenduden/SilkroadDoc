12  string  Header
4   uint    pointer.Verticies
4   uint    pointer.Bones
4   uint    pointer.Faces
4   uint    pointer.Unknown3
4   uint    pointer.Unknown4
4   uint    pointer.BoundingBox
4   uint    pointer.Gates
4   uint    pointer.Collision                           //0 when not used (characters, items, etc..)
4   uint    pointer.Unknown8                            //0 in every file :/
4   uint    pointer.Unknown9                            

4   uint    flags.unkUInt0                                        
4   uint    flags.unkUInt1                              //Indicates special collision
4   uint    flags.unkUInt2
4   uint    flags.Lightmap                              //0 = None
4   uint    flags.unkUInt3

4   uint    Name.Length
*   string  Name
4   uint    Material.Length
*   string  Material
4   uint    unkUInt4

//PointerVertices will get you here
4   uint vertexCount
for (int index = 0; index < vertexCount; index++)
{
    12  Vector3 vertex
    12  Vector3 normal
    8   Vector2 textureCoordinate    
    if(Lightmap > 0)
    {
        8   Vector2 lightmapCoordinate
    }    

    //Related to bones, need to look into it.
    4   float   unkVectorFloat0
    4   uint    unkVectorUInt0
    4   uint    unkVectorUInt1
}
if(Lightmap > 0)
{
    4   uint    LightmapPath.Length
    *   string  LightmapPath
}

//PointerBones will get you here
4   uint    boneCount
for (int boneIndex = 0; boneIndex < boneCount; boneIndex++)
{
    4   uint    BoneName.Length
    *   string  BoneName
}

if(boneCount > 0)
{
    for (int index = 0; index < vertexCount; index++)
    {
        1   byte    boneIndex1                              //Index of BoneName
        2   ushort  boneWeight1                             //Used to weight the two transformation matricies
        1   byte    boneIndex2                              //Index of BoneName
        2   ushort  boneWeight2                             //Used to weight the two transformation matricies
    }
}

//PointerFaces will get you here
4   uint    faceCount
for (int i = 0; i < faceCount; i++)
{
    2   ushort  face.A
    2   ushort  face.B
    2   ushort  face.C
}

//PointerUnk3 will get you here
4   uint    unk3Count                   //equal to vertexCount
for (int i = 0; i < unk3Count; i++)
{
    4   float   unkFloat0               //default: 0
    4   uint    unkUInt5                //default: 1; 0 if unkFloat > 0    
}

//PointerUnk4 will get you here
4   uint    unk4Count                   //equal to vertexCount
for (int i = 0; i < unk4Count; i++)
{
    4   uint    unkUInt6                //index from vertexList
    4   uint    unkUInt7                //index from vertexList      
    4   float   unkFloat1    
}
for (int i = 0; i < unk4Count; i++)
{
    4   uint    unkUInt8                //index from vertexList
}
if(unk4Count > 0)
{
    4   uint    unkUInt9                //0 or 1
    4   float   unkFloat2
    4   float   unkFloat3
    4   float   unkFloat4
    4   float   unkFloat5
    4   float   unkFloat6
    4   float   unkFloat7
    4   float   unkFloat8
    4   uint    unkUInt10               //index from vertexList
}

//PointerBoundingBox will get you here
24  float[]  AxisAlignedBoundingBox

//PointerGates will get you here
4   uint    gateCount
for (int i = 0; i < unk6Count; i++)
{
    4   uint    gateName.Length
    *   string  gateName
    4   uint    gateVertexCount
    for (int ii = 0; ii < gatePointCount; ii++)
    {
        12  Vector3 gateVertex
    }

    4   uint    gateFaceCount
    for (int ii = 0; ii < gateLineCount; ii++)
    {
        2   ushort  face.A
        2   ushort  face.B
        2   ushort  face.C
    }
}

//PointerUnk9 will get you here
4   uint    unk9Count                   //0 in every file :/

//PointerCollision will get you here
if(PointerCollision > 0)
{
    4   uint    collisionVertexCount
    for (int i = 0; i < collisionVertexCount; i++)
    {
        12  Vector3 collisionVertex
        1   byte    unkByte0
    }

    //ObjectGround
    4   uint    collisionCellCount
    for (int i = 0; i < objectGroundCount; i++)
    {
        2   ushort  cell.A
        2   ushort  cell.B
        2   ushort  cell.C
        2   ushort  unkUShort0
        if(unkUInt1 == 6 || unkUInt1 == 7 || unkUInt1 == 14)
        {
            1   byte    unkByte1
        }
    }

    //ObjectOutlines
    4   uint    outlineLinkCount
    for (int i = 0; i < outlineLinkCount; i++)
    {
        2   ushort  vertexSource
        2   ushort  vertexDestination
        2   ushort  cellSource                          //Index of neighbour triangle A --> ObjectGround
        2   ushort  cellDestination                     //Index of neighbour triangle B --> ObjectGround --> FFFF --> no neighbour triangle
        1   byte    collisionFlag
        if(unkUInt1 == 5 || unkUInt1 == 7)        
        {
            1   byte    unkByte2
        }
    }

    //ObjectInlines
    4   uint    inlineLinkCount
    for (int i = 0; i < inlineLinkCount; i++)
    {
        2   ushort  vertexSource
        2   ushort  vertexDestination
        2   ushort  cellSource                          //Index of neighbour triangle A --> ObjectGround
        2   ushort  cellDestination                     //Index of neighbour triangle B --> ObjectGround --> FFFF --> no neighbour triangle
        1   byte    collisionFlag
        if(unkUInt1 == 5 || unkUInt1 == 7)        
        {
            1   byte    unkByte2
        }
    }

    if(unkUInt1 == 4 ||
       unkUInt1 == 5 ||
       unkUInt1 == 6 || 
       unkUInt1 == 7 ||
       unkUInt1 == 14)
    {
        4   uint    eventCount
        for (int i = 0; i < eventCount; i++)
        {
            4   uint    eventName.Length
            *   string  eventName            
        }
    }

    4   float   unkFloat9
    4   float   unkFloat10
    4   uint    unkUInt11
    4   uint    unkUInt12    
    4   uint    unkCount0
    for (int i = 0; i < unkCount0; i++)
    {
        4   uint    unkCount1
        for (int ii = 0; ii < unkCount1; ii++)
        {
            2   ushort  unkUShort1
        }
    }
}

//EOF