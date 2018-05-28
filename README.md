# CSharp Xperiments
**C# 7.2-Non-trailing arguments**

 Here's cool feature of C# which is available in C# 7.2, it allows you to use non trailing named arguments. This feature is not part of .NET Core and .NET Framework.

**C# 7.1-Inferred Named Tuple**

The **ValueTuple** struct has fields named Item1, Item2, Item3, and so on, similar to the properties defined in the existing Tuple types. These names are the only names you can use for unnamed tuples. When you do not provide any alternative field names to a tuple, you've created an **unnamed tuple**:
```
var unnamed = ("one", "two");
```
However, when you initialize a tuple, you can use new language features that give better names to each field. Doing so creates a named tuple. **_Named tuples_** still have elements named Item1, Item2, Item3 and so on. But they also have synonyms for any of those elements that you have named. You create a named tuple by specifying the names for each element. One way is to specify the names as part of the tuple initialization:
```
var named = (first:"one", second:"two");
```
