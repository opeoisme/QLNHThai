using DevExpress.XtraEditors;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmListTable : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int loggedInUserId;
        public frmListTable()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            loggedInUserId = 1;
            
        }


        #region event

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmptyTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); // Xóa các controls cũ trong FlowLayoutPanel

            var emptyTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Đang trống")
                .ToList();

            foreach (var table in emptyTables)
            {
                EmptyTable emptyTableControl = new EmptyTable();
                emptyTableControl.SetTableData(table); // Hàm này sẽ hiển thị dữ liệu trong EmptyTable User Control
                flpnTable.Controls.Add(emptyTableControl);
            }
        }

        private void btnBusyTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); // Xóa các controls cũ trong FlowLayoutPanel

            var busyTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Đang có khách")
                .ToList();

            foreach (var table in busyTables)
            {
                BusyTable busyTableControl = new BusyTable();
                busyTableControl.SetTableData(table); // Hàm này sẽ hiển thị dữ liệu trong EmptyTable User Control
                flpnTable.Controls.Add(busyTableControl);
            }
        }

        private void btnSetTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); // Xóa các controls cũ trong FlowLayoutPanel

            var setTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Được đặt")
                .ToList();

            foreach (var table in setTables)
            {
                SetTable SetTableControl = new SetTable();
                SetTableControl.SetTableData(table); // Hàm này sẽ hiển thị dữ liệu trong EmptyTable User Control
                flpnTable.Controls.Add(SetTableControl);
            }
        }

        private void btnAllTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear();
            LoadTablesByStatusAndCondition("Đang trống", "Được sử dụng", typeof(EmptyTable));
            LoadTablesByStatusAndCondition("Đang có khách", "Được sử dụng", typeof(BusyTable));
            LoadTablesByStatusAndCondition("Được đặt", "Được sử dụng", typeof(SetTable));
        }

        void loadAll()
        {
            flpnTable.Controls.Clear();
            LoadTablesByStatusAndCondition("Đang trống", "Được sử dụng", typeof(EmptyTable));
            LoadTablesByStatusAndCondition("Đang có khách", "Được sử dụng", typeof(BusyTable));
            LoadTablesByStatusAndCondition("Được đặt", "Được sử dụng", typeof(SetTable));
        }


        #endregion

        #region method
        private void LoadTablesByStatusAndCondition(string status, string condition, Type controlType)
        {
            var tables = dbContext.Tablees
                .Where(t => t.status_Table == status && t.condition_Table == condition)
                .ToList();

            foreach (var table in tables)
            {
                var tableControl = (DevExpress.XtraEditors.XtraUserControl)Activator.CreateInstance(controlType);
                UpdateTableData(tableControl, table);
                flpnTable.Controls.Add(tableControl);
            }
        }


        private void UpdateTableData(DevExpress.XtraEditors.XtraUserControl tableControl, Tablee table)
        {
            if (tableControl is EmptyTable emptyTable)
            {
                emptyTable.SetTableData(table);
            }
            else if (tableControl is BusyTable busyTable)
            {
                busyTable.SetTableData(table);
            }
            else if (tableControl is SetTable setTable)
            {
                setTable.SetTableData(table);
            }
        }












        #endregion

        private void frmListTable_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}