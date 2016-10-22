//CPU Disasm
//Address   Hex dump          Command                                              Comments
//008A4572  |. C74424 0C E0B4 MOV DWORD PTR SS:[ESP+0C],0B4E0                      ; |
//008A457A  |. C74424 10 C0A4 MOV DWORD PTR SS:[ESP+10],sro_client.0089A4C0        ; |

//in a loop (which is hardcoded?)
foreach(entry)
{
	4	uint	traderUnionPoints
	4	uint	thiefUnionPoints	
}

//[S -> C][B4E0]
//00 00 00 00                                       traderUnionPoints
//00 00 00 00                                       thiefUnionPoints

//00 00 00 00                                       traderUnionPoints
//00 00 00 00                                       thiefUnionPoints