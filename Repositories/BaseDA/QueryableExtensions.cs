using System.Collections;
using System.Linq.Expressions;
using System.Reflection;

namespace Repositories.BaseDA
{
	public static class QueryableExtensions
	{
		/// <summary>
		/// Maps the supplied entity to the specified property of the received 
		/// entity and eliminates circular references caused by relationships in Entity Framework Core.
		/// </summary>
		/// <typeparam name="TEntity">Type of source entity</typeparam>
		/// <typeparam name="TProperty">Type of related entity.</typeparam>
		/// <param name="query">IQueryable query of entities.</param>
		/// <param name="includeExpression">Expression specifying the related entity to be included.</param>
		/// <param name="destinationEntityName">Name of the related entity of destination.</param>
		/// <returns>Query <see cref="IQueryable"/> with the related entity included.</returns>

		public static IQueryable<TEntity> AndClean<TEntity, TProperty>(this IQueryable<TEntity> query, Expression<Func<TEntity, TProperty>> includeExpression, string destinationEntityName)
			where TEntity : class
		{
			foreach (var entity in query)
			{
				var navigationProperty = includeExpression.Compile()(entity);
				var supliedExpression = includeExpression.Body as MemberExpression;
				var sourceEntityName = supliedExpression.Member.Name;

				if (navigationProperty != null)
				{
					MapAssociatedEntity(navigationProperty, entity, sourceEntityName, destinationEntityName);
					PropertyInfo entityProperty = entity.GetType().GetProperty(sourceEntityName);
					entityProperty.SetValue(entity, null);
				}
			}

			return query;
		}

		private static void MapAssociatedEntity(object navigationProperty, object entity, string sourceEntityName, string destinationEntityName)
		{
			PropertyInfo destinationProperty = entity.GetType().GetProperty(destinationEntityName);

			if (destinationProperty != null)
			{
				foreach (var item in (IEnumerable)navigationProperty)
				{
					PropertyInfo sourceProperty = item.GetType().GetProperty(destinationEntityName);

					if (sourceProperty != null)
					{
						var sourceValue = sourceProperty.GetValue(item);

						if (sourceValue != null)
						{
							var destinationValue = destinationProperty.GetValue(entity);
							if (destinationValue == null)
							{
								destinationValue = Activator.CreateInstance(destinationProperty.PropertyType);
								destinationProperty.SetValue(entity, destinationValue);
							}
							if (sourceValue is IEnumerable sourceCollection)
							{
								foreach (var sourceItem in sourceCollection)
								{
									destinationProperty.PropertyType.GetMethod("Add").Invoke(destinationValue, new[] { sourceItem });
								}
							}
							else
							{
								destinationProperty.PropertyType.GetMethod("Add").Invoke(destinationValue, new[] { sourceValue });
							}
							ClearEntity(sourceValue, sourceEntityName);
						}
					}
				}
			}
		}

		private static void ClearEntity(object? sourceValue, string sourceEntityName)
		{
			PropertyInfo sourceAssociatedProperty = sourceValue.GetType().GetProperty(sourceEntityName);
			if (sourceAssociatedProperty != null)
			{
				sourceAssociatedProperty.SetValue(sourceValue, null);
			}
		}
	}
}
