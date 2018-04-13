--- Inventory and item system for Unity 3D - Allows your player to pick up items and store them in its inventory!
It allows you to create game objects of type Item, a type the Item class defines.

The entire system consists of five classes:

* Interactable: a fathering class from which items inherit properties (but can be used for lot's if wanted: doors, chests, etc.). 
This class draws a sphere gizmo around the interactable game object: the radius. A player can interact with the object if it is 
inside the radius. A message prompt saying "Press E to interact" is shown if that is the case.

* Item: this is not a monobehaviour, but a ScriptableObject. It allows us to create an Item object, which holds data such as name, icon 
and else. You can create this object by clicking right click in your assets, Create --> Inventory --> Item. Cool, huh? It must 
be dragged into the Item public variable of a Game Object that holds the ItemPickUp script (see following).

* ItemPickUp: this class receives Interactable's heritage, and defines the Item type of interactable 
(the type of interactable you can pick up and store in your inventory). It must be attached to a Game Object.

* Inventory: a class which defines an inventory based on an Item's list. It uses a singleton. It holds functions such as AddToInventory(), 
UpdateInventoryUI() (which makes the inventory UI show what objects are in inventory), RemoveFromInventory() and a IsInInventory(),
(a Boolean method which returns true if a given object is in inventory). It must be attached to the Player.

* MessagePromptUI: an extremely simple script which handles what message (if any) to be shown as a message prompt (such as 
'Press E to pick up the object' or 'Press H to light the flare'). It must be attached to an UI Text object. 

--- This has been tested and works fine. To create an item simply create a game object and attach the ItemPickUp script to it. 
Also create an Item object (Create --> Inventory --> Item) and modify its values to fit your game object. 
Then, when your Item object is done, drag it into the Item public variable of the ItemPickUp script, on your game's object inspector. 
Simple!

(You'll need to attach the Inventory script to the Player, and create an InventoryUI Textand a MessagePrompt UI text. Drag your InventoryUI
text into the InventoryUI public variable of your Inventory script (should be in your Player if you attached Inventory class
to it).) 

This was made to improve my Zombie Runner game. Zombie Runner is one of the many projects of Learn to Code by Making Games, an amazing GameDev course on Unity and C#. 
