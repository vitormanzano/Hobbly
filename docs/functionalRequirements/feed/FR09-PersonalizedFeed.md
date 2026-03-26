## FR-09 — View Personalized Feed

## Description
An authenticated user should be able to view a personalized feed mixing the most upvoted posts from their hobbies with the most upvoted posts from the platform.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.
- The system has at least one post registered.

## Main flow
1. User navigates to the home page.
2. System displays a mixed feed of the most upvoted posts from the user's hobbies and the most upvoted posts from the platform overall, ordered by votes descending.

## Alternative flows

**AF-01 — User has no hobbies**
At step 2, if the user has not added any hobbies to their profile, the system falls back to the public feed (FR-08) and suggests the user add hobbies to personalize their feed.

**AF-02 — No posts from user's hobbies**
At step 2, if the user's hobbies have no posts yet, the system falls back to the public feed (FR-08).

## Post-conditions
- The user can browse personalized content based on their hobbies.

## Requires
FR-02 — Login
FR-06 — Manage Hobbies
FR-08 — View Public Feed

## Side effects

## Priority
High

## Status
Draft
