1	byte	forward.result	//only result for forwarding nothing to do with inner packet.
4	uint	forward.ID
if(result == 1)
{	
	2	ushort	forward.InnerOpcode
	*	byte[]	forward.InnerData	//see innerOpcode related packet for details.
}
else if(result == 2)
{
	//LOST SAMPLE
}