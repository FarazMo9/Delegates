
# Delegates

Imagine how a class and an object works. It is possible to create an object by the type of the related class. Delegates are also instantiated by function which allows the delegate variable to be invoked.
Delegates are reference types, but the key difference is that they point to methods.
Delegate is an object which knows how to invoke a method.
Delegates are type-safety which simply tells you that you cannot assign one type to another type while they are not compatible. So, we can call them “type-safe function pointers”.

It is good to know that the C# compiler when sees a delegate, turns it into a class which derives from the type “MulticastDelegate” as this type also derives from System.Delegate. This operation is not allowed to be done by the developer. So, these two types are sealed.
On multi delegates, the process is that all assigned methods will be executed but the return value is the output of the last assigned method.
By any exception on execution, the next methods of delegate would not be called.
The “Target” property of each delegate depends on the assigned method.
•	On static method the target property will be null
•	On instance method the target property is the instance which the method related to.

Covariance: When a parent type is expected, the extended type will be assigned. On delegates it will be applied to return types.
Contravariance: allows you to use a more generic (less derived) type than
originally specified. Using delegates, you can assign a method with base class
parameters to a delegate that expects to get the derived class parameters.

The related sample code is prepared to clarify the delegate concept. 