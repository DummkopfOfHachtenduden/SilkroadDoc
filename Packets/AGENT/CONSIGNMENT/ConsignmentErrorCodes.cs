/// <summary>
/// 007BB205   . 05 F98FFFFF    ADD EAX,FFFF8FF9                         ;  Switch (cases 7007..7022)
/// </summary>
public enum ConsignmentErrorCodes : ushort
{
    /// <summary>
    /// Item registration is done by page.  Please register your items from a previous page first.
    /// </summary>
    UIIT_STT_OPEN_MARKET_ENTER_PAGE_ERROR = 0x7007,

    /// <summary>
    /// You have no or insufficient deposit to register the item(s).
    /// </summary>
    UIIT_STT_OPEN_MARKET_ENTER_ERROR = 0x7008,

    /// <summary>
    /// This item cannot be consigned.
    /// </summary>
    UIIT_STT_OPEN_MARKET_SELL_IMPOSSIBLE = 0x700A,
    //UIIT_STT_OPEN_MARKET_SELL_IMPOSSIBLE = 0x700B,

    /// <summary>
    /// Item cannot be purchased due to lack of gold.
    /// </summary>
    UIIT_MSG_GUILD_LACK_GOLD = 0x700D,

    //007BB242   > 68 6074E100    PUSH sro_clie.00E17460                   ;  Cases 700F,7010,7017,7018 of switch 007BB205
    SWALLOWED = 0x700F,
    //SWALLOWED = 0x7010,
    //SWALLOWED = 0x7017,
    //SWALLOWED = 0x7018,

    /// <summary>
    /// The item has expired or already sold and cannot be purchased.
    /// </summary>
    UIIT_STT_OPEN_MARKET_BUYING_ERROR = 0x7019,
    //UIIT_STT_OPEN_MARKET_BUYING_ERROR = 0x701A,

    /// <summary>
    /// Invalid search criteria.  Cannot search items.
    /// </summary>
    UIIT_STT_OPEN_MARKET_FIND_ERROR = 0x701B,

    /// <summary>
    /// The price range has been exceeded.
    /// </summary>
    UIIT_STT_OPEN_MARKET_COST_OVER_ERROR = 0x701C,

    /// <summary>
    /// Invalid character
    /// </summary>
    UIIT_STT_OPEN_MARKET_TEXT_ERROR = 0x701D,

    /// <summary>
    /// Settlement is in progress, or settlement has already been completed.
    /// </summary>
    UIIT_STT_OPEN_MARKET_RECEIPTED_ITEM_ERROR = 0x701E,

    /// <summary>
    /// There are no items to cancel, or there is insufficient space in the inventory.
    /// </summary>
    UIIT_STT_OPEN_MARKET_CANCEL_ITEM_ERROR = 0x701F,
    //UIIT_STT_OPEN_MARKET_CANCEL_ITEM_ERROR = 0x7020,

    /// <summary>
    /// Must enter 2 characters or more.
    /// </summary>
    UIIT_STT_OPEN_MARKET_MIN_TEXT_ERROR = 0x7021,

    /// <summary>
    /// A pet that is being summoned cannot be registered.
    /// </summary>
    UIIT_STT_OPEN_MARKET_ENTERD_PET_ERROR = 0x7022,
}

//007BB205   . 05 F98FFFFF    ADD EAX,FFFF8FF9                         ;  Switch (cases 7007..7022)
//007BB20A   . 83F8 1B        CMP EAX,1B
//007BB20D   . 0F87 E0000000  JA sro_clie.007BB2F3
//007BB213   . FF2485 80C07B0>JMP DWORD PTR DS:[EAX*4+7BC080]
//007BB21A   > 68 4053D900    PUSH sro_clie.00D95340                   ;  UNICODE "UIIT_STT_OPEN_MARKET_ENTER_PAGE_ERROR"; Case 7007 of switch 007BB205
//007BB21F   . E9 C6000000    JMP sro_clie.007BB2EA
//007BB224   > 68 C8DFDB00    PUSH sro_clie.00DBDFC8                   ;  UNICODE "UIIT_STT_OPEN_MARKET_ENTER_ERROR"; Case 7008 of switch 007BB205
//007BB229   . E9 BC000000    JMP sro_clie.007BB2EA
//007BB22E   > 68 9051D900    PUSH sro_clie.00D95190                   ;  UNICODE "UIIT_STT_OPEN_MARKET_SELL_IMPOSSIBLE"; Cases 700A,700B of switch 007BB205
//007BB233   . E9 B2000000    JMP sro_clie.007BB2EA
//007BB238   > 68 94DFDB00    PUSH sro_clie.00DBDF94                   ;  UNICODE "UIIT_MSG_GUILD_LACK_GOLD"; Case 700D of switch 007BB205
//007BB23D   . E9 A8000000    JMP sro_clie.007BB2EA
//007BB242   > 68 6074E100    PUSH sro_clie.00E17460                   ;  Cases 700F,7010,7017,7018 of switch 007BB205
//007BB247   . E9 9E000000    JMP sro_clie.007BB2EA
//007BB24C   > 68 50DFDB00    PUSH sro_clie.00DBDF50                   ;  UNICODE "UIIT_STT_OPEN_MARKET_BUYING_ERROR"; Cases 7019,701A of switch 007BB205
//007BB251   . E9 94000000    JMP sro_clie.007BB2EA
//007BB256   > 68 4857D900    PUSH sro_clie.00D95748                   ;  UNICODE "UIIT_STT_OPEN_MARKET_FIND_ERROR"; Case 701B of switch 007BB205
//007BB25B   . E9 8A000000    JMP sro_clie.007BB2EA
//007BB260   > 68 00DFDB00    PUSH sro_clie.00DBDF00                   ;  UNICODE "UIIT_STT_OPEN_MARKET_COST_OVER_ERROR"; Case 701C of switch 007BB205
//007BB265   . E9 80000000    JMP sro_clie.007BB2EA
//007BB26A   > 68 C0DEDB00    PUSH sro_clie.00DBDEC0                   ;  UNICODE "UIIT_STT_OPEN_MARKET_TEXT_ERROR"; Case 701D of switch 007BB205
//007BB26F   . EB 79          JMP SHORT sro_clie.007BB2EA
//007BB271   > 68 68DEDB00    PUSH sro_clie.00DBDE68                   ;  UNICODE "UIIT_STT_OPEN_MARKET_RECEIPTED_ITEM_ERROR"; Case 701E of switch 007BB205
//007BB276   . EB 72          JMP SHORT sro_clie.007BB2EA
//007BB278   > 68 18DEDB00    PUSH sro_clie.00DBDE18                   ;  UNICODE "UIIT_STT_OPEN_MARKET_CANCEL_ITEM_ERROR"; Cases 701F,7020 of switch 007BB205
//007BB27D   . EB 6B          JMP SHORT sro_clie.007BB2EA
//007BB27F   > 68 8857D900    PUSH sro_clie.00D95788                   ;  UNICODE "UIIT_STT_OPEN_MARKET_MIN_TEXT_ERROR"; Case 7021 of switch 007BB205
//007BB284   . EB 64          JMP SHORT sro_clie.007BB2EA
//007BB286   > 68 C8DDDB00    PUSH sro_clie.00DBDDC8                   ;  UNICODE "UIIT_STT_OPEN_MARKET_ENTERD_PET_ERROR"; Case 7022 of switch 007BB205
//007BB28B   . EB 5D          JMP SHORT sro_clie.007BB2EA

