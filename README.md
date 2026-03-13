# 🧩 Algorithms & Data Structures Knowledge Base

A high-performance collection of algorithmic solutions implemented in **C# / .NET 10**. This repository serves as a technical journal for mastering computational patterns and optimizing time/space complexity for planet-scale data processing.

## 🚀 Engineering Principles
* **Performance First:** Every solution is optimized to achieve the lowest possible runtime latency, frequently hitting the **100th percentile (0ms)** on competitive platforms.
* **Pattern-Driven Mastery:** Focus is placed on reusable mental models—such as **Sliding Window**, **Two Pointers**, and **Greedy Algorithms**—rather than isolated problem-solving.
* **Production-Grade Code:** Solutions emphasize readability, using modern C# features and **SOLID** principles to ensure code is maintainable and peer-review ready.
* **Validated Reliability:** Implementations are verified using **xUnit** to ensure accuracy across standard cases and complex edge conditions.

## 🛠️ Technical Stack
* **Language:** C# 14 (.NET 10)
* **IDE:** Visual Studio 2026
* **Testing Framework:** xUnit
* **Architecture:** Optimized for $O(n)$ time and $O(1)$ space where theoretically possible.

## 📁 Repository Structure
- `SlidingWindow/`: Complex string and array manipulation using the "Expand-Shrink" template.
- `Arrays/`: Core data structure optimizations and hash-map based lookups.
- `Tests/`: xUnit test suites for local verification.

## 📊 Complexity Reference

| Problem | Category | Time | Space | Note |
| :--- | :--- | :--- | :--- | :--- |
| [Char Replacement](https://github.com/vchakravarthula/Algorithms-Knowledge-Base/blob/master/SlidingWindow/CharacterReplacement.cs) | Sliding Window | $O(n)$ | $O(1)$ | 0ms runtime with greedy frequency tracking. |
| [Longest Substring](https://github.com/vchakravarthula/Algorithms-Knowledge-Base/blob/master/SlidingWindow/LongestSubstring.cs) | Sliding Window | $O(n)$ | $O(m)$ | Optimized with HashSets for uniqueness. |
| [Two Sum](https://github.com/vchakravarthula/Algorithms-Knowledge-Base/blob/master/Arrays/TwoSumSolution.cs) | Arrays | $O(n)$ | $O(n)$ | Linear scan using dictionary-based complements. |

---
*Developed as part of a systematic technical interview preparation journey.*
