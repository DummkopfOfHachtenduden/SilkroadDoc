1   byte    Flag //0x0E = Base, 0x10 = Challange
if(Flag == 0x0E)
{
    8   uint    Blowfish
    4   uint    Count Seed
    4   uint    CRC Seed
    4   uint    Seed1
    4   uint    Seed2
    4   uint    Seed3
    4   uint    Seed4
    4   uint    Seed5
}
else if(Flag == 0x10)
{
    8   ulong  Blowfish
}