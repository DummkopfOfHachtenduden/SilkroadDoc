/// <summary>
/// 007B9C50. 3D 083C0000 CMP EAX,3C08                             ;  Switch(cases 3..3C55)
/// </summary>
public enum StallErrorCodes : ushort
{
    /// <summary>
    /// Invalid command
    /// </summary>
    UIIT_STT_ERR_COMMON_INVALID_OPERATION = 0x5,

    /// <summary>
    /// Can set the value only from 1 to 1 billion gold.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_INVALID_PRICE = 0x3C08,

    /// <summary>
    /// Cannot open a new shop whithout the registered goods.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_NOTHING_TO_SELL = 0x3C0C,

    /// <summary>
    /// Closed the shop.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_MARKET_CLOSED = 0x3C0E,

    /// <summary>
    /// Cannot buy due to insufficient gold
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_NOT_ENOUGH_GOLD = 0x3C11,
    //UIIT_MSG_FLEAMARKET_ERR_NOT_ENOUGH_GOLD = 0x3C52,

    /// <summary>
    /// Cannot buy due to insufficient space in your inventory.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_INVENTORY_FULL = 0x3C12,
    //UIIT_MSG_FLEAMARKET_ERR_INVENTORY_FULL = 0x3C53,

    /// <summary>
    /// The shop is closed.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_HOST_LEFT = 0x3C15,

    /// <summary>
    /// You are in the status of being unable to open a new shop.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_IM_BUSY = 0x3C16,

    /// <summary>
    /// The shop is closed.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_CLOSED_BY_HOST = 0x3C17,

    /// <summary>
    /// The member limit(8) has been reached.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_MARKET_FULL = 0x3C18,

    /// <summary>
    /// The shop is under construction.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_INVALID_HOST_STATE = 0x3C2B,

    /// <summary>
    /// Banned by the owner from the shop. This function is not yet supported.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_CUSTOMER_BANNED = 0x3C2C,

    /// <summary>
    /// Cannot open the shop while boarding the vehicle to move or transport.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_CANT_OPEN_MARKET_IN_RIDESTATE = 0x3C34,

    /// <summary>
    /// Invalid letters are included. Invalid name for the shop.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_NOT_ALLOWED_FMARKETNAME = 0x3C38,

    /// <summary>
    /// Cannot open a new shop during murderer status.
    /// </summary>
    UIIT_MSG_FLEAMARKET_ERR_CANT_OPEN_MARKET_MURDERER = 0x3C39,

    /// <summary>
    /// Cannot open a stall under job status.
    /// </summary>
    UIIT_MSG_FREEMARKET_NOTUSE_JOB = 0x3C3B,

    /// <summary>
    /// Registraion of item on stall network has failed.
    /// </summary>
    UIIT_MSG_WARENETWORK_ERROR_FAIL = 0x3C41,
    //UIIT_MSG_WARENETWORK_ERROR_FAIL = 0x3C42,
    //UIIT_MSG_WARENETWORK_ERROR_FAIL = 0x3C43,
}