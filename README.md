# DiabloVision
# Ability to alter the camera pespective in Diablo 2 Resurrected (D2R) to any angle desired.

Firstly, this code in this repo is a HOT MESS OF GARBAGE. Although it should work on modern Windows 10 most of the time....is for the purposes of Proof of Concept and for novices to have a way to figure out how to alter the D2R.exe memory addresses on the fly. You actually only need 4 addresses/values (same difference one just means pointer to a value the other is, obviously, simply the value you're wanting to have stored somehwere in memory.

![1](https://user-images.githubusercontent.com/108437078/183261766-755d0d43-97b2-422d-aaef-74e5604e9726.png)

Here are some of the values that I have located in D2R.exe. From as far as I can tell there, there are a great deal of similarities between the data structures in memory and those from the original Diablo 2 executable files. There are of course, a great deal of dissimilarities too which means everything must be examined to the fullest extent before attempting anything online. That goes for any sort of cheating in any games...multiplayer is a very different game mode from your standard single player experience and if you decide to cheat in it you know what the risk you are playing is with your game of choice. Do I think Blizzard would ban somebody simply for looking down at their character at a slightly modified view that's not normally possible? I don't think they would, but buyer beware. And much less is known about the D2R.exe, for example where in general does the game executable draw the line between somebody modding, and somebody trying to cheat or cheating? I have heard that there are literal functioning Path of Exile-style filters you can get from Nexus Mods all over the place. Whatever version of warden it happens to be running (probably one of the really, really bad versions that literally runs in ring3 catching cheaters right there along with Calculator. (calc.exe)

You can either use the app or the .CT Cheat Engine cheat table with Cheat Engine. Only for use in single player.
It's recommended you firewall your D2R.exe game executable off with Windows Firewall before use if you want to be absolutely safe.
If you use this on Battle.net, you will almost certainly be banned.

NOTE: YES you can cheat/hack/mod/alter to your hearts content as long as you are in single player ONLY, and NO they will not ban you. I almost always firewall off my D2R.exe first however anytime I am working on development to be absolutely safe, I make sure Cheat Engine is closed, I've rebooted clean, and then and only then I may play on Battle.net. 

NOTE: In your Cheat Engine settings, you may need to ensure that MEM_MAPPED under Scan Settings is checked. The option that needs to be check says "MEM_MAPPED:Memory that is mapped into the view of a section (Eg File mapping, emulator memory, slow)"
