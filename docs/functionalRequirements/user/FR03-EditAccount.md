# FR-03 — Edit Account

## Description
An authenticated user should be able to edit their account information, including username, description, email, and password. All fields are optional — only the provided fields will be updated.

## Actors
Authenticated user

## Pre-conditions
- The user is authenticated.

## Main flow
1. User navigates to the account settings page.
2. User edits one or more fields (username, description, email, or password).
3. System validates the provided data.
4. System updates the account with the new information.
5. User is redirected to the account page with a success message.

## Alternative flows

**AF-01 — Email already registered**
At step 3, if the provided email is already associated with an existing account, the system displays an error message indicating the email is unavailable. The form remains open for correction.

**AF-02 — Username already taken**
At step 3, if the provided username is already associated with an existing account, the system displays an error message indicating the username is unavailable. The form remains open for correction.

**AF-03 — Invalid data**
At step 3, if any provided field fails validation (e.g., malformed email, password shorter than 8 characters), the system highlights the offending fields and displays descriptive error messages. The account is not updated.

**AF-04 — Password change requires current password**
At step 2, if the user attempts to set a new password, the system requires the current password to be provided as confirmation. If the current password is incorrect, the system displays an error message and the password is not updated.

## Post-conditions
- Account is updated and persisted.
- User is redirected to the account page.

## Requires
FR-01 — Create Account
FR-02 — Login

## Side effects
—

## Priority
Medium

## Status
Draft



