## FR-07 — Search Hobby

## Description
A visitor should be able to search for a hobby and view the most popular posts associated with it.

## Actors
Visitor

## Pre-conditions
- The system has at least one hobby registered.
- The system has at least one post registered.

## Main flow
1. User navigates to the home page.
2. User selects the search field.
3. User types a hobby name in the search field.
4. System displays the most upvoted posts for that hobby.

## Alternative flows

**AF-01 — Hobby found but no posts**
At step 4, if the hobby exists but has no posts, the system informs the user that there are no posts for that hobby yet.

**AF-02 — Hobby not found**
At step 4, if the typed term does not match any registered hobby, the system displays a message suggesting the user check the spelling or browse available hobbies.

## Post-conditions
- The user can see the most popular posts for the searched hobby.

## Requires
FR-06 — Manage Hobbies

## Side effects

## Priority
High

## Status
Draft
