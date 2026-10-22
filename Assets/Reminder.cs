// When you edit the player, you must give it a Character Controller and a Collider of some form.
// Then set the Cinemachine's target to the player character.
// Lastly, set the new Character Controller inside of PlayerController. Camera following and movement will now work ^^

// Should you need to set up buttons, drag the script in the scene onto the interaction in the button.
// Once its the object referenced in the interaction, search for 'LoadSceneByIndex (int)', and set it to the desired scene.

// The die1 script checks for collision between two objects, with one tagged Player.
// The player must have the Player tag, and the object you collide with must have the "Is Trigger" flag set to true.
// Then, within the die1 script on the object, set the value to the index ID of the intended scene.
// If you want to load the current scene and/or increment lives, use the LoseLife script instead.

// For new sprites, if they are pixelated, set the PNG aniso value to 12 on Point (no filter) and it should be cleaner.

// When attempting to destroy one object composed of multiple, smaller objects, make the colliding object the parent and all children will be destroyed also.

// On main menu/lose screens, set lives and gold to a pre-determined value (one life, zero gold).