namespace Octoqit
{
    using System.Linq;
    using System.Linq.Expressions;
    using LinqToGraphQL;
    using LinqToGraphQL.Builders;

    /// <summary>
    /// Represents a 'closed' event on a given issue or pull request.
    /// </summary>
    public class ClosedEvent : QueryEntity
    {
        public ClosedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor (user) associated with the event.
        /// </summary>
        public User Actor => this.CreateProperty(x => x.Actor, Octoqit.User.Create);

        /// <summary>
        /// Identifies the commit associated with the 'closed' event.
        /// </summary>
        public Commit Commit => this.CreateProperty(x => x.Commit, Octoqit.Commit.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        public string Id { get; }

        /// <summary>
        /// Identifies the issue associated with the event.
        /// </summary>
        public Issue Issue => this.CreateProperty(x => x.Issue, Octoqit.Issue.Create);

        /// <summary>
        /// Identifies the repository associated with the event.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octoqit.Repository.Create);

        /// <summary>
        /// Identifies the event type associated with the event.
        /// </summary>
        public IssueEventType Type { get; }

        internal static ClosedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new ClosedEvent(provider, expression);
        }
    }
}