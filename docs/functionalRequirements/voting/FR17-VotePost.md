## FR-17 — Vote on Post

## Description
An authenticated user should be able to upvote a post. Voting again on the same post removes the vote (toggle).

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target post exists and is published.
- The post does not belong to the authenticated user.

## Main flow
1. User navigates to the post page or feed.
2. User clicks the upvote button on the post.
3. System registers the vote associated with the user and the post.
4. System updates the vote count displayed on the post.

## Alternative flows

**AF-01 — User removes the vote**
At step 2, if the user has already voted on the post, the system removes the vote and decrements the vote count.

**AF-02 — Post no longer available**
At step 3, if the post was deleted between navigation and submission, the system displays an error and does not register the vote.

## Post-conditions
- Vote is persisted and associated with the user and the post.
- The post's vote count reflects the change.

## Requires
- FR-02 — Login
- FR-10 — Create Post

## Side effects

## Priority
High

## Status
Draft
