# PhasmoRandomizer
Phasmophobia Randomizer inspired by Insym

Hello my name is Mytzi and I decided to make a small windows application for
the Randomizer game mode invented by Insym in Phasmophobia.
The purpose of this application is to help everyone play this game mode with a few simple clicks.
The application consists of 3 randomized factors, which are player count, map and items.
In order to use the application it has to load a config file called PhasmoSettings.json.

Security:
This application is not certified and will therefor be untrusted by your computer.
In order to get rid of the warning when starting the randomizer you have to do following steps:
   -Right-click on the file and select "Properties" from the menu.
   -Click "Unblock" on the General tab.
   -Click OK
To ensure that the application is not doing some weird stuff, I made it public on GitHub.
The code is open source and you can read, download and compile it to your hearts content :D.
Link: 

Usage:
1. Make sure the PhasmoRandomizer.exe and PhasmoSettings.json file are located in the same folder
2. Open the PhasmoRandomizer.exe
(3. If the PhasmoSettings.json file can't be loaded then open it manually in the open file dialog which appears.)
4. Press Roll buttons for players, map and items
5. Press New if you want to make a new game

Hints:
- Check out the dark mode version, it might look better to you.
- You can roll all items at once with the "Roll all" button
- You can define how many items are rolled for every player in the item tab, but it will be grayed out after rolling the first item.
- You can reroll items with the button below the item grid. In order to reroll an item, you have to select it in the grid before!
- If new items or maps are added to the game simply add them to the PhasmoSettings.Json file.
- The "New" button will always reload the config file.
- The "Roll all" button will change into a "Clipboard" button once all items are rolled. 
  With this button you can copy an overview of all the randomized stuff as text to your clipboard.
- You can use the Randomizer without a config file too by closing the open file dialog and pressing continue in the windows error. 
  This will load some hard coded default config.
- Player names can be changed in the config file if desired.  
- Reroll item will never roll to the same item (or to an item the player already has if playerCanHaveDoubleItems is false).
- The PlayerCanHaveDoubleItems config will prevent that one player can roll the same item multiple times if it is false. 
  Although different players can still roll the same item (for example everyone rolling flashlight will work).

PhasmoSettings.Json config file:
This config file is used so everyone can customize the randomized values on their own.
In order to customize the config file, simply open it with an editor and modify your desired values.
For example if you want to always play with 4 people you can set "minPlayerCount": 4
The availableItems list consists of numbers for every item, which indicates how many of these items can be rolled.
If you for example wish to have every item in the game only once, you can simply set all these numbers to 1.
The randomizer also allows you to reroll items a certain amount of times, which is also defined in the conig file.

Thanks to Insym for inventing this game mode.
Check out his twitch or youtube:
https://www.twitch.tv/insym
https://www.youtube.com/channel/UC5uNya42ayhsRnZOR3mO6NA
