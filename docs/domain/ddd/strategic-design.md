# Strategic Design — Hobbly

## Bounded Contexts

The Hobbly domain is divided into **5 Bounded Contexts**, each with a clear responsibility and its own ubiquitous language.

| # | Context | Core Responsibility |
|---|---------|---------------------|
| 1 | **Identity** | Credentials, authentication, password management |

---

## Bounded Context Descriptions

### 1. Identity

Manages everything related to credentials and access control. An **Account** is the only concept here, it holds the email and password hash. The Identity context does not know about usernames, hobbies, or content.

**Key actors:** Visitor, User  
**Core concepts:** Account, PasswordResetToken  
**Operations:** Create Account, Login, Logout, Change Password, Forgot Password, Delete Account
---


## Ownership and Autonomy

| Context | Owns its own DB? | Writes via events? | Reads via events? |
|---------|------------------|--------------------|-------------------|
| Identity | Yes | Publishes | — |

Each context is independently deployable. 
