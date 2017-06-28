using System;
using System.Collections.Generic;
using System.Text;

namespace MyErpSoft.OLAP {

    /// <summary>
    /// 表示作为查询结果返回的单元集。
    /// </summary>
    public class CellSet {

#if NOT_INCLUDED
        /// <summary>
        /// 获取包含 CellSet 的轴的 AxisCollection 类的实例。
        /// </summary>
        public AxisCollection Axes {
            get { throw new NotImplementedException(); }
        }

        public object GetValue(int[] indexs){
            throw new NotImplementedException();
        }

        public void SetValue(int[] indexs){
            throw new NotImplementedException();
        }

        public void ClearValue(int[] indexs){
            throw new NotImplementedException();
        }
#endif
    }
}
