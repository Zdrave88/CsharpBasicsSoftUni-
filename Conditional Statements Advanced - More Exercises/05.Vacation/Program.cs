SoftUni Judge
Contests 
Submissions
Feedback
Hello, Zdravec88!
Log out
Search
Home Submissions 40235421
Solution #40235421 by Zdravec88 for problem 05. Vacation
Zero test #1 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.120 s
Memory used: 0.00 MB
Zero test #2 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.130 s
Memory used: 0.00 MB
Zero test #3 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.120 s
Memory used: 0.00 MB
Zero test #4 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.150 s
Memory used: 0.00 MB
Zero test #5 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.150 s
Memory used: 0.00 MB
Zero test #6 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.150 s
Memory used: 0.00 MB
Test #1 (Correct answer)
Time used: 0.140 s
Memory used: 0.00 MB
Test #2 (Correct answer)
Time used: 0.150 s
Memory used: 0.00 MB
Test #3 (Correct answer)
Time used: 0.160 s
Memory used: 0.00 MB
Test #4 (Correct answer)
Time used: 0.150 s
Memory used: 0.00 MB
Test #5 (Correct answer)
Time used: 0.150 s
Memory used: 0.00 MB
Test #6 (Correct answer)
Time used: 0.150 s
Memory used: 0.00 MB
Test #7 (Correct answer)
Time used: 0.120 s
Memory used: 0.00 MB
Test #8 (Correct answer)
Time used: 0.140 s
Memory used: 0.00 MB
Test #9 (Correct answer)
Time used: 0.130 s
Memory used: 0.00 MB
Test #10 (Correct answer)
Time used: 0.130 s
Memory used: 0.00 MB
Test #11 (Correct answer)
Time used: 0.140 s
Memory used: 0.00 MB
Test #12 (Correct answer)
Time used: 0.140 s
Memory used: 0.00 MB
Source code
1
double budget = double.Parse(Console.ReadLine());
2
string season = Console.ReadLine();
3
​
4
string stayIn = string.Empty;
5
string location = string.Empty;
6
double price = 0.0;
7
if (budget <= 1000)
    8
{
    9
    stayIn = "Camp";
    10
    switch (season)
11
    {
12
        case "Summer":
        location = "Alaska"; price = budget * 0.65; break;
        13
        case "Winter":
        location = "Morocco"; price = budget * 0.45; break;
        14
    }
    15
}
16
else if (budget > 1000 && budget <= 3000)
    17
{
    18
    stayIn = "Hut";
    19
    switch (season)
20
    {
21
        case "Summer":
        location = "Alaska"; price = budget * 0.80; break;
        22
        case "Winter":
        location = "Morocco"; price = budget * 0.60; break;
        23
    }
    24
}
25
else // budget > 3000
    26
{
    27
    stayIn = "Hotel";
    28
    switch (season)
29
    {
30
        case "Summer":
        location = "Alaska"; price = budget * 0.90; break;
        31
        case "Winter":
        location = "Morocco"; price = budget * 0.90; break;
        32
    }
    33
}
34
Console.WriteLine($"{location} - {stayIn} - {price:f2}");
Created on: 29 / 05 / 2024 15:59:42

Submission Type: C# code (.NET 6)

© 2011-2024 - Open Judge System (OJS) 1.5.20150729.95737d0 - running on Windows. Open source project.

Cookies help us deliver our services. By using our services, you agree to our use of cookies. OK