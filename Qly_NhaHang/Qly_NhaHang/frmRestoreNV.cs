using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmRestoreNV : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreNV()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities();
        }

        public void LoadFormNV()
        {
            var nhanvienData = dbContext.NhanViens
                             .Where(nv => nv.condition_NV == "Nghỉ việc")
                            .Select(nv => new NhanVienView
                            {
                                id_NV = nv.id_NV,
                                name_NV = nv.name_NV,
                                sex_NV = nv.sex_NV,
                                address_NV = nv.address_NV,
                                CCCD_NV = nv.CCCD_NV,
                                phone_NV = nv.phone_NV,
                                image_NV = nv.image_NV,
                                type_NV = nv.type_NV,
                                condition_NV = nv.condition_NV,
                                pass_NV = nv.pass_NV,
                            }).ToList();
            gctNV.DataSource = nhanvienData;
        }

        private void btnLoadNV_Click(object sender, EventArgs e)
        {
            LoadFormNV();
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctNV.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvNV_FocusedRowChanged;
        }

        private void gvNV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateNhanVienControls(e.FocusedRowHandle);
            }
        }
        private void UpdateNhanVienControls(int focusedRowHandle)
        {
            NhanVienView selectedNhanvien = gvNV.GetRow(focusedRowHandle) as NhanVienView;
            if (selectedNhanvien != null)
            {
                txbIdNV.Text = selectedNhanvien.id_NV;
                txbNameNV.Text = selectedNhanvien.name_NV;
                cbbSexNV.SelectedItem = selectedNhanvien.sex_NV;
                txbAddressNV.Text = selectedNhanvien.address_NV;
                txbCCCDNV.Text = selectedNhanvien.CCCD_NV;
                txbPhoneNV.Text = selectedNhanvien.phone_NV;
                cbbConditionNV.SelectedItem = selectedNhanvien.condition_NV;
                cbbTypeNV.SelectedItem = selectedNhanvien.type_NV;

                if (selectedNhanvien.image_NV != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedNhanvien.image_NV))
                    {
                        imgNV.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imgNV.Image = Properties.Resources.Food0;
                }
            }
        }

        private void frmRestoreNV_Load(object sender, EventArgs e)
        {
            LoadFormNV();
        }

        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvNV.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                NhanVienView selectedNhanvien = gvNV.GetRow(focusedRowHandle) as NhanVienView;
                if (selectedNhanvien != null)
                {
                    string nhanvienId = selectedNhanvien.id_NV;
                    NhanVien nhanvienToDelete = dbContext.NhanViens.FirstOrDefault(nv => nv.id_NV == nhanvienId);
                    if (nhanvienToDelete != null)
                    {
                        nhanvienToDelete.condition_NV = "Làm việc";
                        dbContext.Entry(nhanvienToDelete).State = EntityState.Modified;
                        dbContext.SaveChanges();
                        LoadFormNV();
                        XtraMessageBox.Show("Nhân viên không còn làm việc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}