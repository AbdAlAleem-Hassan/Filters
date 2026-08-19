# Resource Filters

⬅️ [Back to the main repo README](../README.md)

## What is a Resource Filter?

A **Resource Filter** runs **right after the Authorization Filter**. The key difference between the two is:

- The **Authorization Filter** verifies the **identity** of the user — is this user even allowed in?
- The **Resource Filter** runs **after** identity has been confirmed, and is used to validate the **resource** itself (e.g., access to a specific resource, caching, or altering model binding before it reaches the Action).

In other words, its position in the pipeline allows it to:

- Run before Model Binding, so it can short-circuit the request before .NET does any expensive work (such as model binding itself).
- Run after the user has already been confirmed as authorized, so it should not be treated as a substitute for Authorization.

## How It's Implemented

It's implemented through:

- The sync interface: `IResourceFilter`
- The async interface: `IAsyncResourceFilter`

And like other filters, it can be registered:

1. **Globally**, via `options.Filters.Add<...>()` inside `AddControllers`.
2. **As an Attribute** on a specific Controller or Action.

## What's in This Project

A working example showing exactly where a Resource Filter runs in the pipeline relative to Authorization and Model Binding, and when using it is a better fit than putting the same logic inside an Action Filter.

---
⬅️ [Back to the main repo README](../README.md)
