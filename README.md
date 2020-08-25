# Lab01a
![Screenshot](./Assets/Screenshot.png)
## Program Specifications
### Your solution should include the following:
+ Main Method
+ StartSequence Method
+ Populate Method
+ GetSum Method
+ GetProduct Method
+ GetQuotient
## Guidance
Within the Program.cs file, add the following methods described below.

Allow the main method to output all generic exceptions. Only define specific exceptions once and pay attention to the callstack on how requests are being made.

Do not use any “global” variables in this application

### Main Method
This method is given to you. Do not change the method signature.

+ The “Main” method should be:
  + static or instance: static
  + return type: void
  + parameters: string[] args
+ The logic within this method should:
  + Call the StartSequence() method from Main
+ Expected Exceptions:
  + Generic Exception
    + Let the user (nicely) know that they did something wrong.
    + Output the message of the exception to the console.
+ Include a finally that tells us that the program is completed.
### StartSequence Method
+ The “StartSequence” method should be
  + static
  + void return type
  + no parameters
+ The logic within the method should
  + prompt the user to “Enter a number greater than zero”.
  + Utilize the Convert.ToInt32() method to convert the user’s input to an integer.
  + Instantiate a new integer array that is the size the user just inputted.
  + Call the Populate method.
    + arguments: integer array
  + Capture the sum by calling the GetSum method.
    + arguments: integer array
  + Capture the product by calling the GetProduct method.
    + integer array and integer sum
  + Capture the quotient by calling the GetQuotient method.
    + arguments: integer product
  + To complete the method, output to the console the details of all these values. Make sure that your output contains the same information presented in the example below. Pay attention to line breaks!
  + Exceptions expected:
    + Format Exception
      + Output the message to the console
    + Overflow Exception
      + Output the message to the console
### Populate Method
+ The “Populate” method should be
  + static
  + return type: integer array
  + 1 parameter of an integer array
+ The logic within the method should:
  + Iterate through the array and prompt the user to enter a specific number. Example: “Please enter a number 1/6” (indicate to the user what number they are inputting)
  + Utilize the Convert.ToInt32 method to convert the user’s input to an integer (Remember not to directly manipulate the user’s input. Store the response into a string first).
  + Add the number just inputted into the array.
  + Repeat this process until all numbers have been requested and the array is filled.
  + Return the populated array
  + Expected Exceptions:
    + No expected exceptions. Not even a generic exception. StartSequence will already capture your FormatException error.
### GetSum Method
+ The method signature of GetSum should contain:
  + static or instance: static
  + return type: integer
  + parameters: integer array
+ The logic within the method should:
  + Declare an integer variable named sum
  + Iterate through the array and populate the sum variable with the sum of all the numbers together.
  + Add the capability to throw a custom exception if the sum is less than 20, with the message “Value of {sum} is too low”. (replace {sum} with the actual sum of the variable).
  + return the sum.
+ Expected Exceptions:
  + No Try/Catch required since no expected exceptions will be caught. We will have our custom exception be caught in lower levels of the callstack.
### GetProduct Method
+ The method signature of GetProduct should contain:
  + static or instance: static
  + return type: integer
  + parameters: integer array, integer sum
+ The logic within the method should:
  + Ask the user the select a random number between 1 and the length of the integer array.
  + Declare a new variable named product
  + Multiply sum by the random number index that the user selected from the array (example: array[randomNumber]). Set this value to the product variable.
  + Return the product variable.
+ Expected Exceptions:
  + IndexOutOfRange
    + Output the message to the console.
    + throw it back down the callstack so that it displays within Main
### GetQuotient Method
+ The method signature of GetQuotient should contain:
  + static or instance: static
  + return type: decimal
  + parameters: integer product
+ The logic within the method should:
  + Prompt the user to enter a number to divide the product by. Display the current product to the user during this prompt.
  + Retrieve the input and divide the inputted number by the product.
  + Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.
  + Return the quotient
+ Expected Exceptions:
  + Divide by Zero Exception
    + Output the message to the console
    + Do not throw it back to Main
    + Return 0 if the catch gets called
### Stretch Goals
+ Refactor your code and explore different ways to convert user input to integers. (Keep at least 1 Convert.ToInt32, but try and change the rest)
+ Add an additional custom exception into your code base.