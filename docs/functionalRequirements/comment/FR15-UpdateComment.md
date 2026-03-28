## FR-15 — Update Comment

## Description
An authenticated user should be able to update the content of one of yours comments.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target comment exists and is published.

## Main flow
1. User navigates to the post page.
2. User clicks to update the post.
3. User types the comment content.
4. User submits the comment.
5. System validates the content.
6. System updates the comment associated with the post and displays it on the page.

## Alternative flows

**AF-02 — Empty content**
At step 5, if the content is empty, the system prevents submission and displays a message indicating that the comment cannot be empty.

**AF-03 — Post no longer available**
At step 5, if the post was deleted between navigation and submission, the system displays an error and does not create the comment.

## Post-conditions
- Comment is updated and persisted, associated with the post (and parent comment, if a reply).
- The updated comment is displayed on the post page without a full page reload.

## Requires
- FR-02 — Login
- FR-13 — View Post
- FR14 - Create Comment

## Side effects

## Priority
High

## Status
Draft

