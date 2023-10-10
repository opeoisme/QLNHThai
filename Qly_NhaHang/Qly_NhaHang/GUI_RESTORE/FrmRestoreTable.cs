using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class FrmRestoreTable : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public FrmRestoreTable()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities();
            LoadFormTable();
        }
        public void LoadFormTable()
        {
            var tableData = dbContext.Tablees
                              .Where(tb => tb.condition_Table == "Ngưng sử dụng")
                             .Select(tb => new TableView
                             {
                                 id_Table = tb.id_Table,
                                 name_Table = tb.name_Table,
                                 status_Table = tb.status_Table,
                                 seats_Table = (int)tb.seats_Table,
                                 condition_Table = tb.condition_Table,
                             }).ToList();
            gctTable.DataSource = tableData;
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctTable.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvTable_FocusedRowChanged;


        }

        private void gvTable_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateTableControls(e.FocusedRowHandle);
            }
        }
        private void UpdateTableControls(int focusedRowHandle)
        {
            TableView selectedTable = gvTable.GetRow(focusedRowHandle) as TableView;
            if (selectedTable != null)
            {
                txbIdTable.Text = selectedTable.id_Table.ToString();
                txbNameTable.Text = selectedTable.name_Table;
                txbSeatTable.Text = selectedTable.seats_Table.ToString();
                txbStatusTable.Text = selectedTable.status_Table;

            }
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvTable.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                TableView selectedTable = gvTable.GetRow(focusedRowHandle) as TableView;
                if (selectedTable != null)
                {
                    if (int.TryParse(selectedTable.id_Table.ToString(), out int tableId))
                    {
                        Tablee tableToUpdate = dbContext.Tablees.FirstOrDefault(tb => tb.id_Table == tableId);

                        if (tableToUpdate != null)
                        {
                            tableToUpdate.condition_Table = "Được sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(tableToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFormTable();
                            XtraMessageBox.Show("Bàn được đưa vào sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            LoadFormTable();
        }
    }
}