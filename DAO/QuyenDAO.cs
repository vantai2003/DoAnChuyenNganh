using DACN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN.DAO
{
    public class QuyenDAO
    {
        private static QuyenDAO instance;
        public static QuyenDAO Instance
        {
            get { if (instance == null) instance = new QuyenDAO(); return QuyenDAO.instance; }
            private set { QuyenDAO.instance = value; }
        }
        private QuyenDAO()
        {

        }
        public List<QuyenDTO> LoadLisQuyen()
        {
            List<QuyenDTO> listQuyen = new List<QuyenDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListQuyen");
            foreach (DataRow row in data.Rows)
            {
                QuyenDTO quyen = new QuyenDTO(row);
                listQuyen.Add(quyen);
            }
            return listQuyen;
        }
    }
}
