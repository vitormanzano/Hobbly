## FR-23 — Review Hobby Suggestion

## Description
An admin should be able to approve or reject hobby suggestions submitted by users. Approved hobbies become immediately available on the platform. Rejected suggestions are permanently discarded.

## Actors
Admin

## Pre-conditions
- The admin is authenticated.
- At least one hobby suggestion is pending review.

## Main flow
1. Admin navigates to the hobby suggestions page.
2. System displays the list of pending suggestions, each showing the proposed name and the submitting user.
3. Admin selects a suggestion.
4. Admin clicks the approve button.
5. System adds the hobby to the platform's curated list and marks the suggestion as approved.

## Alternative flows

**AF-01 — Admin rejects the suggestion**
At step 4, if the admin clicks the reject button instead, the system permanently discards the suggestion.

**AF-02 — No pending suggestions**
At step 2, if there are no pending suggestions, the system displays a message indicating the list is empty.

## Post-conditions
- Approved hobby is persisted and available for users to add to their profiles.
- Rejected suggestion is permanently removed.

## Requires
- FR-06 — Manage Hobbies

## Side effects

## Priority
Medium

## Status
Draft
