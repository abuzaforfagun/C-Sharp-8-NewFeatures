# C-Sharp-8-NewFeatures
Example of new features introduced in C# 8.


## Null Coalescing Assignments

Null coalescing assignment introduced in C# 8. The motive of this operator is, check out that the variable is null or not, assign a value if it is null.
In C# 6.0, they introduced null coalescing operator ```??```. Null coalescing operator and null coalescing assignments operator seem similar and they are similar in motive too. Null coalescing operator check the variable is null or not and the null coalescing assignment operator assigns a value if it is null.
Previously it could be done like below:

```
if(anyVariable == null)
{
  anyVariable = "Default value";
} 
```

A better approch with null coalescing operator:

``` anyVariable = anyVariable ?? "Default Value"; ```

C# 8 approch (Null coalescing assignment operator):

``` anyVariable ??= "Default Value";```
