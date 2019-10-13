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


## Non-Null Reference Types

I found that there is nothing new with this feature. It gives you a warning when an attempt to check out any nullable property. It also gives you warning when you try to assign null to a non-nullable variable.
Using this new C# 8 feature, you can reduce the null reference exception.

Currently, this feature is not enabled as default. You can enable the feature itself in two procedures.

Firstly, enable the nullable features for the entire project. You should add ```<Nullable>enable</Nullable>``` inside your .csproj file. You also can enable the nullable features for a specific file. I like the way they provide two options. In large or any enterprise application it will not be a single day job to fix all possible null expectations. So, you can improve your application day by day, though enabling non null reference type feature on a single file.

You need to add ```#nullable enable``` on the very top of your code snippet and ```#nullable restore``` at the very bottom of your code snippet.

You need to add ```#nullable enable``` on the very top of your code snippet and ```#nullable restore``` at the very bottom of your code snippet.
Take a look over the below code snippets.
![Code snippet without non-null reference types feature](https://user-images.githubusercontent.com/24603959/66712454-a20f6d80-edbe-11e9-8016-df020d080db6.png)

See, you got no warning and you will get the null reference when trying to run the application.
![Code snippet with non-null reference types feature](https://user-images.githubusercontent.com/24603959/66712408-fd8d2b80-edbd-11e9-9de5-4af4eab74eb6.png)

After enabling the feature, you got a warning on compile time. So you have a chance to fix the possibilities of null reference exception.


## Readonly Members

For the very first, I missed the concept itself. I disappointed while I found it is only for the struct. You can think of a readonly method as a pure function. You can not modify any other properties from the readonly property setter.

It prevents you from accidentally changing the internal state in places where that was not expected. 

![Readonly members](https://user-images.githubusercontent.com/24603959/66712807-42b45c00-edc4-11e9-912c-117ecdcc3802.png)
Take a look over the image, you will get an error when trying to modify other variables from a readonly member.
