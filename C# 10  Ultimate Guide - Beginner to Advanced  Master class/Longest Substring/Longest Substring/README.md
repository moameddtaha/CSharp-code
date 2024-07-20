# Longest Substring

This project contains a C# console application that implements a solution to the problem of finding the length of the longest substring without repeating characters. 

## Description

The `Longest_Substring` namespace includes a `Program` class with a method `LengthOfLongestSubstring` which calculates the length of the longest substring without repeating characters in a given string. The program demonstrates the sliding window technique with a dictionary to efficiently solve the problem.

### Key Components

- **`LengthOfLongestSubstring(string s)`**: This method takes a string `s` as input and returns the length of the longest substring without repeating characters. It uses a dictionary to track the last index of each character and adjusts the sliding window's left pointer accordingly.

- **`Main` Method**: The entry point of the application. It creates an instance of the `Program` class, calls the `LengthOfLongestSubstring` method with a sample string `"abcabcbb"`, and prints the result to the console.

## Example

Given the input string `"abcabcbb"`, the method returns `3` because the longest substring without repeating characters is `"abc"`.
