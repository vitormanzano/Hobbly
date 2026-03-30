## US-19 — Delete Comment

## Priority: High

## User Story
As an authenticated user, I want to delete one of my comments, so that I can remove content I no longer want to share.

### Acceptance Criteria
- [ ] The delete button is only visible to the comment author.
- [ ] The system displays a confirmation dialog warning that the action cannot be undone and that all nested replies will also be deleted.
- [ ] If the user cancels, the comment remains unchanged.
- [ ] If the user confirms, the comment and all its nested replies are permanently deleted.
- [ ] The comment is removed from the page without a full reload.
- [ ] The post's comment count is decremented by the total number of deleted comments (including nested replies).
