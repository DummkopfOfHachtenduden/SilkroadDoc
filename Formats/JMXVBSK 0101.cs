12  string  Header
4   uint    BoneCount
for (int boneIndex = 0; boneIndex < boneCount; boneIndex++)
{
    if(boneIndex > 0)
    {
        4   uint    relatedBoneCount                        //Number of bones with same parent bone. Bone itself included
        for (int ii = 0; ii < relatedBoneCount; ii++)
        {
            2   ushort  relatedBone.Name.Length
            *   string  relatedBone.Name
        }        
    }    

    1   byte    unkByte0
    2   ushort  Bone.Name.Length    
    *   string  Bone.Name
    2   ushort  ParentBone.Name.Length
    *   string  ParentBone.Name

    //Vector4
    4   float   rotationToParent.X
    4   float   rotationToParent.Y
    4   float   rotationToParent.Z
    4   float   rotationToParent.W

    //Vector3
    4   float   translationToParent.X
    4   float   translationToParent.Y
    4   float   translationToParent.Z

    //Vector4
    4   float   rotationToOrigin.X
    4   float   rotationToOrigin.Y
    4   float   rotationToOrigin.Z
    4   float   rotationToOrigin.W

    //Vector3
    4   float   translationToOrigin.X
    4   float   translationToOrigin.Y
    4   float   translationToOrigin.Z

    //Vector4
    4   float   unkRotation0.X
    4   float   unkRotation0.Y
    4   float   unkRotation0.Z
    4   float   unkRotation0.W

    //Vector3
    4   float   unkTranslation0.X
    4   float   unkTranslation0.Y
    4   float   unkTranslation0.Z
}

4   uint    unkUInt0
4   uint    unkUInt1
4   uint    unkUInt2