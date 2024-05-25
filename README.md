# **3D Pac-Man Game in Unity**

Welcome to my 3D Pac-Man game project! This is a modern take on the classic arcade game, Pac-Man, developed using Unity and C#.

## **Play the Game**

You can play the 3D Pac-Man game on itch.io. Here's the link: Play on https://travelsbyfire.itch.io/pac-man-3d

## **About the Game**

In this game, you control Pac-Man, guiding him through a maze filled with pellets. The objective is to consume all the pellets while avoiding the ghosts that roam the maze. If Pac-Man consumes a power pellet, the ghosts temporarily become vulnerable and can be eaten by Pac-Man.

## **Codebase Overview**

The codebase is organized into several C# scripts, each handling a specific aspect of the game:

1. `EatMe.cs`: Manages Pac-Man's interaction with the pellets.
2. `Game_Score.cs`: Handles the game score display.
3. `GhostKill.cs`: Manages the interaction between Pac-Man and the ghosts.
4. `GhostMove.cs`: Controls the movement of the ghosts.
5. `ImageLivesCounter.cs` and `Lives_Counter.cs`: Manage the display of Pac-Man's remaining lives.
6. `PacManController.cs`: Handles the movement of Pac-Man based on user input.
7. `PathfinderWaypoints.cs`: Intended to guide the movement of the ghosts.
8. `PelletGhostKiller.cs`: Manages the interaction when Pac-Man eats a power pellet and can eat the ghosts.
9. `RestartGame.cs`: Provides the functionality to restart the game when Pac-Man loses all his lives.

## **How to Play**

Use the arrow keys or W, A, S, D keys to navigate Pac-Man around the maze. Consume all the pellets to advance to the next level. Avoid the ghosts unless you have consumed a power pellet, in which case you can eat the ghosts for extra points.

## **Future Enhancements**

There are some features that are currently under development:

- Ghosts' unique behaviors: Each ghost will have a specific area of the map that they will occasionally circle around.
- Ghost resurrection: After a ghost is eaten, it will respawn after a certain amount of time.

## **Contributing**

Contributions are welcome! Feel free to submit a pull request.

## **License**

This project is licensed under the MIT License. Please see the LICENSE file for more details.
