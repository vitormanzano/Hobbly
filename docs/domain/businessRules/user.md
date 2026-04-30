# Business Rules for User

- BR01: An user should write a valid format email.
- BR02: An user should write a password with, at least, 4 characters.
- BR03: Email must be unique across the system.
- BR04: Username must be unique across the system.
- BR05: Username, email and password are required to create an account.
- BR06: Changing the password requires confirmation with the current password.
- BR07: Deleting an account requires confirmation with the current password.
- BR08: Account deletion is permanent and irreversible.
- BR09: When an account is deleted, its posts and comments are reassigned to "Deleted User".
- BR10: When an account is deleted, all votes cast by it are permanently removed.
- BR11: Login error messages must be generic and not reveal which field is incorrect.
- BR12: A password reset link is single-use.
- BR13: A password reset link expires 5 minutes after being issued.
- BR14: The forgot password flow must not reveal whether an email is registered.
