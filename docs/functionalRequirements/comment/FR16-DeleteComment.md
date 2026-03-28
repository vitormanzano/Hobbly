## FR-16 — Delete Comment

## Description
An authenticated user should be able to delete their own comment.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target comment exists.
- The comment belongs to the authenticated user.

## Main flow
1. User navigates to the post page.
2. User clicks the delete button next to their comment.
3. System displays a confirmation dialog warning that this action cannot be undone and that all nested replies will also be deleted.
4. User confirms the deletion.
5. System deletes the comment and all its nested replies.
6. The comment is removed from the post page without a full page reload.

## Alternative flows

**AF-01 — User does not confirm deletion**
At step 4, if the user cancels the confirmation dialog, the system closes the dialog and does not delete the comment.

**AF-02 — Comment no longer available**
At step 5, if the comment was deleted between navigation and confirmation, the system displays an error and removes the comment from the page.

## Post-conditions
- Comment and all its nested replies are deleted and no longer persisted.

## Requires
- FR-02 — Login
- FR-13 — View Post
- FR-14 — Create Comment

## Side effects
- The post's comment count is decremented by the number of deleted comments (including nested replies).

## Priority
High

## Status
Draft
