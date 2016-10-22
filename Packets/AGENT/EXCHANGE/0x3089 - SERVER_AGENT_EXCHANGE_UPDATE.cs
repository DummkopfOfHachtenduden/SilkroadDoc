1   byte    updateType
if(updateType == ExchangeUpdateType.Item)
{
	1	byte	Slot
	*	object	<genericItemData>
}
else if(updateType == ExchangeUpdateType.Gold)
{
	8   ulong   Gold	
}
