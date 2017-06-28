namespace MyErpSoft.OLAP.Metadata {

    /// <summary>
    /// 定义了成员的类型信息。
    /// </summary>
    /// <remarks>
    /// <para>此枚举值适用了位运算，从右往左 第一位，如果是1，那么表示成员，第二位表示是度量值</para>
    /// </remarks>
    public enum MemberType {

        /// <summary>成员类型未知。 0000 0000</summary>
        Unknown = 0x0,

        /// <summary>该成员是常规成员。 0000 0001</summary>
        Regular = 0x1,

        /// <summary>该成员是度量值。 0000 0010</summary>
        Measure = 0x2,

        /// <summary>该成员是特殊的 All 成员。 0000 0101</summary>
        All = 0x5,

#if CONTENTIOUS
#endif

#if NOT_INCLUDED
        /// <summary>该成员是特殊的 null 成员。 0000 1001</summary>
        Null = 0x9,

        /// <summary>该成员是计算成员或计算度量值。 0000 0110</summary>
        Formula = 0x6,
#endif

    }
}
