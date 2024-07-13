# C# Introduction

In the first session, we covered an introduction to C#, which included topics such as printing, data types, strings, and more.

## Task 2

The task involves finding the sum of numbers from 1 to n. We explored two approaches: using a **for loop** and using a **formula**.

Let's see how much time it takes for each approach when we run the code.

![Time-for-formula](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/First_Task.png)

### Using For Loop

In this task, we utilized a for loop to solve the problem, which has a time complexity of **O(N)**. During the execution of the code, we observed that it takes some amount of resources like CPU.

![For-loop-CPU](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/For%20Loop.png)

As we can see in the image, it uses more CPU resources.

### Using Formula

We utilized a formula to solve the problem, which has a time complexity of **O(1)**. During the execution of the code, we observed that it takes fewer resources like CPU. The formula is $Sum = n * (n + 1) / 2$.

![formula-cpu](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/Formula.png)

As we can see, it uses less CPU compared to the for loop.

## Task 3

The task involves printing numbers from 1 to n. We explored two approaches: using **string** and using **StringBuilder**.

Let's see how much time it takes for each approach when we run the code.

![strin-stringbuilder-time](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/Second%20Task.png)

As we can see, using `string` takes significantly more time compared to using `StringBuilder`.

### Using String

Using a `string` to concatenate numbers has a time complexity of **O($N^2$)** because each concatenation creates a new string and copies the old string along with the new character, which is inefficient.

![string-conc](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/Normal%20String.png)

### Using StringBuilder

Using `StringBuilder` to concatenate numbers is much more efficient with a time complexity of **O(N)**. `StringBuilder` maintains a mutable buffer that grows as needed, which makes it faster for multiple concatenations.

![StringBuilder-conc](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/0ae298af496bf89e1abd7129a41e90e1daf038d3/Tasks%201/Task%20%202%20-%203/Images/StringBuilder.png)

We can see the big differences between two of them

## Complexity of String to concatenate numbers
As we said before, It will take **O($N^2$)**.

It depends on two things:
1. The Loop: It will take **O(N)** and N is the number of iterations.
2. Concatenation: It will take **O(N)** but N here is the length of string because it makes a new string and put old data in it.

So the combining these factors, The complexity will be **O($N^2$)**

![string-complexity](https://github.com/mahfeshar/iNNOTECH-online-summer-training/blob/36b9e756f2347e2dba41d35006f0014a32693394/Tasks%201/Task%20%202%20-%203/Images/String_Complexity.png)
