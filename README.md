# CrossIndustryInvoice.NETCoreLib

## Intro
A Library containing all CII types for C#.NET Core. See PEPPOL.

In CII there are Coupled and Uncoupled types.
Uncoupled is the simplest.
Coupled means that where the value for certain tags in the Uncoupled type is just a string,
it is a value of a particular codelist.

This means Coupled versions are better for exchanging data with various parties, because everybody knows 
what the meaning is of the given codes or values.

A document (Invoice) can be 100% Uncoupled or 100% Coupled or something in between.
So the implementation should be able to handle partially Coupled documents.




## Depends on
- https://github.com/BartVertongen/Commons.NETCoreLib
