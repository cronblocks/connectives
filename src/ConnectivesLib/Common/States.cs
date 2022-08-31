namespace Connectives.Common
{
    #region GUI States

    // ---------------
    // GUI States
    // ----------

    public enum GuiState
    {
        Loading,
        NormalWorking,
        Unloading,
        BusyOperation
    }

    #endregion
    #region Block States

    // ---------------
    // Block States
    // ----------

    public enum BlockSelectionState
    {
        Selected,
        Deselected
    }

    #endregion
}
