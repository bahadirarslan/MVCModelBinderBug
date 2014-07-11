MVCModelBinderBug
=================

An example of MVC ModelBinder Bug

This bug is very familier with "Bug in MVC4: System.Web.PrefixContainer" (https://aspnetwebstack.codeplex.com/workitem/616) 
But slightly different..

The most important different is, this is not resolved yet. 

Only thing you have to do is open HomeController and uncomment, currently commented FormPost action and comment other one and try.
You will see all properties in ViewModel will be null
