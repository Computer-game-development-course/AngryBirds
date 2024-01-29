# Angry Birds 3 Levels

The game was built as part of an assignment in a computer game development course.

- [Click here to play on itch.io]()

## Levels

The game has the following 3 levels.

### Level 1

In this level, the pig is positioned on the ground. The player must aim the bird using a slingshot to hit the pig.

### Level 2

The pig is now located inside a building. The player faces the challenge of navigating the bird through the building's structure to hit the pig.

### Level 3

The pig is placed inside a pit in the ground. The player needs to aim the bird accurately to hit the pig within the pit.

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
- If the bird doesn't hit the pig, UI elements will guide you to either retry the level or move on to the next level.

### UI Elements

- nextLevelUI: Displays when the bird successfully hits the pig, prompting the player to move to the next level.
- reloadLevelUI: Appears if the bird collides with the ground or obstacles without hitting the pig, allowing the player to retry the current level.
