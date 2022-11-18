# Liskov Subtitution Principle
## Two important terms: _subtyping relation_ and _strong behavioral subtyping_.
## Definition: Objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.

## Explanation:
- Whenever we have parent child relationship in the code and if we are able to implement a code such that code for parent class is replaceable with the code of child class without breaking the application, then we have to do that as per this principle.
- We can take example of **Square** and **Rectangle**. Rectange is a parent class where we have width and height. Square is a child class where we have all sides are same. So, we can emulate the Width or Height of Rectange and make width and height similar for Square.
- Here is the Pictorial representation for the same if you can't get me.

![image](https://user-images.githubusercontent.com/14868665/202627817-6fbee429-d8ac-409a-99e4-1bdaea6cc9e8.png).
