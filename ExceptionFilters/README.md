# Exception Filters

⬅️ [Back to the main repo README](../README.md)

## What is an Exception Filter?

An **Exception Filter** runs whenever an **unexpected exception** occurs anywhere in the pipeline (whether inside an Action Filter, the Action Method itself, or a Result Filter). It's used to:

- **Catch** the exception before it reaches the user as a default error page.
- **Prevent leaking sensitive details** about the server or the code (such as the Stack Trace or internal class names), which could otherwise help someone attempting to attack the system.
- Return a consistent, clear Response to the user (such as a generic error message plus an appropriate status code like 500).

## How It's Implemented

It's implemented through:

- The interface: `IExceptionFilter`
- The async interface: `IAsyncExceptionFilter`

And like other filters, it can be registered:

1. **Globally**, via `options.Filters.Add<...>()` inside `AddControllers`, to cover the whole application.
2. **As an Attribute** on a specific Controller or Action if only part of the app needs different handling.

## Important Note

An Exception Filter only catches exceptions that happen **inside the MVC pipeline** (i.e., within Action Filters, Action Methods, or Result Filters). It does **not** catch exceptions that occur in other stages, such as Middleware or Routing. If you need coverage across the whole application, consider using a custom Exception Handling Middleware alongside, or instead of, the filter.

## What's in This Project

A working example of an Exception Filter that catches exceptions and returns a consistent, safe Response to the user without exposing any sensitive details.

---
⬅️ [Back to the main repo README](../README.md)
