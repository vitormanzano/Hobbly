## FR-19 — View Profile

## Description
Any user should be able to view the public profile of another user, including their username, description, hobbies, and posts.

## Actors
Visitor (unauthenticated user), Authenticated user

## Pre-conditions
- The target user account exists.

## Main flow
1. User navigates to a profile page.
2. System loads and displays the user's public information: username, description, hobbies, and posts.

## Alternative flows

**AF-01 — User not found**
At step 2, if the target account does not exist, the system displays a not found message.

## Post-conditions
- The target user's public profile is displayed.

## Requires
- FR-01 — Create Account

## Side effects

## Priority
Medium

## Status
Draft
