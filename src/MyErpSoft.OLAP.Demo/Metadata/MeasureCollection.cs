using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyErpSoft.OLAP.Metadata
{
    public class MeasureCollection : ReadOnlyCollection<Measure> {
        internal MeasureCollection(IList<Measure> list)
            : base(list) {
        }
    }
}
