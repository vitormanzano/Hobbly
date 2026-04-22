# FR-24 — Forgot Password

## Description
A visitor who has already created an account should be able to recover access when they forget their password. The system sends a single-use, time-limited link to the account's registered email, allowing the user to set a new password.

## Actors
Visitor (unauthenticated user)

## Pre-conditions
- The visitor is not authenticated.
- The visitor has an account previously registered on the platform.

## Main flow
1. Visitor navigates to the login page.
2. Visitor clicks the "Forgot password" link.
3. System displays a page requesting the account's email.
4. Visitor submits the email associated with their account.
5. System generates a single-use password reset link, valid for 5 minutes, and sends it to the provided email.
6. System displays a confirmation message stating that an email has been sent if the address is registered.
7. Visitor opens the email and clicks the reset link.
8. System displays a page requesting the new password, entered twice for confirmation.
9. Visitor submits the new password.
10. System validates the new password and, if valid, updates the account password and invalidates the reset link.
11. Visitor is redirected to the login page with a success message.

## Alternative flows

**AF-01 — Email not registered**
At step 4, if the provided email is not associated with any account, the system still displays the same confirmation message as in step 6 and does not send any email. This prevents disclosing whether an email is registered on the platform.

**AF-02 — Malformed email**
At step 4, if the provided email is not a valid email format, the system highlights the field and displays a validation error. No email is sent.

**AF-03 — Passwords do not match**
At step 9, if the two password fields do not match, the system displays an error message and does not update the password. The reset link remains valid until it expires or is successfully used.

**AF-04 — Invalid new password**
At step 10, if the new password fails validation (e.g., shorter than 4 characters), the system highlights the field and displays the password requirements. The password is not updated.

**AF-05 — Expired link**
At step 7, if the reset link is accessed more than 5 minutes after being issued, the system displays an error indicating the link has expired and prompts the visitor to request a new one.

**AF-06 — Link already used**
At step 7, if the reset link has already been used to update a password, the system displays an error indicating the link is no longer valid.

## Post-conditions
- The account password is updated and persisted.
- The reset link is invalidated and cannot be reused.
- The visitor can log in with the new password.

## Requires
- FR-01 — Create Account
- FR-02 — Login

## Side effects
- A password reset email is sent to the provided address when it matches a registered account.

## Priority
Medium

## Status
Draft
