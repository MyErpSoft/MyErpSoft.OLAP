namespace MyErpSoft.OLAP.Metadata {

    /// <summary>
    /// 元数据成员的基础接口。
    /// </summary>
    public interface IMetadataObject {

        /// <summary>
        /// 返回元数据对象的名称。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 返回元数据对象的唯一名称。
        /// </summary>
        string UniqueName { get; }
    }
}
