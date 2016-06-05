public enum LoginErrorCode
{
    /// <summary>
    /// <para>UIIT_STT_GLOBAL_PASSWORD_INPUT_ERROR</para>
    /// Password entry has failed %d out of %d times.
    /// </summary>
    InvalidCredentials = 1,

    /// <summary>
    /// Depends on subtype <see cref="LoginBlockType"/>
    /// </summary>
    Blocked = 2,

    /// <summary>
    /// <para>UIO_MSG_ERROR_OVERLAP</para>
    /// This user is already connected. The user may still be connected because of an error that forced the game to close. Please try again in 5 minutes.
    /// </summary>
    AlreadyConnected = 4,
    /// <summary>
    /// <para>UIO_MSG_ERROR_SERVER_BUSY_CONNECT_IMPOSSIBILE</para>
    /// The server is full, please try again later.
    /// </summary>
    ServerIsFull = 6,

    /// <summary>
    /// Cannot connect to the server because access to the current IP has exceeded its limit.
    /// </summary>
    IPLimit = 0xB,

    /// <summary>
    /// <para>TRANSLATION MISSING</para>
    /// 사용기간이 만료되어 서버에 접속할 수 없습니다. (This period has expired, you can not connect to the server.)
    /// </summary>
    UIIO_CLIENT_START_CONTENT_FAIL_BILLING_FAILED = 0xC,

    /// <summary>
    /// Billing server error occurred.
    /// </summary>
    UIIO_CLIENT_START_CONTENT_FAIL_BILLING_RELATED = 0xD,

    /// <summary>
    /// Only adults over the age of 18 are allowed to connect to the server.
    /// </summary>
    UIIO_SMERR_ADULT_ONLY_SERVER = 0xE,

    /// <summary>
    /// Only users over the age of 12 are allowed to connect to the server.
    /// </summary>
    UIIO_SMERR_TEENOVER_ONLY_SERVER = 0xF,

    /// <summary>
    /// Adults over the age of 18 are not allowed to connect to the Teen server.
    /// </summary>
    UITT_TEENSERVER_ERRMGS_ADULT = 0x10,
}