## US-26 — Forgot Password

## Priority: Medium

## User Story
As a visitor who forgot my password, I want to reset it through my registered email, so that I can regain access to my account.

### Acceptance Criteria
- [ ] The visitor can access a "Forgot password" option from the login page.
- [ ] The visitor must provide the email associated with their account.
- [ ] The system sends a single-use password reset link to the provided email, valid for 5 minutes.
- [ ] The system displays the same confirmation message regardless of whether the email is registered, to prevent disclosing which emails exist on the platform.
- [ ] The visitor must type the new password twice, and the system rejects the change if the two values do not match.
- [ ] The system rejects a new password that fails validation rules.
- [ ] The reset link cannot be used more than once.
- [ ] The reset link cannot be used after it expires.
- [ ] After a successful reset, the visitor can log in with the new password.
