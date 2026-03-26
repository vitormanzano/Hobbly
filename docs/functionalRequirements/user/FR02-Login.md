# FR-02 — Login

## Description
A user should be able to log in by providing a registered email and the correct password.

## Actors
Visitor (unauthenticated user)

## Pre-conditions
- The visitor is not authenticated.
- The visitor has a registered account.

## Main flow
1. Visitor navigates to the login page.
2. Visitor fills in the email and password fields.
3. System validates the provided credentials.
4. System authenticates the user and initiates a session.
5. User is redirected to the main page.

## Alternative flows

**AF-01 — Invalid credentials**
At step 3, if the provided email and password combination does not match any existing account, the system displays a generic error message indicating the credentials are incorrect, without specifying which field is wrong. The form remains open for correction.

**AF-02 — Blank required fields**
At step 3, if any required field is left blank, the system highlights the offending fields and displays descriptive error messages. Authentication is not performed.

## Post-conditions
- User session is initiated.
- User is redirected to the main page.

## Requires
FR-01 — Create Account

## Side effects
—

## Priority
High

## Status
Draft



