//CPU Disasm
//Address   Hex dump          Command                                                 Comments
//00822C6C  |. 68 DF740000    PUSH 74DF                                               ; /Arg1 = 74DF
//00822C71  |. 8D4C24 0C      LEA ECX,[ARG.3]                                         ; |
//00822C75  |. E8 26A2D1FF    CALL sro_client.beginPacket                             ; \sro_client.beginPacket
1	byte	isIcon
if(isIcon == 0)
	4	uint	NPC.UniqueID