# Result Filters

⬅️ [Back to the main repo README](../README.md)

## What is a Result Filter?

A **Result Filter** runs **before and after the execution of the Action Result** — the moment when the value returned by an Action is turned into an actual Response sent back to the user.

It's mainly used when you want to **standardize the shape of the Response** across all the Actions in a given Controller (or even across the whole application), instead of repeating the same response-formatting logic inside every single Action.

### Common Use Cases

- Wrapping every Response in a consistent shape (e.g., `{ success, data, message }`).
- Adding specific headers to every Response.
- Modifying or wrapping the Result before it reaches the client.

## How It's Implemented

It's implemented through:

- The sync interface: `IResultFilter`
- The async interface: `IAsyncResultFilter`

And like other filters, it can be registered:

1. **Globally**, via `options.Filters.Add<...>()` inside `AddControllers`.
2. **As an Attribute** on a specific Controller or Action, or by inheriting from `ResultFilterAttribute`.

## What's in This Project

A working example of a Result Filter that standardizes the Response shape returned from multiple Actions within the same Controller.

---
⬅️ [Back to the main repo README](../README.md)
