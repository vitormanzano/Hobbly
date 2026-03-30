## FR-17 — Vote on Post

## Description
An authenticated user should be able to upvote or downvote a post. Voting again with the same type removes the vote (toggle). Voting with the opposite type switches the vote.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target post exists and is published.
- The post does not belong to the authenticated user.

## Main flow
1. User navigates to the post page or feed.
2. User clicks the upvote or downvote button on the post.
3. System registers the vote associated with the user and the post.
4. System updates the vote count displayed on the post.

## Alternative flows

**AF-01 — User removes the vote**
At step 2, if the user clicks the same vote type they already cast, the system removes the vote and updates the vote count.

**AF-02 — User switches the vote**
At step 2, if the user clicks the opposite vote type from the one already cast, the system replaces the previous vote and updates the vote count accordingly.

**AF-03 — Post no longer available**
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
