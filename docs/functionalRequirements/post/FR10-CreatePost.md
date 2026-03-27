## FR-10 — Create Post

## Description
An authenticated user should be able to create a post providing the title, description, hobby and the type of post.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.

## Main flow
1. User navigates to the main page.
2. User clicks the create post button.
3. System shows the create post page.
4. User fills in title, description, hobby and the type of the post.
5. System validates the data.
6. System creates the post.
7. User is redirected to the created post page.

## Alternative flows

**AF-01 — Hobby not selected**
At step 5, if no hobby is selected, the system prevents submission and displays a message indicating that hobby is a required field.

## Post-conditions
- Post is created and persisted.
- User is redirected to the created post page.

## Requires
- FR-02 — Login
- FR-06 — Manage Hobbies

## Side effects

## Priority
High

## Status
Draft
