Tests
--------
All code was written in a TDD fashion - I wrote the tests first, then the code.
Given more time I would write more extensive tests which would test for a wider range of scenarios, larger datasets etc.

Patterns
--------
I have tried to use a few patterns

The Facade for example - the Parser.Parse is a facade to the other calls to subsystem classes (RulesChecker etc)

SOLID
--------
Where possible I've used the following 

Interface segreation principle - keep the interfaces as lightweight as possible
Single responsibility
Open closed principle - the rules checker can be changed without chaging the parser logic

Logging
-------