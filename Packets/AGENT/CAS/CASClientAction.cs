public enum CASClientAction : byte
{
    SubmitHelpRequest = 0,
    RequestCompletedHelpRequests = 1,
    DeleteCompletedHelpRequest = 2,
    AcceptGMCall = 3,
    RefuseGMCall = 4
    SendGMCallMessage = 5
}