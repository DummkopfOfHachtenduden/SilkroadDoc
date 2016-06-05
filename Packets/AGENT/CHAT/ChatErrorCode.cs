/// <summary>
/// 00877592   . 3D 06200000    CMP EAX,2006                             ;  Switch (cases 3..200E)
/// </summary>
public enum ChatErrorCode : ushort
{
    /// <summary>
    /// Cannot find [%s].
    /// </summary>
    UIIT_CHATERR_CANT_FIND_TARGET = 3,

    /// <summary>
    /// [%s]'s whisper function is turn off.
    /// </summary>
    UIIT_CHATERR_YOU_ARE_SQUELCHED = 0x2006,

    /// <summary>
    /// Invalid chat command.
    /// </summary>
    UIIT_CHATERR_INVALID_COMMAND = 0x2008,

    /// <summary>
    /// Not in the party status.
    /// </summary>
    UIIT_CHATERR_NOT_A_PARTY_MEMBER = 0x200A,

    /// <summary>
    /// Cannot use the Ally Chat because the selected guild is not your ally.
    /// </summary>
    UIIT_CHATERR_ALLIANCE_PERMISSION_DENIED = 0x200B,

    //UIIT_CHATERR_ALLIANCE_PERMISSION_DENIED = 0x200C,

    /// <summary>
    /// Chat Restricted: %d seconds
    /// </summary>
    UIIT_STT_CANT_CHATTING = 0x200D,

    /// <summary>
    /// You do not have union chatting authority, so you cannot chat.
    /// </summary>
    UIIT_MSG_GUILD_UNION_CHAT_LIMIT = 0x200E,
}