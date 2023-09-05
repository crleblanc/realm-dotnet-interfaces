# realm-dotnet-interfaces

Example repo that shows an issue with C# in .Net Framework 4.8. While we
can subclass the RealmObject, we cannot use the IRealmObject interface.
We see errors such as "error CS0535: 'ImplementsRealmInterface' does not implement interface member 'IRealmObjectBase.Accessor'"

The same code compiles fine in .Net 7.

