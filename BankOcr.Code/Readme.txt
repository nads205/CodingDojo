**This project was written in VS 2017, using Framework version 4.6.1**

Build
--------
Please do a full rebuild when checking out the repo for the first time. This should restore the relevant Nuget packages. There should not be any external dependencies other that Nuget packages. The solution should compile first time.

Tests
--------
All code was written in a TDD fashion - I wrote the tests first, then the code.
Given more time I would write more extensive tests which would test for a wider range of scenarios, larger datasets etc.

I used NUnit - so ensure you have a suitable test runner (I use Resharper's test runner), the built in Visual Studio runner might not detect the unit tests

I would eventually mock out the test repositiory for a live data file.

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
Using the trace classes - will attach listeners if requried. https://support.microsoft.com/en-gb/help/815788/how-to-trace-and-debug-in-visual-c

could use NLog or eqivalent when used in production. Or better still - how about the Elk Stack? 

https://piotrminkowski.wordpress.com/2017/02/03/how-to-ship-logs-with-logstash-elasticsearch-and-rabbitmq/

This article has some nice logging information too: https://stackoverflow.com/questions/20525277/simple-way-to-perform-error-logging
