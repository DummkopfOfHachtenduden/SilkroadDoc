1   byte    casClientAction
1   byte    result
if(result == 0x01)
{
    switch(casClientAction)
    {
        case CASClientAction.RequestCompletedRequests:
            1   byte    completedHelpRequestCount
            foreach(helpRequest)
            {
                4       uint    helpRequest.Serial
                20      char[]  helpRequest.ProcessedGM
                1024    char[]  helpRequest.Answer
                2       ushort  helpRequest.ProcessDate.Year
                2       ushort  helpRequest.ProcessDate.Month
                2       ushort  helpRequest.ProcessDate.Day
                2       ushort  helpRequest.ProcessDate.Hour
                2       ushort  helpRequest.ProcessDate.Minute
                2       ushort  helpRequest.ProcessDate.Second
                2       ushort  helpRequest.ProcessDate.Microsecond
                1       byte    helpRequest.unkByte0 //btUserChecked? -> check != 0
            }
        break;

        case CASClientAction.DeleteCompletedHelpRequest
            4   uint    Serial
        break;

        case CASClientAction.AcceptGMCall:
        case CASClientAction.RefuseGMCall:
            4   uint    CallID
        break;      
    }
}
else if(result == 0x02)
{
    1   byte    errorCode
}