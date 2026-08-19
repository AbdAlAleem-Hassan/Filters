# Endpoint Filters

⬅️ [Back to the main repo README](../README.md)

## What is an Endpoint Filter?

An **Endpoint Filter** is the equivalent of the filters concept, but designed specifically for **Minimal APIs**. It gives you the same ability to run logic before and after an Endpoint executes (such as validation, logging, or modifying the Response) without needing to use the full Controllers-based system.

## How It's Implemented

It's implemented through the interface:

- `IEndpointFilter`

And it's registered directly on the endpoint itself using `AddEndpointFilter`:

```csharp
app.MapGet("/products/{id}", (int id) => Results.Ok(id))
   .AddEndpointFilter<ValidateProductIdFilter>();
```

It can also be registered as a **direct lambda**, without creating a separate class, which is useful for simple cases:

```csharp
app.MapGet("/products/{id}", (int id) => Results.Ok(id))
   .AddEndpointFilter(async (context, next) =>
   {
       // Logic before the Endpoint executes
       var result = await next(context);
       // Logic after the Endpoint executes
       return result;
   });
```

## When to Use It

- When you're building your API using **Minimal APIs** instead of traditional Controllers.
- When you need shared logic (such as validation) applied across multiple Endpoints without duplicating code.

## What's in This Project

Working examples of `IEndpointFilter` applied to different Endpoints, illustrating the difference between registering it as a separate class versus as a direct lambda.

---
⬅️ [Back to the main repo README](../README.md)
