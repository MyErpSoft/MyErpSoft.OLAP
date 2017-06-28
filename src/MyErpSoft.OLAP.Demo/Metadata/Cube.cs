using System;

namespace MyErpSoft.OLAP.Metadata {

    /// <summary>
    /// 一个立方体的元数据描述信息。
    /// </summary>
    /// <remarks>
    /// <para>他是元数据描述中重要的根对象，他用来描述立方体是什么样的，您不能从 Cube 检索单元数据</para>
    /// <para>例如，我们可以按产品、地区和时间几个维度来描述公司的销售额（度量值），那么这些维度和度量值组成了立方体。</para>
    /// </remarks>
    public class Cube
#if NOT_INCLUDED
        : IMetadataObject 
#endif
        {

        /// <summary>
        /// 返回此对象的本地化显示名称。
        /// </summary>
        public string Caption {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回此对象的本地化描述性文本。
        /// </summary>
        public string Description {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回此立方体的所有成员类型的维度。
        /// </summary>
        /// <remarks>
        /// <para>Dimensions 属性不包含 Measures 维度。</para>
        /// </remarks>
        public DimensionCollection Dimensions {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回此立方体的所有度量值 成员。
        /// </summary>
        public MeasureCollection Measures {
            get { throw new NotImplementedException(); }
        }

#if NOT_INCLUDED
        /// <summary>
        /// 获取 立方体 的名称。
        /// </summary>
        public string Name {
            get {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 返回 立方体 的唯一识别名称。
        /// </summary>
        public string UniqueName {
            get {
                throw new NotImplementedException();
            }
        }
#endif
    }
}
