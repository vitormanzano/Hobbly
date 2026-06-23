# Tactical Design — Hobbly

This document describes the tactical DDD building blocks for each Bounded Context: Aggregates, Entities, Value Objects, Domain Services, Domain Events, and Repository interfaces.

---

## 1. Identity Context

### Aggregate: Account

The only aggregate in this context. Responsible for credential management and access control.

```
Account (Aggregate Root)
├── id: AccountId            UUID
├── email: Email             Value Object
├── passwordHash: PasswordHash   Value Object
└── createdAt: DateTime
```

**Behaviors:**
- `Account.create(email, rawPassword, username)` — validates email format and password length, hashes password, publishes `AccountCreated`
- `account.changePassword(currentPassword, newPassword)` — verifies current password before hashing new one (BR06)
- `account.delete(currentPassword)` — verifies current password, marks for deletion (BR07, BR08)
- `account.initiatePasswordReset()` — generates a single-use, 5-minute token (BR12, BR13)
- `account.resetPassword(token, newPassword)` — validates token (not expired, not used), sets new password

**Invariants:**
- Email must match valid format (BR01)
- Raw password must be at least 4 characters (BR02)
- Email must be unique across all Accounts (BR03) — enforced at repository level

---

### Value Objects — Identity

| Value Object | Fields | Rules |
|---|---|---|
| `AccountId` | `value: UUID` | Immutable identifier |
| `Email` | `value: string` | Validated format, stored lowercase |
| `PasswordHash` | `value: string` | Wraps bcrypt hash; factory validates min 4 chars on raw input |
| `PasswordResetToken` | `token: string`, `expiresAt: DateTime`, `used: boolean` | Single-use, 5-min TTL (BR12, BR13) |

---

### Domain Services — Identity

**`AuthenticationService`**
- `authenticate(email, password): AccountId` — validates credentials without revealing which field is wrong (BR11)

---

### Domain Events — Identity

| Event | Payload | Triggers |
|---|---|---|
| `AccountCreated` | `accountId`, `email`, `username` | Community creates User |
| `AccountDeleted` | `accountId` | Community reassigns content; Voting removes all votes |
| `PasswordChanged` | `accountId` | — |
| `PasswordResetRequested` | `accountId`, `token`, `expiresAt` | External email service sends reset link |

---

### Repositories — Identity

**`AccountRepository`**
- `findById(id: AccountId): Account | null`
- `findByEmail(email: Email): Account | null`
- `save(account: Account): void`
- `delete(id: AccountId): void`

---
## Summary: Building Blocks per Context

| Context | Aggregates | Value Objects | Domain Services | Repositories |
|---|---|---|---|---|
| Identity | Account | AccountId, Email, PasswordHash, PasswordResetToken | AuthenticationService | AccountRepository |

---
