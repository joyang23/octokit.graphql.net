namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnPayload : QueryableValue<MoveProjectColumnPayload>
    {
        public MoveProjectColumnPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The new edge of the moved column.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `columnEdge` will change from `ProjectColumnEdge!` to `ProjectColumnEdge`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public ProjectColumnEdge ColumnEdge => this.CreateProperty(x => x.ColumnEdge, Octokit.GraphQL.Model.ProjectColumnEdge.Create);

        internal static MoveProjectColumnPayload Create(Expression expression)
        {
            return new MoveProjectColumnPayload(expression);
        }
    }
}