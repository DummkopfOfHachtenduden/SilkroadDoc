1	byte	updateFlag
if(updateFype.HasFlag(ServerUpdateFlag.ServerBody))
{
	1	byte	unkByte0	//0
	while(true)
	{
		1	byte	hasEntry	//1 = entry, 2 = break
		if(hasEntry == 2)
			break;
		
		2	ushort	serverBody.ID
		4	uint	serverBody.State
	}
}

if(updateFype.HasFlag(ServerUpdateFlag.ServerCord))
{
	1	byte	unkByte0	//0
	while(true)
	{
		1	byte	hasEntry	//1 = entry, 2 = break
		if(hasEntry == 2)
			break;
		
		4	uint	serverCord.ID
		4	uint	serverCord.State
	}
}