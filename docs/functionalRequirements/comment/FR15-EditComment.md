## FR-15 — Edit Comment

## Description
An authenticated user should be able to edit the content of one of their own comments.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The target comment exists.
- The comment belongs to the authenticated user.

## Main flow
1. User navigates to the post page.
2. User clicks the edit button on their own comment.
3. System loads the current comment content into an editable input field.
4. User edits the comment content.
5. User submits the changes.
6. System validates the content.
7. System updates the comment and displays it on the page.

## Alternative flows

**AF-01 — Empty content**
At step 6, if the content is empty, the system prevents submission and displays a message indicating that the comment cannot be empty.

**AF-02 — Content unchanged**
At step 5, if the content is identical to the original, the system discards the submission and closes the edit input without making any changes.

**AF-03 — Comment no longer available**
At step 6, if the comment was deleted between navigation and submission, the system displays an error and does not update the comment.

## Post-conditions
- Comment is updated and persisted.
- The updated comment is displayed on the post page without a full page reload.
- The comment displays an "edited" indicator.

## Requires
- FR-02 — Login
- FR-13 — View Post
- FR-14 — Create Comment

## Side effects

## Priority
Medium

## Status
Draft
