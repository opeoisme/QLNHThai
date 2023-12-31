﻿using DevExpress.XtraEditors;
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
    public partial class frmAddTable : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        public frmAddTable()
        {
            InitializeComponent();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameTable.Text) || string.IsNullOrWhiteSpace(txbSeatTable.Text) || !int.TryParse(txbSeatTable.Text, out int seatValue) || seatValue <= 1)
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tablee newTable = new Tablee
            {
                name_Table = txbNameTable.Text,
                seats_Table = seatValue,
                condition_Table = "Được sử dụng",
                status_Table = "Đang trống"
            };

            // Thêm đối tượng mới vào cơ sở dữ liệu
            try
            {
                dbContext.Tablees.Add(newTable);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm mới bàn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmTable"] is frmTable tableForm)
                {
                    tableForm.LoadFormTable(); // Giả sử tên phương thức là LoadFoodData()
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}