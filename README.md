
# Jump2

&nbsp;&nbsp;&nbsp;&nbsp; A platformer game I developed in Unity for school, Jump2, is influenced by <b>Jump King</b>, where players make their way through the level leaping to the top. However, one missed jump can have you back at the beginning of the game. The game can be downloaded <a href = "">here</a> if you'd like to play it for yourself!

&nbsp;&nbsp;&nbsp;&nbsp; This was an assignment in my small games programming class where the goal was to develop a game that can only be played with mouse clicks similar to how a mobile game can be played with your hands. While some of my peers ventured off into developing tower defense games or idle click games, I thought it would be fun to develop a platformer with these restrictions. Immediately I hit a creative block as many platformer games involve more than one button press and have movement systems that rely on where the player is moving prior to jumping to determine the direction. My solution to this was to have the player jump towards where they click on the screen. This movement system was much more simple than I thought it would be with a simplified pattern that looks like this:

## Movement system 

- Detect where the player's mouse is on the screen
- Flip the sprite toward the mouse direction
- Is the mouse button down and is the player grounded?
- Calculate jump power by the time the mouse button is held down
- If the mouse button is released player will jump toward the mouse

  ## Problems and bugs while developing
  
  &nbsp;&nbsp;&nbsp;&nbsp; A bug that persists when playing this game is when falling and losing the last of your health the death screen won't load or the health bar will continue in the wrong direction. I have tried debugging and changing some of the code to fix this bug but haven't found a way to fix it yet.

  &nbsp;&nbsp;&nbsp;&nbsp; Overall this was a fun project to work on and a great experience to learn how Unity and C# work. 

