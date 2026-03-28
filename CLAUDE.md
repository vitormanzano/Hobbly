# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## About the Project

**Hobbly** is a community platform for hobby enthusiasts. Users can create posts (questions, tips, achievements), vote on contributions, and interact with people who share the same interests.

## Current Stage

The project is in the documentation phase. No application code exists yet.

## Documentation Structure

```
docs/
  functionalRequirements/   — functional requirements organized by module
    index.md                — lists all FRs with links
    user/                   — FR01–FR05, FR19, FR21
    hobby/                  — FR06–FR07
    feed/                   — FR08–FR09
    post/                   — FR10–FR13, FR20
    comment/                — FR14–FR16
    voting/                 — FR17–FR18
    notification/           — FR22
  domain/
    ubiquitousLanguage/     — glossary of domain terms
  userStories/              — user stories organized by feature
```

## Planned Bounded Contexts

The domain is organized into 5 bounded contexts (not yet fully documented):

- **Identity** — Account (credentials, authentication)
- **Community** — User, Post, Comment, Hobby
- **Voting** — Vote (upvote/downvote on posts and comments)
- **Feed** — Public Feed, Personalized Feed
- **Notification** — Notification and triggers

## Key Domain Decisions

- **Post types**: Question, Tip, Achievement — same flow, type is just an attribute
- **Comment**: top-level and nested replies are the same concept (`parent_comment_id` null or filled)
- **Hobby**: curated list managed by admins. Users can suggest new hobbies, approved or rejected by an admin
- **Vote**: upvote and downvote, toggle behavior, users cannot vote on their own content
- **Edit Window**: posts can only be edited within 1 hour of creation
- **Account vs User**: Account holds credentials (Identity context), User holds public identity (Community context)

## Templates

### Functional Requirement

```markdown
## FR-XX — Name

## Description
## Actors
## Pre-conditions
## Main flow
## Alternative flows
## Post-conditions
## Requires
## Side effects
## Priority
## Status
```

### User Story

```markdown
## US-XX — Name

As a [actor], I want to [action], so that [benefit].

### Acceptance Criteria
- [ ] criteria
```
