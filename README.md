# C-Practice
C# Practice questions and problems

// Warm up:
// 1. Print "Hello, (your name)"

// 2. Add two numbers

// 3. Read an integer and print whether it is even or odd.

// 4. Read two numbers and print the larger one. Handle the case where they are equal.

// 5. Read a temperature in Celsius and convert it to Fahrenheit using:

// Beginner:
// 1. Print numbers from 1 through 100.
// Print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for multiples of both.

// 2.
// Given a string, count the vowels: a, e, i, o, and u.
// Treat uppercase and lowercase letters the same.

// 3.
// Read a string and output it reversed.
// Example: hello becomes olleh.

// 4.
// Generate a random number from 1 to 100.
// Let the user repeatedly guess until correct.
// Tell them whether each guess is too high or too low, then report the number of attempts.

// 5.
// Given an integer array, find and print its largest value without using array.Max().

// Intermidiate
// 1.
// Write a method that determines whether a string is a palindrome.
// Ignore spaces, punctuation, and letter casing.
// Example: "A man, a plan, a canal: Panama" should return true.

// 2.
// Given a sentence, return the number of times each word occurs.
// Ignore casing and punctuation.
// Use Dictionary<string, int>.
// Example: "cat dog cat" produces cat: 2, dog: 1.

// 3.
// Create a BankAccount class with:
// AccountHolder
// Read-only Balance
// Deposit(decimal amount)
// Withdraw(decimal amount)
// Reject zero/negative amounts and prevent withdrawals that exceed the balance.
// Consider throwing meaningful exceptions.

// 4.
// Given a List<Person>, where each Person has Name and Age, group people into:
// Under 18
// 18–64
// 65 and older
// Return a dictionary or create a result object with the groups.

// 5.
// Write an async method using HttpClient that requests JSON from an API endpoint.
// Deserialize the response into a C# model.
// Handle non-success HTTP status codes, timeouts, invalid JSON, and cancellation with a CancellationToken.



if statement practice:
1. Create an int age = 18;. Print "You can vote." if the age is at least 18.

2. Create an int temperature = 85;. Print "Hot day" if the temperature is greater than 80.

3. Create an int number = 14;. Print "Even" if the number is divisible by 2.

4. Create a string username = "admin";. Print "Welcome, admin." only if the username equals "admin".

5. Create an int score = 72;. Print "Passing" if the score is 60 or greater; otherwise print "Failing".

6. Create an int balance = 50; and an int cost = 65;. Print "Purchase approved" if the balance can cover the cost; otherwise print "Insufficient funds".

7. Create an int hour = 14;. Print "Good morning" before 12, "Good afternoon" from 12 through 17, and "Good evening" after 17.

8. Create an int number = -8;. Print whether it is "Positive", "Negative", or "Zero".

9. Create a string password = "CSharp123";. Print "Password is valid" if it has at least eight characters; otherwise print "Password is too short".

10. Create bool hasTicket = true; and int age = 16;. Print "You may enter" only when the person has a ticket and is at least 16 years old.


For-loop practice
1. Use a for loop to print the numbers 1 through 10.

2. Use a for loop to print the numbers 10 down to 1.

3. Print every even number from 2 through 20.

4. Print every odd number from 1 through 19.

5. Use a loop to calculate and print the sum of the numbers 1 through 100.

6. Create string[] colors = { "Red", "Blue", "Green", "Yellow" };. Use a for loop to print each color.

7. Create int[] scores = { 85, 92, 78, 100, 66 };. Use a loop to calculate the total of all scores.

8. Create int[] numbers = { 4, 9, 2, 15, 7 };. Use a loop to find and print the largest number.

9. Ask the user for a number. Use a loop to print that number’s multiplication table from 1 through 10. Example for 5:

text
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50

10. Use a for loop to print this pattern:

text
*
**
***
****
*****