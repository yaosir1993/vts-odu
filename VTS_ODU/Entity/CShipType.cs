using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CShipType
    {
        public int shipTypeId { get; set; } //船类型ID
        public String shipTypeName { get; set; }  //船类型名称
        public double shipDisplacement { get; set; } //排水量 t
        public double shipMaxSpeed { get; set; } //船最大速度 knot
        public double shipLength { get; set; }  //船长 海里
        public double shipWidth { get; set; }   //船宽 海里
        public double shipBowDraught { get; set; }   //船首吃水 m
        public double shipSternDraught { get; set; }   //船尾吃水 m
        public double shipControlRoomHeight { get; set; }   //控制室高度 m

        public CShipType() { }

        public CShipType(int _shipTypeId, String _shipTypeName, double _shipDisplacement, double _shipMaxSpeed, double _shipLength, 
            double _shipWidth, double _shipBowDraught, double _shipSternDraught, double _shipControlRoomHeight)
        {
            this.shipTypeId = _shipTypeId;
            this.shipTypeName = _shipTypeName;
            this.shipDisplacement = _shipDisplacement;
            this.shipMaxSpeed = _shipMaxSpeed;
            this.shipLength = _shipLength;
            this.shipWidth = _shipWidth;
            this.shipBowDraught = _shipBowDraught;
            this.shipSternDraught = _shipSternDraught;
            this.shipControlRoomHeight = _shipControlRoomHeight;
        }
    }
}
