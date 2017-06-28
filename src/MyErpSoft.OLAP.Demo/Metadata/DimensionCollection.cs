using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyErpSoft.OLAP.Metadata {
    public class DimensionCollection : ReadOnlyCollection<Dimension> {
        internal DimensionCollection(IList<Dimension> list)
            : base(list) {
        }
    }
}
