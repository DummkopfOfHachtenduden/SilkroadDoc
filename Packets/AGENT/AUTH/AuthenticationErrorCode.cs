    public enum AuthenticationErrorCode : byte
    {
        /// <summary>
        /// <para>UIO_MSG_ERROR_SERVER_BUSY_CONNECT_IMPOSSIBILE</para>
        /// The server is full, please try again later.
        /// </summary>
        ServerIsFull = 4,

        /// <summary>
        /// Cannot connect to the server because access to the current IP has exceeded its limit.
        /// </summary>
        IPLimit = 5,
    }