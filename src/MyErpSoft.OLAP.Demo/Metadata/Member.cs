using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyErpSoft.OLAP.Metadata {

    public class Member : IMetadataObject {

        /// <summary>
        /// 返回此成员的本地化显示名称。
        /// </summary>
        public string Caption {
            get { throw new NotImplementedException();  }
        }

        /// <summary>
        /// 返回是否包含子成员，这比访问Children然后访问Count要快。
        /// </summary>
        public bool HasChildren {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回直接一级的子成员集合。
        /// </summary>
        /// <remarks>
        /// <para>以国家、省和市这样的3级成员为例，市是最末级成员，他的Children永远返回一个没有任何成员的空MemberCollection.</para>
        /// <para>而省和国家，都有可能包含子成员，例如‘安徽省’这个成员其Children可能返回‘宣城’、‘芜湖’等市级成员。</para>
        /// <para>建议在运算时提前判断HasChildren来提高性能。</para>
        /// </remarks>
        public MemberCollection Children {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 一个 int，它包含 Member 所在的级别的父层次结构内的序号位置。
        /// </summary>
        /// <remarks>
        /// <para>此属性在功能上等效于 Member.ParentLevel.LevelNumber，但是它提供更好的性能。 有关详细信息，请参阅 LevelNumber。</para>
        /// </remarks>
        public int LevelDepth { get; }

        /// <summary>
        /// 获取 Member 的名称。
        /// </summary>
        public string Name {
            get {
                throw new NotImplementedException();
            }
        }

        public string UniqueName {
            get {
                throw new NotImplementedException();
            }
        }
    }
}
