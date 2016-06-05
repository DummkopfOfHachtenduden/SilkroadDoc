1   byte    casClientAction
switch(CASClientAction)
{
    case CASClientAction.SubmitHelpRequest:
        2   ushort  ShardID
        1   byte    RequestedCategory
        2   ushort  MailAdress.Length
        *   string  MailAdress
        4   uint    UserJID
        2   ushort  CharName.Length
        *   string  CharName
        2   ushort  TgtCharName.Length
        *   string  TgtCharName
        2   ushort  Statement.Length
        *   string  Statement
        2   ushort  ChatLog.Length
        *   string  ChatLog
    break;

    case CASClientAction.RequestCompletedHelpRequests: 
        2   ushort  CharName.Length
        *   string  CharName
    break;

    case CASClientAction.DeleteCompletedHelpRequest:
        4   uint    Serial
    break;

    case CASClientAction.AcceptGMCall:
    case CASClientAction.RefuseGMCall:
        4   uint    CallID
    break;
}