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

        public frmListTable()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }

        #region event
        private void frmListTable_Load(object sender, EventArgs e)
        {
            loadAll();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmptyTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); 
            var emptyTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Đang trống")
                .ToList();
            foreach (var table in emptyTables)
            {
                EmptyTable emptyTableControl = new EmptyTable();
                emptyTableControl.SetTableData(table); 
                flpnTable.Controls.Add(emptyTableControl);
            }
        }

        private void btnBusyTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); 

            var busyTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Đang có khách")
                .ToList();

            foreach (var table in busyTables)
            {
                BusyTable busyTableControl = new BusyTable();
                busyTableControl.SetTableData(table);
                flpnTable.Controls.Add(busyTableControl);
            }
        }

        private void btnSetTable_Click(object sender, EventArgs e)
        {
            flpnTable.Controls.Clear(); 

            var setTables = dbContext.Tablees
                .Where(t => t.condition_Table == "Được sử dụng" && t.status_Table == "Được đặt")
                .ToList();
            foreach (var table in setTables)
            {
                SetTable SetTableControl = new SetTable();
                SetTableControl.SetTableData(table);
                flpnTable.Controls.Add(SetTableControl);
            }
        }

        private void btnAllTable_Click(object sender, EventArgs e)
        {
            loadAll();
        }




        public void loadAll()
        {
            flpnTable.Controls.Clear();

            using (var newContext = new QLNHThaiEntities())
            {
                LoadAllRoomsAndSortByRoomNumber(newContext);
            }
        }

        private void LoadAllRoomsAndSortByRoomNumber(QLNHThaiEntities dbContext)
        {
            var allRooms = dbContext.Tablees
                .OrderBy(t => t.id_Table)
                .Where(t => t.condition_Table =="Được sử dụng")
                .ToList();

            foreach (var room in allRooms)
            {
                if (room.status_Table == "Đang có khách")
                {
                    LoadTable(typeof(BusyTable), room);
                }
                else if (room.status_Table == "Đang trống")
                {
                    LoadTable(typeof(EmptyTable), room);
                }
                else if (room.status_Table == "Được đặt")
                {
                    LoadTable(typeof(SetTable), room);
                }
               
            }
        }

        private void LoadTable(Type controlType, Tablee tablee)
        {
            var tableControl = (DevExpress.XtraEditors.XtraUserControl)Activator.CreateInstance(controlType);
            UpdateTableData(tableControl, tablee);
            flpnTable.Controls.Add(tableControl);
        }

        #endregion

        #region method


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

        
    }
}