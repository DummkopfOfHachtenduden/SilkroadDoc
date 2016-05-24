12  byte[]  Header                      // JMXVRES 0109
4   uint    pointer.Material
4   uint    pointer.Mesh
4   uint    pointer.Skeleton
4   uint    pointer.Animation
4   uint    pointer.MeshGroup
4   uint    pointer.AnimationGroup
4   uint    pointer.SoundEffect
4   uint    pointer.BoundingBox

4   uint    flags.unkUInt0
4   uint    flags.unkUInt1
4   uint    flags.unkUInt2
4   uint    flags.unkUInt3
4   uint    flags.unkUInt4

4   uint    Type                        //see ResourceType.cs
4   uint    Name.Length
*   string  Name

48  byte[]  unkBuffer

//pointer.BoundingBox will get you here
4   uint    rootMesh.Length
*   string  rootMesh
24  float[] BoundingBox0
24  float[] BoundingBox1
4   uint    hasExtraBoundingData
if(hasExtraBoundingBox)
{
    //This was only found in old models, might be obsolete.
    //Mangyang, Mangyang_Champ, some characters, some spiders and bonelord. 
    64  byte[] extraBoundingData
}

//pointer.Material will get you here
4   uint    materialSetCount            //MATERIALSET_MAXCOUNTMAX = 5
for (int materialSetIndex = 0; materialSetIndex < materialSetCount; materialSetIndex++)
{
    4   uint    materialID              //iMtrlID (basicly like materialSetIndex)
    4   uint    materialPath.Length
    4   uint    materialPath
}

//pointer.Mesh will get you here
4   uint    meshCount
for (int meshIndex = 0; meshIndex < meshCount; meshIndex++)
{       
    4   uint    meshPath.Length
    4   uint    meshPath
    if(flags.unkUInt0 == 1)
    {
        4   uint    meshUnkUInt0
    }
}

//pointer.Animation will get you here
4   uint    unkUInt5                //4096
4   uint    unkUInt6                //0
4   uint    animationCount
for (int animationIndex = 0; animationIndex < animationCount; animationIndex++)
{       
    4   uint    animationPath.Length
    4   uint    animationPath
}

//pointer.Skeleton will get you here
4   uint    skeletonCount
for (int skeletonIndex = 0; skeletonIndex < skeletonCount; skeletonIndex++)
{       
    4   uint    skeletonPath.Length
    4   uint    skeletonPath
    4   uint    extraByteCount
    *   byte[]  skeletonExtraBytes
}

//pointer.MeshGroup will get you here
4   uint    meshGroupCount
for (int i = 0; i < meshGroupCount; i++)
{       
    4   uint    meshGroupName.Length
    4   uint    meshGroupName
    4   uint    meshFileCount
    for (int ii = 0; ii < meshFileCount; ii++)
    {
        4   uint    meshFileIndex
    }
}

//pointer.AnimationGroup will get you here
4   uint    animationGroupCount
for (int i = 0; i < animationGroupCount; i++)
{       
    4   uint    groupName.Length
    4   uint    groupName

    4   uint    animationCount
    for (int ii = 0; ii < entryCount; ii++)
    {
        4   uint    animation.Type          //see ResourceAnimationType
        4   uint    animation.FileIndex

        4   uint    eventCount
        for (int iii = 0; iii < eventCount; iii++)
        {
            4   uint    event.KeyTime
            4   uint    event.Type
            4   uint    event.unkValue0            
            4   uint    event.unkValue1
        }

        4   uint    walkGraphPointCount
        4   float   animation.WalkLength
        for (int iiii = 0; iiii < eventCount; iiii++)
        {
            8   Vector2 walkGraphPoint
        }
    }
}

//pointer.SoundEffect
//8 bytes remaining
//EOF