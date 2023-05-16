# Three Dimensional Game

This project is an additional improvement for the game [06-3d-terrain-ai](https://github.com/gamedev-at-ariel/06-3d-terrain-ai.git)


# Try our additional improvement
[Robots Invasion](https://by-games.itch.io/robot-invation)


# About the game:
This game demonstrates some concepts of a 3D game, including the following:
* Scene modelling with Terrain Tools and ProGrids;
* Player control with CharacterController and NavMeshAgent;
* Enemy AI;
* Target visualization with gizmmos.




# Our changes 

## Developing the existing scene

We have made the following improvements to the existing scene:

* Added a guard tower to the structure.
* Constructed stairs to connect the tower with the main building.
* Improved visibility by adding lighting to the room.
![Alt text](Assets/Screenshot/Screenshot%202023-05-16%20233810.jpg)
![Alt text](Assets/Screenshot/Screenshot%202023-05-16%20154304.jpg)
![Alt text](Assets/Screenshot/Screenshot%202023-05-16%20154640.jpg)
![Alt text](Assets/Screenshot/Screenshot%202023-05-16%20233554.jpg)
## Player

We have made the following changes to the player:


1. The player has the option to run. When the shift button is pressed, the player will move faster.
the changs happned at [‎CharacterKeyboardMover::Update](https://github.com/BY-Games/3D_game/blob/main/Assets/Scripts/1-player/CharacterKeyboardMover.cs#L63:~:text=CharacterKeyboardMover%3A%3AUpdate)

2. The player has a weapon and can switch between two types of weapons. The changes can be found at 
[‎PlayerController::Update](https://github.com/BY-Games/3D_game/blob/main/Assets/Yurowm/Demo/Scripts/PlayerController.cs#L62:~:text=PlayerController%3A%3AUpdate)

3. The rifle now fires bullets [Shooter.cs](Assets%2FScripts%2F1-player%2FShooter.cs). Each shot creates a projectile that travels in the direction of the raycast. When the projectile hits an object, it gets destroyed [EnemyElliminate.cs](Assets%2FScripts%2F2-npc%2FEnemyElliminate.cs).



## Credits
Graphics:
* [Sci-Fi Soldier](https://assetstore.unity.com/packages/3d/characters/humanoids/sci-fi/sci-fi-soldier-29559)

