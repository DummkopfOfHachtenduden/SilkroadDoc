1	byte	result

//Module
1	byte	unkByte1
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	1	byte	module.ID
	64	string	module.Name	
}

//Content
1	byte	unkByte2
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	1	byte	content.ID
	64	string	content.Name	
}

//Divison
1	byte	unkByte3
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	1	byte	divison.ID	
	32	string	divison.Name
	256	string	divison.Query
	2	ushort	divison.GlobalManagerID	//RUNTIME
}

//Farm
1	byte	unkByte4
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	1	byte	farm.ID
	1	byte	farm.DivisonID	
	32	string	farm.Name
	256	string	farm.DBConfig
}

//FarmContent
1	byte	unkByte5
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	1	byte	unknown.FarmID
	1	byte	unknown.ContentID	
	4	byte[]	unknown.unkBuffer	//RUNTIME
}

//Shard
1	byte	unkByte6
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	2	ushort	shard.ID
	1	byte	shard.FarmID
	1	byte	shard.ContentID
	32	string	shard.Name
	256	string	shard.DBConfig		//Shard connection string
	256	string	shard.LogDBConfig	//Log connection string
	2	ushort	shard.MaxUser
	2	ushort	shard.ShardManagerID
	7	byte[]	shard.unkBuffer	//RUNTIME
}

//ServerMachine
1	byte	unkByte7
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	4	uint	serverMachine.ID
	1	byte	serverMachine.DivisonID
	32	string	serverMachine.Name
	16	string	serverMachine.PublicIP
	16	string	serverMachine.PrivateIP
	2	ushort	serverMachine.MachineManagerID //RUNTIME
}

//ServerBody
1	byte	unkByte8
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	2	ushort	serverBody.ID
	1	byte	serverBody.DivisionID
	1	byte	serverBody.FarmID
	2	ushort	serverBody.ShardID
	4	uint	serverBody.MachineID
	2	byte	serverBody.ModuleID
	1	byte	serverBody.ModuleType
	2	ushort	serverBody.CertifierID
	2	ushort	serverBody.BindPort
	4	uint	serverBody.State	//RUNTIME
	20	byte[]	serverBody.unkBuffer	//RUNTIME
}

//ServerCord
1	byte	unkByte9
while(true)
{
	1	byte	entryFlag	//1 = read, 2 = break
	if(entryFlag == 2)
		break;
	
	4	uint	serverCord.ID
	2	ushort	serverCord.ChildID
	2	ushort	serverCord.ParentID
	1	byte	serverCord.BindType
	4	uint	serverCord.State	//RUNTIME
	4	uint	serverCord.u2
}

1	byte	useSecurityDesc
if(useSecurityDesc)
{
	//_SecurityDescriptionGroups
	1	byte	unkByte11
	while(true)
	{
		1	byte	entryFlag	//1 = read, 2 = break
		if(entryFlag == 2)
			break;
		
		1	byte	group.ID	//_SecurityDescriptionGroups.nID
		32	string	group.Name	//_SecurityDescriptionGroups.szName
		256	string	group.Desc	//_SecurityDescriptionGroups.szDesc	
	}
	
	//_SecurityDescriptions
	1	byte	unkByte12
	while(true)
	{
		1	byte	entryFlag	//1 = read, 2 = break
		if(entryFlag == 2)
			break;
		
		4	uint	desc.ID		//_SecurityDescriptions.nID
		64	string	desc.Name	//_SecurityDescriptions.szName
		256	string	desc.Desc	//_SecurityDescriptions.szDesc	
	}
	
	//_SecurityDescriptionGroupAssigns
	1	byte	unkByte13
	while(true)
	{
		1	byte	entryFlag	//1 = read, 2 = break
		if(entryFlag == 2)
			break;
		
		1	byte	desc.GroupID	//_SecurityDescriptionGroupAssigns.nGroupID	
		4	uint	desc.DescID		//_SecurityDescriptionGroupAssigns.nDescriptionID	
	}	
}
//EOP