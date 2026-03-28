## FR-11 — Edit Post

## Description
An authenticated user can edit a post within one hour of its creation. After that, the post can no longer be edited.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The user is the author of the post.
- The post was created less than one hour ago.

## Main flow
1. User navigates to their post page.
2. User clicks the edit button.
3. System shows the edit form pre-filled with the current post data.
4. User updates the desired fields.
5. System validates the data.
6. System saves the changes.
7. User is redirected to the updated post page.

## Alternative flows

**AF-01 — Edit window expired**
At step 2, if more than one hour has passed since the post was created, the system does not display the edit button.

**AF-02 — Invalid data**
At step 5, if any field fails validation, the system highlights the offending fields and displays error messages. The post is not updated.

## Post-conditions
- Post is updated and persisted.
- User is redirected to the updated post page.

## Requires
- FR-02 — Login
- FR-10 — Create Post

## Side effects

## Priority
Medium

## Status
Draft
