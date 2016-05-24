12  string  Header
4   uint    PointerCollisionResource
4   uint    PointerResourceList

4   uint    unkUInt0
4   uint    unkUInt1
4   uint    unkUInt2
4   uint    unkUInt3
4   uint    unkUInt4

4   uint    Type                                    //See ResourceTypes
4   uint    Name.Length
*   string  Name

4   uint    unkUInt5                                //3 when resources contain animation
4   uint    unkUInt6                                //2 when resources contain particles

//PointerCollisionResource will get you here
4   uint    collisionResourcePath.Length
*   string  collisionResourcePath

//PointerResourceList will get you here
4   uint    resourceCount
for (int resourceIndex = 0; resourceIndex < resourceCount; resourceIndex++)
{
    4   uint    resourcePath.Length
    *   string  resourcePath
}