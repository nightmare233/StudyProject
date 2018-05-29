using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using LinqKit;

namespace StudyProject.LamdaExpress
{
    public class PredicateBuilderDemo
    {
        public void PredicateBuilderDemo1()
        {
            var list = Enumerable.Range(1, 100);
            var where = PredicateBuilder.True<int>();
            where = where.And(x => x >= 50);
            where = where.And(x => x <= 70);
            var subwhere = PredicateBuilder.False<int>();
            subwhere = subwhere.Or(x => x == 60);
            subwhere = subwhere.Or(x => x == 61);
            where = where.And(subwhere);
            var res = list.Where(where.Compile());
        }
    }
}
