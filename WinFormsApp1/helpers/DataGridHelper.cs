namespace WinFormsApp1.helpers
{
    public static class DataGridHelper
    {

        /// <summary>
        /// Sets the sort mode for the data grid view by setting the sort mode of individual columns
        /// </summary>
        /// <param name="dgv">Data Grid View</param>
        /// <param name="sortMode">Sort node of type DataGridViewColumnSortMode</param>
        public static void SetGridViewSortState(DataGridView dgv, DataGridViewColumnSortMode sortMode)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.SortMode = sortMode;
        }
    }
}
