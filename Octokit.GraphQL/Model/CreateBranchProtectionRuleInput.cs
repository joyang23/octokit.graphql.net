namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateBranchProtectionRule
    /// </summary>
    public class CreateBranchProtectionRuleInput
    {
        public ID RepositoryId { get; set; }

        public string Pattern { get; set; }

        public bool? RequiresApprovingReviews { get; set; }

        public int? RequiredApprovingReviewCount { get; set; }

        public bool? RequiresCommitSignatures { get; set; }

        public bool? IsAdminEnforced { get; set; }

        public bool? RequiresStatusChecks { get; set; }

        public bool? RequiresStrictStatusChecks { get; set; }

        public bool? RequiresCodeOwnerReviews { get; set; }

        public bool? DismissesStaleReviews { get; set; }

        public bool? RestrictsReviewDismissals { get; set; }

        public IEnumerable<ID> ReviewDismissalActorIds { get; set; }

        public bool? RestrictsPushes { get; set; }

        public IEnumerable<ID> PushActorIds { get; set; }

        public IEnumerable<string> RequiredStatusCheckContexts { get; set; }

        public string ClientMutationId { get; set; }
    }
}