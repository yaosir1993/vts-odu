using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CShipModel
    {
        //1:5万吨 2:巡逻30米 3：巡逻40米 4：巡逻60米 5：海监1500
        public int modelID { get; set; }
        public String modelName { get; set; }
        
        public CShipModel(int _modelID, String _modelName)
        {
            modelID = _modelID;
            modelName = _modelName;
        }
    }
}
