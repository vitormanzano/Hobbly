## FR-14 — Create Comment

## Description
An authenticated user should be able to comment on a post or reply to an existing comment.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target post exists and is published.
- If replying, the target comment exists.

## Main flow
1. User navigates to the post page.
2. User clicks the comment input field below the post.
3. User types the comment content.
4. User submits the comment.
5. System validates the content.
6. System creates the comment associated with the post and displays it on the page.

## Alternative flows

**AF-01 — Reply to a comment**
At step 2, if the user clicks "Reply" on an existing comment instead of the main input field, the system opens a reply input nested under that comment. Steps 3–6 follow normally. The created comment is associated with the parent comment and the post.

**AF-02 — Empty content**
At step 5, if the content is empty, the system prevents submission and displays a message indicating that the comment cannot be empty.

**AF-03 — Post no longer available**
At step 5, if the post was deleted between navigation and submission, the system displays an error and does not create the comment.

## Post-conditions
- Comment is created and persisted, associated with the post (and parent comment, if a reply).
- The new comment is displayed on the post page without a full page reload.

## Requires
- FR-02 — Login
- FR-13 — View Post

## Side effects
- The post's comment count is incremented.

## Priority
High

## Status
Draft
