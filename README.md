# High Scores Manager

This project is a simple **High Scores Manager** that tracks and retrieves information about a game player's scores, including the most recent score, the highest score, and the top three scores.

## Project Description

The `HighScores` class provides a way to manage and analyze a player's scores from a classic game. It includes methods to:

- Retrieve the list of all scores (`Scores()`).
- Get the latest score that was added (`Latest()`).
- Find the highest score (`PersonalBest()`).
- Retrieve the top three highest scores (`PersonalTopThree()`).

### Methods Overview

- **`Scores()`**: Returns a list of all the scores.
- **`Latest()`**: Returns the most recently added score.
- **`PersonalBest()`**: Returns the highest score in the list.
- **`PersonalTopThree()`**: Returns the top three highest scores in descending order.

## Prerequisites

- .NET SDK installed (version 5.0 or later).
- Visual Studio or any C# IDE (optional).

## How to Run

1. Clone the repository or download the project files.
2. Open the project in your IDE or navigate to the project directory in your terminal.
3. Compile and run the program using the following commands:

   ```bash
   dotnet build
   dotnet run
