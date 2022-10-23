## **Unity Test Challenge**

##### Unity Tasks for UI and Mechanics
#### Setup:
- [Install Unity 2021.3.5f1](https://unity3d.com/get-unity/download/archive) (Project is built on this stable version)
- [Fork Repository to your GitHub](https://github.com/vanja032/UnityTestChallenge.git) or clone the project to local from the **initial** branch
- Import Project to Unity and make sure to select PC platform (Win/Mac) before opening
- Development resolution in GameView should be 1920x1080

#### Game Description:
We are working on a [platformer game](https://assetstore.unity.com/packages/templates/platformer-microgame-151055https://assetstore.unity.com/packages/templates/platformer-microgame-151055). Game Mechanics are implemented and working for the PC platform. For controls, we are using standard keys: wasd/arrows + space. You can try out the gameplay by opening MainScene, going into play mode, and hitting the play button.

The player can collect tokens by going through them and killing enemies by jumping on them. If the player collides with the enemy, it will be game over. The same thing goes for a player falling from the platform. In order to win, the player needs to reach the end of the level without dying.
#### Tech Description:
The project consists of two scenes: **MainScene** (from which we start the game) and **LevelScene** (which is used for gameplay).

On the MainScene you will find **Main Menu Canvas** with the attached script: **MainMenuCanvas.cs** which is used for implementing entering a username and starting the game.

On the LevelScene you will find **Level UI Canvas** with the attached script: **LevelCanvas.cs** which you should use for adding in-game UI, Lose, Win and Pause menu.

**GameDatabase.cs** holds information regarding **CurrentUser** which you can use for displaying username, a number of collected tokens, killed enemies, or end score.

Gameplay is realized through scheduling events that are executed on Tick in Simulation. Feel free to explore this on your own. Relevant Classes: **Simulation.Event<T>, Simulation,** etc.

All resources needed for the UI can be found in the folder: **Assets/Resources**
#### End Goal:
[Video of completed game UI implementation](https://drive.google.com/file/d/1a0Sw97lHh7eRRrzLEMzPh8SWcipBAmtG/view?usp=sharing)
### Main Menu:
- There is a title of the game, text input for username, and a button for playing the game
- **[TODO]** Play button should be interactable only if the username is entered
- By clicking on the Play button user will be transferred to LevelScene and the game will start

### Level Scene:
- **[TODO]** In the top left corner, we should display the username
- When a user starts the level amount of tokens and enemies killed will be reset to zero
- In the right corner, we will display the number of enemies killed and tokens that the player collected
- In the bottom right corner, there is a pause button that when clicked should open the Pause Menu
- **Pause Menu** has three options:
  - **[TODO]** Resume - which should close the pause menu and return the user to the game
  - Main Menu - which takes you back to the main menu
  - Restart - which will restart Level and return the user to the beginning of the level



- The game is ended when the user either gets killed by an enemy/falls from the platform or if the player reaches the victory area
- **[TODO]** If the user lost the level, the Level Ended Popup should be shown with the title: **"LEVEL LOST"** in **red** color
- **[TODO]** If the user won the level, the Level Ended Popup popup should be shown with the title: **"LEVEL WON"** in **green** color
- Both of these popups have also options for Replay and going back to Main Screen  

### Player Controller Mechanics:
- **[TODO]** Make a mobile input for the player character controller (Bonus)



#### Additional Resources:
- [job fair gameplay.mp4](https://drive.google.com/file/d/1a0Sw97lHh7eRRrzLEMzPh8SWcipBAmtG/view?usp=sharing)
- [Screen Previews](https://drive.google.com/drive/folders/175QLrnE8aIzhR2NF0tb64Ec8NFekZrkc?usp=sharing)
#### Bonus Points:
- Let's be honest - this game is kinda fun, but there are a lot of opportunities to make it much better
- Feel free to add more features, new enemies, weapons, new levels, different end conditions
- Does UI support different aspect ratios? Everything from 4:3 to 21:9?
- Make it mobile? Go crazy and earn some bonus points!
- If you decide to go wild - make sure to tell us what have you done so we make sure to check it out!

Good luck!

###### *If you want to see the completed project, check the completed branch*


*[Project taken from source](https://github.com/Nordeus/jobfair21-frontend-challange.git)*
