﻿using System.Linq.Expressions;

namespace Core.Specifications
{
	public interface ISpecification<T>
	{
        /// <summary>
        /// Criteria expression
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }

        /// <summary>
        /// Includes collection to load related data
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }

        /// <summary>
        /// Order entities
        /// </summary>
        Expression<Func<T, object>> OrderBy { get; }
    }
}

