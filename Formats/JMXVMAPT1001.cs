12      byte[]  Header                          //JMXVMAPT1001
9216    byte[]  shadowModifiers                 //96 * 96 = 9216 ::: 96 * 20 = 1920 units 
4       uint    shadowTextureSize
4       uint    shadowTextureHeaderLength       //Joymax writes 3 for "DDS" however the real DDS-Header is 4 bytes -> "DDS "
*       byte[]  shadowTextureFileBuffer