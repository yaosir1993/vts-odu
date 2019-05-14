using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace vts_odu
{
    class YimaEncInfoClass
    {
    }

    class M_MAP_LAYER_DISPLAY_INFO_MODEL
    {
        private int _iUseModelType;//0=不使用任何模式、1=使用分层显示、2=（使用基本、全部、完全显示）
        private int _iMaxScale;
        private int _iMinScale;
        private ArrayList _arrMaxHiddenLayerToken;        
        private ArrayList _arrMidHiddenLayerToken;
        private ArrayList _arrMinHiddenLayerToken;
        
        public M_MAP_LAYER_DISPLAY_INFO_MODEL()
        {
            _iUseModelType = 0;
            _iMinScale = 500000;
            _iMaxScale = 20000000;            
            _arrMaxHiddenLayerToken = new ArrayList();
            _arrMidHiddenLayerToken = new ArrayList();
            _arrMinHiddenLayerToken = new ArrayList();
        }

        /// <summary>
        /// 图幅的图层显示使用模式
        /// </summary>
        /// <param name="iModelType">使用模式：0=不使用任何模式、1=使用分层显示、2=（使用基本、全部、完全显示）</param>
        /// <param name="iMinScale">最大比例尺</param>
        /// <param name="iMaxScale">最小比例尺</param>
        public M_MAP_LAYER_DISPLAY_INFO_MODEL(int iModelType,int iMinScale,int iMaxScale)
        {
            _iUseModelType = iModelType;
            _iMinScale = iMinScale;
            _iMaxScale = iMaxScale;            
            _arrMaxHiddenLayerToken = new ArrayList();
            _arrMidHiddenLayerToken = new ArrayList();
            _arrMinHiddenLayerToken = new ArrayList();
        }

        public int iUseModelType
        {
            get { return _iUseModelType; }
            set { _iUseModelType = value; }
        }

        public int iMaxScale
        {
            get { return _iMaxScale; }
            set { _iMaxScale = value; }
        }

        public int iMinScale
        {
            get { return _iMinScale; }
            set { _iMinScale = value; }
        }

        public ArrayList arrMaxHiddenLayerToken
        {
            get { return _arrMaxHiddenLayerToken; }
            set { _arrMaxHiddenLayerToken = value; }
        }

        public ArrayList arrMidHiddenLayerToken
        {
            get { return _arrMidHiddenLayerToken; }
            set { _arrMidHiddenLayerToken = value; }
        }

        public ArrayList arrMinHiddenLayerToken
        {
            get { return _arrMinHiddenLayerToken; }
            set { _arrMinHiddenLayerToken = value; }
        }
    }
}
