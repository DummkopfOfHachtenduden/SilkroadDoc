//Encrypted
4   uint    Token //from LOGIN_RESPONSE
2   ushort  Username.Length
*   string  Username
2   ushort  Password.Length
*   string  Password
1   byte    OperationType
6   byte[]  MAC-Address