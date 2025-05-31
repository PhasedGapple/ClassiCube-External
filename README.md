# HackMee for ClassiCube
A external for ClassiCube.

## Features

- **Force Noclip**  
  An external Noclip switch

- **Force Hax**  
  Re-enables Hax when a server disables it

- **Description**  
  Lets you view some client info such as FPS, Position (unfinished)

- **Teleport**  
  Lets you teleport to given coordinates

- **Spoof Client**  
  Changes the Client name after rejoining a CPE server (buggy)

- **Load Lua file**
  Lets you load lua files using the Lua API


## Why doesn't the external work for me
Make sure you have clicked the **Detect Client** button after going ingame and your ClassiCube exe is called "ClassiCube.exe".<br>
I do not give support on versions older than **ClassiCube 1.3.5**<br>
If you are still having problems, create a **issue** and tell me your ClassiCube version and the issue ur having.<br>

## Dependencies
- Windows
- .NET 6.0 or later


## Lua API
Lets you code lua plugins which arent too bad
- **``NoclipSwitcher(bool)``**
  Lets you turn on and off Noclip by passing true or false
- **``Teleport(Vector3)``**
  Lets you teleport to given coordinates as a Vector3
- **``GetPosition()``**
  Returns the position of the player as a Vector3
- **``SwitchHax(bool)``**
  Turns off and on Hax by passing true or false
- **``SpoofClient(string)``**
  Spoofs the client name to the given string
- **``MessageBox(message, name)``**
  Spawns a MessageBox by giving the message and the name of the plugin
- **``wait(seconds, callback)``**
  Waits a amount of seconds and then calls the given function (callback)


## To-Do
- [ ] Add custom client support
- [ ] Fix the FPS in description
- [ ] View ping in description
- [ ] Redesign the UI
- [ ] Let plugins read/write own offsets
- [ ] Add UI for plugins using the API
- [ ] Let users turn off/on plugin safety
- [ ] Use a lua sandbox (for safety)
