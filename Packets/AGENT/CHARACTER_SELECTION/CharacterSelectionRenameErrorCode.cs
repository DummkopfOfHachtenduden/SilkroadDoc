public enum CharacterSelectionRenameErrorCode : ushort
{
    #region CharacterRename

    /// <summary>
    /// This ID already exists.
    /// </summary>
    UIO_MSG_ERROR_ID = 6,

    /// <summary>
    /// Invalid character name.
    /// </summary>
    UIO_SMERR_NOT_ALLOWED_CHARNAME = 7,

    //UIO_SMERR_NOT_ALLOWED_CHARNAME = 8,        

    #endregion CharacterRename

    #region GuildRename

    /// <summary>
    /// The selected guild name already exsists.
    /// </summary>
    UIIT_MSG_GUILDERR_SAME_GUILDNAME_EXIST = 6,

    /// <summary>
    /// The guild name cannot be created.
    /// </summary>
    UIIT_MSG_GUILD_NOT_CREATE = 7,

    //UIIT_MSG_GUILD_NOT_CREATE = 8,

    /// <summary>
    /// Unknown error.
    /// </summary>
    //UIIT_MSG_PARTYERR_UNKNOWN_ERROR = 2, 3, 4, 5,

    #endregion GuildRename
}