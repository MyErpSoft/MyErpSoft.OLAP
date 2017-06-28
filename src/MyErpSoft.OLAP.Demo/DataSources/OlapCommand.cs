/*
MDX为MultiDimensional Expressions的缩写，多维表达式，是标准的OLAP查询语言。

在MDX中，SELECT语句指定一个结果集，其中包含从多维数据集返回的多维数据的子集。要指定结果集，MDX查询必须包含以下信息：
   * 希望结果集包含的轴数。您可以在MDX查询中最多指定128个轴。
   * 要包含在MDX查询的每个轴上的一组成员或元组。
   * 设置MDX查询上下文的多维数据集的名称。
   * 要包括在切片器轴上的一组成员或元组。有关切片器和查询轴的更多信息，请参阅使用查询和切片器轴（MDX）限制查询。

要识别查询轴，要查询的多维数据集和切片器轴，MDX SELECT语句使用以下子句：
   * 一个SELECT子句，用于确定MDX SELECT语句的查询轴。有关SELECT子句中查询轴的构造的更多信息，请参阅指定查询轴（MDX）的内容。
   * 一个用于确定哪个多维数据集将被查询的FROM子句。有关FROM子句的更多信息，请参见SELECT语句（MDX）。
   * 一个可选的WHERE子句，用于确定在切片器轴上使用哪些成员或元组来限制返回的数据。有关在WHERE子句中构造切片轴的更多信息，请参阅指定切片轴（MDX）的内容。

 注意：
 由于能力有限，无法在现有版本中支持太多复杂的语法和功能，因此必须在执行的语句的前包含 /* v1 *&/ 这样的字符（注意后面*&/ 之间实际没有&，因为现在的文本是注释）
 这包含两个层面的意思，
    一、只能支持很简单的语法，功能有限；
    二、即使简单的mdx语法，可能现在程序无法做到标准化规范中的语义，输出的结果缺少数据或者包含多余的数据。
通过加入版本号，保证在产品不断升级的过程中，不会造成旧的语句执行的语义发生改变，同时也不会造成新开发的功能为了兼容旧版本而做出妥协。
 */
using System;

namespace MyErpSoft.OLAP.DataSources {
    class OlapCommand
    {
        /// <summary>
        /// 获取或设置 OlapCommand 使用的 OlapConnection。
        /// </summary>
        public OlapConnection Connection { get; set; }

        /// <summary>
        /// 运行 OlapCommand 并且返回 OlapDataReader。
        /// </summary>
        /// <returns></returns>
        public OlapDataReader ExecuteReader() {
            throw new NotImplementedException();
        }
    }
}
