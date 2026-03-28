## FR-20 — Search Posts

## Description
Any user should be able to search for posts by keyword, filtering results by hobby or post type.

## Actors
Visitor (unauthenticated user), Authenticated user

## Pre-conditions
- The system has at least one post registered.

## Main flow
1. User types a keyword in the search field.
2. System returns posts whose title or description match the keyword, ordered by relevance.
3. System displays the matching posts.

## Alternative flows

**AF-01 — No results found**
At step 2, if no posts match the keyword, the system displays a message indicating no results were found.

**AF-02 — Filter by hobby**
At step 2, if the user selects a hobby filter, the system restricts results to posts associated with that hobby.

**AF-03 — Filter by post type**
At step 2, if the user selects a post type filter, the system restricts results to posts of that type.

## Post-conditions
- Matching posts are displayed to the user.

## Requires
- FR-10 — Create Post

## Side effects

## Priority
Medium

## Status
Draft
