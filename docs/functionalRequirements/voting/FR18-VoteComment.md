## FR-18 — Vote on Comment

## Description
An authenticated user should be able to upvote a comment. Voting again on the same comment removes the vote (toggle).

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target comment exists.
- The comment does not belong to the authenticated user.

## Main flow
1. User navigates to the post page.
2. User clicks the upvote button on a comment.
3. System registers the vote associated with the user and the comment.
4. System updates the vote count displayed on the comment.

## Alternative flows

**AF-01 — User removes the vote**
At step 2, if the user has already voted on the comment, the system removes the vote and decrements the vote count.

**AF-02 — Comment no longer available**
At step 3, if the comment was deleted between navigation and submission, the system displays an error and does not register the vote.

## Post-conditions
- Vote is persisted and associated with the user and the comment.
- The comment's vote count reflects the change.

## Requires
- FR-02 — Login
- FR-14 — Create Comment

## Side effects

## Priority
High

## Status
Draft
