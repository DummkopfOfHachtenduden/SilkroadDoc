12  char[]  Header                              //JMXVBMT 0102
4   uint    entryCount
for(int i = 0; i < entryCount; i++)
{
    4   uint    entry.Name.Length
    *   string  entry.Name    
    16  Color4  entry.Diffuse                   // | This needs reversing because I can't reproduce this shitty materials in blender.
    16  Color4  entry.Ambient                   // | Some of these might switcharoo
    16  Color4  entry.Specular                  // | so I ordered them like D3D9Material and
    16  Color4  entry.Emissive                  // | wavefont objs have them ordererd.
    4   uint    entry.unkFloat16                //Specular Power?   (ranging from ~0.8 to ~189)
    4   uint    entry.unkUInt1                  //MaterialEntryFlags (64 is default often used with 256 and/or 512 only a few exceptions have 1 2 4 8...)
    4   uint    entry.DiffuseMap.Length
    *   string  entry.DiffuseMap
    4   float   entry.unkFloat17                //1.0 in all files
    2   ushort  entry.unkUShort0                //0, 24 or 2080
    1   bool    entry.IsNotWithinSameDirectory  //indicates whether or not the DiffuseMap is within the same directory as the material set.
}