using System;

namespace MyErpSoft.OLAP.Metadata {

    public class Member
#if NOT_INCLUDED
        : IMetadataObject 
#endif
        {

        /// <summary>
        /// 返回此对象的本地化显示名称。
        /// </summary>
        public string Caption {
            get { throw new NotImplementedException();  }
        }

        /// <summary>
        /// 返回此对象的本地化描述性文本。
        /// </summary>
        public string Description {
            get { throw new NotImplementedException(); }
        }

#if CONTENTIOUS
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
        /// 获取对包含 Member 的父 Member（如果适用）的引用。
        /// </summary>
        /// <remarks>
        /// <para>如果成员存在父Member，将返回他，否则返回null.</para>
        /// <para>todo:在多种管理视角的情况下，某个组织在不同的管理视角下是否隶属于不同的父下，类似的，企业在发展阶段重修修订组织的隶属关系，即多个版本。</para>
        /// </remarks>
        public Member Parent {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回成员所属的层级（如果适用）。
        /// </summary>
        /// <remarks>
        /// <para>例如一个成员‘安徽省’，属于‘省’这个层级；‘一月’属于‘月份’这个层级。</para>
        /// </remarks>
        public Level Level {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 返回成员的类型信息，例如是普通成员、度量值、还是其他。
        /// </summary>
        public MemberType MemberType {
            get { throw new NotImplementedException(); }
        }
#endif

#if NOT_INCLUDED
        /// <summary>
        /// 一个 int，它包含 Member 所在的级别的父层次结构内的序号位置。
        /// </summary>
        /// <remarks>
        /// <para>此属性在功能上等效于 Member.ParentLevel.LevelNumber，但是它提供更好的性能。 有关详细信息，请参阅 LevelNumber。</para>
        /// <para>todo:在没有明确需求前不建议对外提供此功能。</para>
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
#endif
    }
}
