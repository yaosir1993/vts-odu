using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CDataPackage
    {
        public int dataType { get; set; } //0 船 1 雷达 2 AIS
        public CShip dataShip { get; set; } //数据对象
        public CRadar dataRadar { get; set; } //数据对象
        public CAis dataAis { get; set; } //数据对象

        public CDataPackage() { }
        public CDataPackage(int _typeID,CShip ship)
        {
            dataType = _typeID;
            dataShip = ship;
        }

        public CDataPackage(int _typeID, CRadar radar)
        {
            dataType = _typeID;
            dataRadar = radar;
        }

        public CDataPackage(int _typeID, CAis ais)
        {
            dataType = _typeID;
            dataAis = ais;
        }
    }
}
