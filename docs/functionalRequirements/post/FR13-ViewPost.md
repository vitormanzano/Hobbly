## FR-13 — View Post

## Description
A visitor should be able to view a post and its comments.

## Actors
Visitor

## Pre-conditions
- The post exists.

## Main flow
1. User navigates to the post page.
2. System displays the post title, description, type, hobby, author and comments.

## Alternative flows

**AF-01 — Post not found**
At step 2, if the post does not exist or has been deleted, the system displays a message indicating the post was not found.

## Post-conditions
- The user can read the post and its comments.

## Requires
- FR-10 — Create Post

## Side effects

## Priority
High

## Status
Draft
