# PhasmoRandomizer
Phasmophobia Randomizer inspired by Insym

Hello my name is Mytzi (aka Elvenking) and I decided to make a small windows application for
the Randomizer game mode invented by Insym in Phasmophobia.
The purpose of this application is to help everyone play this game mode with a few simple clicks.
The application consists of 3 randomized factors, which are player count, map and items.
In order to use the application it has to load a config file called PhasmoSettings.json.
Simply unzip everything to the same folder and it should work fine.

Preview pictures:
Map wheel
![alt text](https://i.imgur.com/tL7UPT8.jpg)
Item wheel
![alt text](https://i.imgur.com/PaRZCwI.jpg)
Item grid
![alt text](https://i.imgur.com/SWB1kcb.jpg)
Config dialog
![alt text](https://i.imgur.com/kQ0O97M.jpg)

Security:
This application is not certified and will therefor be untrusted by your computer.
In order to get rid of the warning when starting the randomizer you have to do following steps:
   -Right-click on the file and select "Properties" from the menu.
   -Click "Unblock" on the General tab.
   -Click OK

To ensure that the application is not doing some weird stuff, I made it public on GitHub.
The code is open source and you can read, download and compile it to your hearts content :D.

Usage:
1. Make sure the PhasmoRandomizer.exe, the PhasmoSettings.json file and all .dll files are located in the same folder!
2. Open the PhasmoRandomizer.exe
(3. If the PhasmoSettings.json file can't be loaded then open it manually in the open file dialog which appears.)
4. Press Roll buttons for players, map and items
5. Press New if you want to make a new game
6. Press Config for customization of the randomizer.

Hints:
- Some settings are only active after pressing "New".
- You can roll all items at once with the "Roll all" button.
- You can define how many items are rolled for every player in the item tab, but it will be grayed out after rolling the first item.
- You can reroll items with the button below the item grid. In order to reroll an item, you have to select it in the grid before!
- If new items or maps are added to the game simply add them to the PhasmoSettings.Json file you are loading.
- The "Roll all" button will change into a "Clipboard" button once all items are rolled. 
  With this button you can copy an overview of all items as text to your clipboard.
- The randomizer will auto load the file called "PhasmoSettings.json", 
  if you wish to use a different config file, then you have to load it in the config dialog.
- The randomizer will use a default config if no config file is found or opened.
- Player names can be changed in the config file if desired.  
- Reroll item will never roll to the same item (or to an item the player already has if playerCanHaveDoubleItems is false).
- The PlayerCanHaveDoubleItems config will prevent that one player can roll the same item multiple times if it is false. 
  Although different players can still roll the same item (for example everyone rolling flashlight will work).
- All items have the same probability to be rolled. 
  The cap in the config file only says how often it can be rolled in total.
- If min and max player count is the same, then no player number has to be rolled.
- If you want to ban an item from the randomizer, then set the amount to 0 in the config.
- If you want to ban a map from the randomizer, then uncheck it in the config.
- You can make a shortcut to the PhasmoRandomizer.exe and place it on your desktop.

PhasmoSettings.Json config file:
This file is necessary to save and load all values the randomizer will use for rolling.
You can edit most of the stuff in the config dialog, but it is also possible to directly edit the 
json file in a notepad. 
If new maps or items are added to the game, then they have to be added via notepad.
I will try to keep the config file updated, but it might be outdated at some point and you have to modify it.

Requirements:
- .Net Framework 4.7.2 (with windows 10 you automatically have this).

Thanks to Insym for inventing this game mode.
Check out his twitch or youtube: 
https://www.twitch.tv/insym 
https://www.youtube.com/channel/UC5uNya42ayhsRnZOR3mO6NA
