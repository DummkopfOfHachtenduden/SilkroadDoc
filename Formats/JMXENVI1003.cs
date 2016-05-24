12  string  Header                                          //JMXVENVI1003
4   uint    EnvironmentCount
2   ushort  unkUShort0

for (int i = 0; i < EnvironmentCount; i++)
{
    2   ushort  Environment.ID
    4   uint    Environment.Name.Length
    *   string  Environment.Name
    4   uint    Environment.unkUInt0
    4   uint    Environment.unkUInt1

    for (int fncIndex = 0; fncIndex < 16; fncIndex++)
    {
        4   uint    graphPointCount
        for (int graphIndex = 0; graphIndex < graphPointCount; graphIndex++)
        {
            if (fncIndex == 7 ||
                fncIndex == 8 ||
                fncIndex == 10 ||
                fncIndex == 11 ||
                fncIndex == 12 ||
                fncIndex == 15)
            {
                4   float   value
                4   float   positionOnGraph                 //0.0 -> 1.0
            }
            else
            {
                4   float   value.X
                4   float   value.Y
                4   float   value.Z
                4   float   positionOnGraph                 //0.0 -> 1.0
            }            
        }
    }
}

4   uint    groupCount
for (int i = 0; i < groupCount; i++)
{
    4   uint    group.Name.Length
    *   string  group.Name
    2   ushort  unkUShort1
    2   ushort  unkUShort2
    2   ushort  unkUShort3
    2   ushort  unkUShort4
    2   ushort  unkUShort5
    2   ushort  unkUShort6

    4   uint    entryCount
    for (int ii = 0; ii < entryCount; ii++)
    {
        4   uint    entry.Name.Length
        *   string  entry.Name
        2   ushort  unkUShort7
        2   ushort  unkUShort8
        2   ushort  unkUShort9
        2   ushort  unkUShort10
        2   ushort  unkUShort11
        2   ushort  unkUShort12
        2   ushort  unkUShort13
        2   ushort  unkUShort14        
    }    
}  