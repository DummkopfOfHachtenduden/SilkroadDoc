12  string  Header                              //JMXVDDJ 1000
4   uint    TextureSize
4   uint    TextureHeaderLength                 //Joymax writes 3 for "DDS" but FourCC is "DDS "
*   byte[]  TextureFileBuffer