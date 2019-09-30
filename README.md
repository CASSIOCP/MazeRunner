# MazeRunner
A simple matrix navigation to find a destination value.

Developed in [.Net Core](https://dotnet.microsoft.com/download).

<div align="center">
  <img src="https://user-images.githubusercontent.com/8649045/65902152-1ba36680-e390-11e9-93e2-a4ea46d0de48.png"><br>
</div>

## Objective

Given a bidimensional maze, the goal is to find the shortest path from the starting point to the destination point.

<div align="center">
  <img src="https://user-images.githubusercontent.com/8649045/65899854-02e48200-e38b-11e9-9caa-f6606c0467ca.png"><br>
</div>

## Guide

First of all, the maze is read from a text file called "maze.txt" present in the application folder.

The structure of text file contains the following:
The first line is an integer representing the number of lines the maze has;
The second row is an integer representing the number of columns the maze has;
The following lines contain the string representing the maze, where:

```sh
'S' = Start position
'E' = End position (Destination)
'.' = Path that can be crossed
'#' = Block that cannot be crossed
```

Exemple
```sh
5
6
S##.#.
......
.#.#.#
#E.#.#
#....#
```

The goal is to reproduce a new maze with only the shortest path from the beginning 'S' to the end 'E'.

The shortest path is the minimum number of steps required to reach the destination by counting the number of valid adjacent cells that form a path from 'S' to 'E'

Exemple
```sh
Steps: 6
S#####
...###
##.###
#E.###
######
```

## Notes

* The starting point 'S' always starts at position (0,0).
* The destination point 'E' can be placed anywhere else, even if there is no valid path.
* If there is no valid path to the destination, a "Not Found" message will be displayed.

## Solution

Using recursive program techniques to move in 4 directions in the bidimensional array to find and store the least cost path.

## Author

* **Cássio C. Perin**
