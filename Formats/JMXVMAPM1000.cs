12  char[]  Header      //JMXVMAPM1000

//Every MapMesh consists of 6 * 6 = 36 MapMeshBlocks
for (int xBlock = 0; xBlock < 6; xBlock++)
{
    for (int yBlock = 0; yBlock < 6; yBlock++)
    {
        6   char[]  Block.Name      //related to environment.ifo?

        //Every block contains 17 * 17 MapMeshCells
        for (int y = 0; y < 17; y++)
        {
            for (int x = 0; x < 17; x++)
            {
                4   float   Cell.Height
                2   ushort  Cell.Texture        //consists of 10-Bit TextureID & 6-Bit Flags (Blur, Shine, ...)
                1   byte    Cell.Brightness //lighting direction indicator?
            }
        }

        1   byte    Block.Density		//0x00 = Water, 0x01 = Ice, FF = Solid
        1   byte    Block.unkByte0      //related to Block.Density (see screens)
        4   float   Block.SeaLevel

        //This is unknown extra data for each cell, most of them where 0 and 6 or similar.
        for (int i = 0; i < 256; i++)
        {
            1   byte    Cell.ExtraMin
            1   byte    Cell.ExtraMax
        }

        4   float   Block.HeightMax
        4   float   Block.HeightMin
        20  byte[]  Block.unkBuffer0        
    }
}