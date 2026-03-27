## FR-12 — Delete Post

## Description
An authenticated user should be able to delete their own post at any time.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The user is the author of the post.

## Main flow
1. User navigates to the post page.
2. User clicks the delete button.
3. System displays a confirmation message warning that this action cannot be undone.
4. User confirms the deletion.
5. System deletes the post along with all associated comments and votes.
6. User is redirected to the main page.

## Alternative flows

**AF-01 — User cancels deletion**
At step 4, if the user cancels the confirmation, the system dismisses the dialog and the post remains unchanged.

## Post-conditions
- Post and all associated comments and votes are permanently deleted.
- User is redirected to the main page.

## Requires
- FR-02 — Login
- FR-10 — Create Post

## Side effects
- All comments and votes associated with the post are permanently deleted.

## Priority
Medium

## Status
Draft
