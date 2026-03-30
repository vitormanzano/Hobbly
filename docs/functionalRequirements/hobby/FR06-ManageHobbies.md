# FR-06 — Manage Hobbies

## Description
An authenticated user should be able to add and remove hobbies from their profile. When adding a hobby, the user must also inform how long they have been practicing it. When adding, the system suggests existing hobbies via autocomplete. If no suitable hobby is found, the user can suggest a new one for admin approval.

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
6. User selects how long they have been practicing the hobby from a fixed scale: Less than 6 months, Less than 1 year, 1 year, 2 years, 3 years, 4 years, 5+ years, 10+ years.
7. System adds the selected hobby and practice time to the user's profile.

## Alternative flows

**AF-01 — Hobby not found**
At step 4, if no suggestions match the typed input, the system displays an option to suggest a new hobby with the provided name. The suggestion is submitted for admin approval and is not immediately available on the platform.

**AF-02 — Remove hobby**
At any point on the profile page, the user can remove a hobby from their profile. The system removes the association between the user and the hobby. The hobby itself is not deleted from the platform.

## Post-conditions
- The user's hobby list is updated and persisted.

## Requires
FR-01 — Create Account
FR-02 — Login

## Side effects
- If a new hobby is suggested (AF-01), it enters a pending state and becomes available only after admin approval (FR-23).

## Priority
High

## Status
Draft
