using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyErpSoft.OLAP.Metadata
{
    public class MemberCollection : ReadOnlyCollection<Member>
    {
        internal MemberCollection(IList<Member> list)
            :base(list){
        }
    }
}
