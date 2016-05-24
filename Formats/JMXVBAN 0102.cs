12  string  Header      //JMXVBAN 0102
4   uint    unkUInt0    //Introduced in JMXVBAN 0102, 0 in all files
4   uint    unkUInt1    //Introduced in JMXVBAN 0102, 0 in all files
4   uint    Name.Length
*   string  Name
4   uint    Duration
4   uint    FramesPerSecond
4   uint    IsContinuous

//Timings of the keyframes, so you can interpolate between two poses.
4   uint    keyframeTimeCount
foreach(keyframeTime)
{
    4   uint    keyframeTime
}

//Amount of bones that have transformations, that are diffrent from their bind poses.
4   uint    animatedBoneCount
foreach(animatedBone)
{
    4   uint    BoneName.Length
    *   string  BoneName    
    4   uint    keyframeCount
    foreach(keyframe)
    {
        //These two together give you the transformation Matrix relative to it's partent bone/joint.
        16  Quaternion  Rotation
        12  Vector3     Translation
    }
}
//EOF