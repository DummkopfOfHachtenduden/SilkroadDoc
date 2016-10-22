/// <summary>
/// 00891E24   . 05 FA7FFFFF    ADD EAX,FFFF7FFA                         ;  Switch (cases 8006..800B)
/// </summary>
public enum FRPVPErrorCode : ushort
{
    /// <summary>
    /// Cannot enter Free PvP mode right now.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_ON = 0x8006,

    /// <summary>
    /// Cannot enter Free PvP mode while in Job mode.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_JOB_STATE = 0x8007,

    /// <summary>
    /// Cannot exit Free PvP mode right now.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_OFF = 0x8008,

    /// <summary>
    /// You have exited the Free PvP mode.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_OFF_CANCEL = 0x8009,

    /// <summary>
    /// Cannot change teams right now.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_CHANGE_TEAM = 0x800A,

    /// <summary>
    /// Team change cancelled.
    /// </summary>
    UIIT_MGS_ERR_FRPVP_CANCEL_CHANGE_TEAM = 0x800B,
}