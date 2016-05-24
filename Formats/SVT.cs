4   uint    versionBufferLength     // Is 8 to use blowfish directly on versionBuffer
*   byte[]  versionBuffer           // Contains a 4-char blowfish encrypted ascii-version, remaining 4 bytes is padding.
*   byte[]  filePadding             // 1024 - 8 - 4 = 1012 bytes extra padding.

//ASCII_KEY is "SILKROADVERSION" but only the first 8 bytes are used for the key.