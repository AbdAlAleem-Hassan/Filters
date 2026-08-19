# Action Filters

⬅️ [Back to the main repo README](../README.md)

## What is an Action Filter?

An **Action Filter** runs immediately before and after an **Action Method** is invoked. It is implemented through:

- The sync interface: `IActionFilter`
- The async interface: `IAsyncActionFilter`

## Registration Methods

This project demonstrates 3 different ways to register the same filter idea, each suited to a different use case.

### 1. Global — Applies to All Controllers & Actions

Registered once in `Program.cs` and automatically applied to every Controller and every Action, without needing to add anything on top of individual actions.

```csharp
builder.Services.AddControllers(options =>
{
    options.Filters.Add<TrackActionTimeFilter>();
});
```

### 2. As an Attribute — For a Specific Controller or Action

The filter inherits from `Attribute` while also implementing the filter interface, giving you the flexibility to apply it only where you need it.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class TrackActionTimeFilterV2 : Attribute, IAsyncActionFilter
```

### 3. ActionFilterAttribute — The Unified Approach

.NET simplified things further with a ready-made class called `ActionFilterAttribute`, which combines being an `Attribute` and implementing the filter interfaces at the same time, so you don't need to do both steps separately.

```csharp
[AttributeUsage(AttributeTargets.Method)]
public class TrackActionTimeFilterV3 : ActionFilterAttribute
```

## What's in This Project

- A working implementation of all three approaches above (`TrackActionTimeFilter` in its different forms).
- Each approach applied on a different Controller to make the difference between them clear.

## Not Sure About the Difference?

| Approach | Scope | Reusability |
|---|---|---|
| Global | All Controllers | Not flexible, applies to everything |
| Attribute + Interface | Specific Controller / Action | Flexible, but needs two steps (Attribute + Interface) |
| `ActionFilterAttribute` | Specific Controller / Action | Flexible and concise in a single step |

---
⬅️ [Back to the main repo README](../README.md)
