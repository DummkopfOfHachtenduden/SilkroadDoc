2	ushort	ShardID
1	byte	updateType
if(updateType == 0)
{
	//ShardName
	2	ushort	Name.Length
	*	string	Name	
}
else if(updateType == 1)
{
	//ShardMaxUser
	2	ushort	MaxUser
}