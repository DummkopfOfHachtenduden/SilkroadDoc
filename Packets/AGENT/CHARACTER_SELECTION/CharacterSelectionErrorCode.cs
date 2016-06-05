public enum CharacterSelectionErrorCode : ushort
{
    /// <summary>
    /// A maximum of %d characters can be created.
    /// </summary>
    UIO_MSG_ERROR_CHARACTER_OVER_3 = 0x405,

    /// <summary>
    /// Select a Weapon.
    /// </summary>
    UIO_MSG_ERROR_CHARACTER_SELECTWEAPON = 0x404,

    /// <summary>
    /// Exceeded the letter limit. \n Only 12 English letters are available.[Min., Max.]
    /// </summary>
    UIO_MSG_ERROR_CHARACTER_NAME_STRING = 0x40C,

    /// <summary>
    /// Invalid character name.
    /// </summary>
    UIO_SMERR_NOT_ALLOWED_CHARNAME = 0x40D,

    /// <summary>
    /// This ID already exists.
    /// </summary>
    UIO_MSG_ERROR_ID = 0x410,

    /// <summary>
    /// This user is already connected. The user may still be connected because of an error that forced the game to close. Please try again in 5 minutes.
    /// </summary>
    UIO_MSG_ERROR_OVERLAP = 0x411,

    /// <summary>
    /// Cannot connect to the server because the server reached its capacity.
    /// </summary>
    UIO_SMERR_MAX_USER_EXCEEDED = 0x414,

    /// <summary>
    /// Failed to create a character. Please try to connect again.
    /// </summary>
    UIO_SMERR_INVALID_CHARGEN_INFO = 0x403,

    /// <summary>
    /// Failed to create a character. Please try to connect again.
    /// </summary>
    UIO_SMERR_FAILED_TO_CREATE_CHARACTER = 0x406,

    /// <summary>
    /// The server is not running.. Please try to connect again later.
    /// </summary>
    UIO_SMERR_CANT_FIND_GAMESERVER = 0x409,

    /// <summary>
    /// The server is not running.. Please try to connect again later.
    /// </summary>
    UIO_SMERR_CANT_ACCESS_PARENT_SERVER = 0x40F,

    /// <summary>
    /// Failed to create a character. Please try to connect again.
    /// </summary>
    UIO_SMERR_FAILED_TO_CREATE_NEW_USER = 0x412,

    /// <summary>
    /// Login failed
    /// </summary>
    UIO_SMERR_FAILED_TO_ENTERLOBBY = 0x415,

    /// <summary>
    /// Failed to connect to server.
    /// </summary>
    //UIO_MSG_ERROR_SEVER_CONNECT = 402,407,408,40A,40B,40E,413,416,417,418,
}