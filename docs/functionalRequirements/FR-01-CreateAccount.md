# FR-01 — Create Account

## Description
An anonymous user should be able to create an account by providing a username, email, and password.

## Actors
Visitor (unauthenticated user)

## Pre-conditions
- The visitor is not authenticated.
- The provided email is not already registered.

## Main flow
1. Visitor navigates to the sign-up page.
2. Visitor fills in username, email, and password fields.
3. System validates the input data.
4. System creates the account.
5. System sends a welcome email to the provided address.
6. Visitor is redirected to the login page.

## Alternative flows

**AF-01 — Email already registered**
At step 3, if the provided email is already associated with an existing account, the system displays an error message indicating the email is unavailable. The form remains open for correction.

**AF-02 — Invalid data**
At step 3, if any field fails validation (e.g., malformed email, password shorter than 4 characters, blank required field), the system highlights the offending fields and displays descriptive error messages. The account is not created.

## Post-conditions
- Account is created and persisted.
- Visitor is redirected to the login page.

## Requires
—

## Side effects
- A welcome email is sent to the registered address.

## Priority
High

## Status
Draft


