public enum LogoutErrorCode : ushort
{
    /// <summary>
    /// Cannot close the game during combat.
    /// </summary>
    UIIT_MSG_LOGOUT_ERR_CANT_LOGOUT_IN_BATTLE_STATE = 0x801

    /// <summary>
    /// Cannot exit the game while teleporting.
    /// </summary>
    UIIT_MSG_LOGOUT_ERR_CANT_LOGOUT_WHILE_TELEPORT_WORKING = 0x802
}