# FR-06 — Manage Hobbies

## Description
An authenticated user should be able to add and remove hobbies from their profile. When adding, the system suggests existing hobbies via autocomplete. If no suitable hobby is found, the user can create a new one.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.

## Main flow
1. User navigates to their profile page.
2. User selects the option to add a hobby.
3. User types a hobby name in the search field.
4. System displays matching suggestions via autocomplete.
5. User selects a hobby from the suggestions.
6. System adds the selected hobby to the user's profile.

## Alternative flows

**AF-01 — Hobby not found**
At step 4, if no suggestions match the typed input, the system displays an option to create a new hobby with the provided name. The user confirms the creation, and the new hobby is added to the platform and to the user's profile.

**AF-02 — Remove hobby**
At any point on the profile page, the user can remove a hobby from their profile. The system removes the association between the user and the hobby. The hobby itself is not deleted from the platform.

## Post-conditions
- The user's hobby list is updated and persisted.

## Requires
FR-01 — Create Account
FR-02 — Login

## Side effects
- If a new hobby is created (AF-01), it becomes available to all users via autocomplete.

## Priority
High

## Status
Draft
