# FR-04 — Delete Account

## Description
An authenticated user should be able to permanently delete their account and all associated data.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.

## Main flow
1. User navigates to the account settings page.
2. User selects the option to delete their account.
3. System displays a confirmation dialog warning that the action is irreversible.
4. User confirms the deletion by providing their current password.
5. System validates the provided password.
6. System permanently deletes the account and all associated data.
7. Session is terminated.
8. User is redirected to the home page.

## Alternative flows

**AF-01 — User cancels deletion**
At step 3, if the user dismisses the confirmation dialog, the process is aborted and no changes are made.

**AF-02 — Incorrect password**
At step 5, if the provided password does not match the current account password, the system displays an error message and the account is not deleted.

## Post-conditions
- Account and all associated data are permanently deleted.
- Session is terminated.
- User is redirected to the home page.

## Requires
FR-01 — Create Account
FR-02 — Login

## Side effects
- All posts, votes, and interactions associated with the account are permanently removed.

## Priority
Medium

## Status
Draft




