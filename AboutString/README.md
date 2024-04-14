# Mastering String Manipulation in C#: Insights from Steve Gordon’s Pluralsight Course

Recently, I had the opportunity to dive into the world of string manipulation in C# by taking Steve Gordon’s course on Pluralsight. 
The class, aptly named “String Manipulation in C#: Best Practices,” provided valuable insights and practical techniques for working with strings effectively.

## Who Should Take This Course?

* **Beginners**: If you’re new to C# or want to strengthen your understanding of string handling, this course is an excellent starting point. Steve breaks down the fundamentals, ensuring that even those with minimal experience can grasp the concepts.
* **Advanced Engineer**s: Seasoned developers will appreciate the course’s focus on best practices. It serves as a helpful reminder of efficient ways to work with strings, avoiding common pitfalls.

## Key Takeaways

* **String Methods**: Steve covers a range of string methods, from basic concatenation to more advanced techniques like interpolation and formatting. Whether you’re building simple applications or complex systems, understanding these methods is crucial.
* **Unit Testing**: Throughout the course, I created C# classes and wrote unit tests. This hands-on approach allowed me to experiment with different string manipulation methods. 
* **Best Practices**: Steve’s insights into best practices are invaluable. From memory management to performance optimization, he shares tips that can elevate your string-handling skills.

## My Custom Experiments

During the course, I crafted several custom classes to explore string manipulation techniques. Here are a few examples:

1. CompareStrings
2. ConcatenateAndFormatStrings
3. DeclareChars
4. DeclareStrings
5. EncodeStrings
6. EqualityStrings
7. FormatAsSrrings
8. ModifyStrings
9. ParseStrings
10. SearchStrings
11. SortStrings

## A Few Tips from the Course

IComparable and IComparable<T> define a method that a value type or class can implement to allow ordering and sorting of instances. String can be sorted within a collection.
You should use comparison methods for sorting strings but not for checking equality.

IEquatable<T> defines a method which allows comparing the equality of 2 string instances. Equality is a specific comparison case that we should use when we want to know of 2 string instances are equivalent to one another.

There are 3 modes of comparing strings (StringComparison enum)

1. Ordinal (OrdinalIgnoreCase) -> compare strings strictly based on the unicode values of their characters. Characters are iterated to check for equality of characters  the same index in both strings. Used when case senitivity is not required. Prefer ordinal as a safe default for culture-agnostic comparisons. Ordinal achieve the best performance.
2. CurrentCulture (CurrentCultureIgnoreCase). Applies conventions from the culture under which code is running. Culture may define rules for sorting and comparing characters. Consider it for comparisons of strings which are presented in the UI
3. InvariantCulture (InvariantCultureIgnoreCase). Less common choice. Compares strings using a consistent culture. The difference from current culture is that, as the name suggests, the culture remains consistent across time, regardless of configuration changes to the runtime or the operating system. It uses rules associated with the English language but not specific to particular country or region. It is most useful for parsing and storing dates and numbers in a culture-independent format.

## Conslusion
Steve Gordon’s course not only enhanced my understanding of C# string manipulation but also inspired me to adopt best practices in my own code. Whether you’re a beginner or an experienced developer, consider adding this course to your learning journey. Happy coding! 