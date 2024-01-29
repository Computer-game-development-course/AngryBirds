# Angry Birds 3 Levels

The game was built as part of an assignment in a computer game development course.

## Levels

The game has the following 3 levels.

### Level 1

In this level, the pig is positioned on the ground. The player must aim the bird using a slingshot to hit the pig.
![image](https://github.com/Computer-game-development-course/AngryBirds/assets/77205478/5f0234b5-583d-4c64-9407-64bc3b0bd9a4)

### Level 2

The pig is now located inside a building. The player needs to navigate the bird through the building's structure to hit the pig.
![image](https://github.com/Computer-game-development-course/AngryBirds/assets/77205478/8a4f7eac-69e5-47a7-b3b9-7582ee9d1835)


### Level 3

The pig is placed inside a pit in the ground. The player needs to aim the bird to hit the pig within the pit.
![image](https://github.com/Computer-game-development-course/AngryBirds/assets/77205478/69f48904-a2b3-436a-9073-002d47207c8c)


## Code Details

### BirdPlayer Script

- Manages the player-controlled bird.
- Implements slingshot mechanics for aiming and launching the bird with the SpringJoint2D.
- Handles collision events with enemies, walls, bricks, and the ground.
- Displays UI elements for reloading the level or progressing to the next level based on the player's performance.

### PigEnemy Script

- Controls the behavior of the pig enemy.
- Handles collision events with the player, bricks, and walls.
- Triggers UI elements to show when hit by the player or a moving brick.

### Levels Script

- Manages level transitions and reloading.
- Provides methods to retry the current level or move to the next level.

## How to Play

- Aim the bird by clicking and dragging it within the slingshot range.
- Release the mouse button to launch the bird.
- Hit the pig enemy to progress to the next level.
- If the bird doesn't hit the pig, UI elements will guide you to either retry the level or move on to the next level (when the pig was destroy by the bird but not directly).

### UI Elements

- nextLevelUI: Displays when the bird successfully hits the pig, prompting the player to move to the next level.
- reloadLevelUI: Appears if the bird collides with the ground or walls without hitting the pig, allowing the player to retry the current level.
