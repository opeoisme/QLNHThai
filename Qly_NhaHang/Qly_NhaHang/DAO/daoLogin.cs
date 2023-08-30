using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class daoLogin
    {
        public bool ValidateLogin(string id_NV, string pass_NV)
        {
            using (var context = new QLNHThaiEntities())
            {
                var employee = context.NhanViens
                    .FirstOrDefault(nv => nv.id_NV == id_NV && nv.pass_NV == pass_NV);

                return employee != null;
            }
        }

        public NhanVien GetEmployee(string id_NV)
        {
            using (var context = new QLNHThaiEntities())
            {
                return context.NhanViens.FirstOrDefault(nv => nv.id_NV == id_NV);
            }
        }
    }
}
