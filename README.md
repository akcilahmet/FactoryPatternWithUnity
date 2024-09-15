
# Unity Factory Pattern Example

## Watch:
<video src="https://github.com/user-attachments/assets/5e694067-1555-45e2-bcea-a33ce9995a0d"></video>

## UML Diagram
![FactoryPattern](https://github.com/user-attachments/assets/b952825d-ea3f-4f11-b2bb-f873ee35a6a8)


## What is the Factory Pattern?
The Factory Pattern is a design pattern that provides a way to create objects without specifying the exact class. It allows subclasses to decide which type of object to instantiate.
    
## Benefits

- **Decoupling**: Separates object creation from the main logic, making the code more flexible.
- **Flexibility**: New object types can be added with minimal changes.
- **Maintainability**: Centralizes the creation logic, making updates easier.
- **Scalability**: Allows new types to be added without modifying existing code, reducing the risk of bugs.

## Project Structure
- **FactoryManager**: This class is responsible for managing and registering the different factories used in the game. It ensures that all factories are available and can be accessed as needed.
- **Factory**: Abstract base class that provides the information for enemy creation.
- **IEnemy**: This interface defines the basic information for all enemy types. Each enemy type must implement the `Initialize` method to define its behavior.
- **EnemySpawnManager**: Handles enemy spawning based on user input (mouse click).
- **WarriorFactory, MagicFactory, ArcherFactory**: These concrete factory classes inherit from the abstract `Factory` class and are responsible for creating specific enemy types.
- **WarriorEnemy, MagicEnemy, ArcherEnemy**: These are the different enemy classes, each implementing the `IEnemy` interface.

## How It Works
1. The `FactoryManager` registers all available factories (Warrior, Magic, and Archer) in the game.
2. When the player clicks on the screen, the `EnemySpawnManager` selects a random factory and spawns the corresponding enemy at the clicked position.
3. The spawned enemy is initialized and can be controlled or modified depending on the gameplay requirements.

## Requirements
- Unity 2020.3 or later

## How to Use

1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/your-username/your-repository.git
    ```

2. Open the project in Unity.

3. Play the scene and click anywhere on the screen to spawn enemies.

