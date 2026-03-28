## FR-22 — Notifications

## Description
An authenticated user should receive notifications when other users interact with their content.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.

## Main flow
1. Another user interacts with the authenticated user's content (comment on post, reply to comment, or vote on post/comment).
2. System creates a notification associated with the target user.
3. System displays the notification count in the user's notification indicator.
4. User clicks the notification indicator.
5. System displays the list of notifications ordered by most recent.

## Alternative flows

**AF-01 — No notifications**
At step 5, if the user has no notifications, the system displays a message indicating there are no notifications yet.

**AF-02 — Mark all as read**
At step 5, the user can mark all notifications as read. The system clears the notification count indicator.

## Post-conditions
- Notifications are displayed and persisted for the user.

## Requires
- FR-02 — Login
- FR-14 — Create Comment
- FR-17 — Vote on Post
- FR-18 — Vote on Comment

## Side effects

## Priority
Medium

## Status
Draft
