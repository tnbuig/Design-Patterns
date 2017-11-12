# Builder Pattern

The builder pattern is an object creation software design pattern. Unlike the abstract factory pattern and the factory method pattern whose intention is to enable polymorphism, the intention of the builder pattern is to find a solution to the telescoping constructor anti-pattern that occurs when the increase of object constructor parameter combination leads to an exponential list of constructors. Instead of using numerous constructors, the builder pattern uses another object, a builder, that receives each initialization parameter step by step and then returns the resulting constructed object at once.

The builder pattern has another benefit: It can be used for objects that contain flat data (HTML code, SQL query, X.509 certificate…), that is to say, data that can't be easily edited step by step and hence must be edited at once.

[From wikipedia]