﻿using System.Linq;

namespace BookSearcher
{
    public class AndCondition : LogicCondition
    {
        public AndCondition(params IBookMatchCondition[] conditions)
            : base(conditions)
        {
        }

        public override bool IsMatch(Book book)
        {
            return Conditions.All(condition => condition.IsMatch(book));
        }
    }
}