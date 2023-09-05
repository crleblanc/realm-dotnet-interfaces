# realm-dotnet-interfaces

Example repo that shows an issue with C# in .Net Framework 4.8. While we
can subclass the RealmObject, we cannot use the IRealmObject interface.
We see errors such as "error CS0535: 'ImplementsRealmInterface' does not implement interface member 'IRealmObjectBase.Accessor'"

Be sure to restore NuGet packages and restart Visual Studio if necessary.

Compiling on .Net 7 works without errors.

