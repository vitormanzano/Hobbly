# Ubiquitous Language

This document defines the terms used across the Hobbly domain. All team members, documentation, and code should use these terms consistently.

---

## Visitor

An unauthenticated user browsing the platform. A Visitor can view public content (posts, profiles, feeds) but cannot interact with it (comment, vote, create posts).

---

## User

An individual with a registered and authenticated account on Hobbly. A User has a public identity (username, description, hobbies) and can fully interact with the platform.

---

## Account

The authentication identity of a User. Holds credentials (email and password) and is responsible for access control. An Account always corresponds to exactly one User.

---

## Hobby

A theme or area of interest that categorizes content on the platform. Hobbies come from a curated list that grows over time as Users suggest new ones. A suggested Hobby must be approved before becoming available to all Users.

A User can associate multiple Hobbies with their profile to personalize their experience.

---

## Post

A piece of content published by a User within the context of a Hobby. Every Post has a type that defines its intent:

- **Question** — the author seeks knowledge or advice from the community.
- **Tip** — the author shares a useful insight or recommendation.
- **Achievement** — the author shares a personal accomplishment related to a Hobby.

A Post can receive Comments and Votes.

---

## Comment

A response published by a User on a Post. Comments can be posted at the top level or as a reply to another Comment, enabling infinite nesting. A Comment that replies to another Comment is still called a Comment — there is no distinct "Reply" concept.

A Comment can receive Votes.

---

## Vote

An explicit expression of opinion by a User on a Post or Comment. A Vote can be:

- **Upvote** — a positive signal indicating the content is useful or valuable.
- **Downvote** — a negative signal indicating the content is unhelpful or low quality.

A User can only cast one Vote per Post or Comment. Voting again on the same content removes the existing Vote (toggle). A User cannot vote on their own content.

---

## Feed

A curated list of Posts displayed to a User. There are two types of Feed:

- **Public Feed** — shows the most upvoted Posts across the entire platform, available to Visitors and Users.
- **Personalized Feed** — shows a mix of the most upvoted Posts from the User's Hobbies and the platform overall. Falls back to the Public Feed if the User has no Hobbies.

---

## Notification

An in-platform alert delivered to a User when another User interacts with their content. Interactions that trigger a Notification:

- A Comment is posted on the User's Post.
- A Comment is posted in reply to the User's Comment.
- A Vote is cast on the User's Post or Comment.

A Notification can be marked as read.

---

## Author

The User who created a given Post or Comment. The Author is the only User allowed to edit or delete their own content, subject to platform rules (e.g., Posts can only be edited within one hour of creation).

---

## Edit Window

The time period during which an Author is allowed to edit a Post after its creation. Currently defined as one hour. After the Edit Window expires, the Post becomes immutable.
