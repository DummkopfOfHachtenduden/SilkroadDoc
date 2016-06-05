4   uint    messageCount
foreach(message)
{
	4   uint    message.ID
	1   byte    casServerAction
	switch(casServerAction)
	{
		case CASServerAction.NotifyCompletedRequest:
			2   ushort  CharName.Length
			*   string  CharName
			4   uint    Serial
			2   ushort  ProcessedGM.Length
			*   string  ProcessedGM
			2   ushort  Answer.Length
			*   string  Answer
			2   ushort  ProcessDate.Year
			2   ushort  ProcessDate.Month
			2   ushort  ProcessDate.Day
			2   ushort  ProcessDate.Hour
			2   ushort  ProcessDate.Minute
			2   ushort  ProcessDate.Second
			2   ushort  ProcessDate.Microsecond
		break;
		
		case CASServerAction.CreateGMCall:
		case CASServerAction.SendGMCallMessage:
		case CASServerAction.EndGMCallSession:		
			4   uint    CallID
			if(casServerAction == CASServerAction.CreateGMCall)
			{
				2   ushort  GameMasterName.Length
				*   string  GameMasterName
			}
			else if(casServerAction == CASServerAction.SendGMCallMessage)
			{
				2   ushort  Message.Length
				*   string  Message   
			}
		break;
	}
}