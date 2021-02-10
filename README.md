# VRChat_Worlds_Shared
A place to collaborate on our VR Chat worlds

General Practices:

Use Prefabs
  In unity rather than editing the scene directly it is often better to split sections of your scene into prefabs and edit them. This way when changing that part you only have to push the prefab not the scene. This avoids unnesesary merge conflicts when multiple people are working on the same scene at the same time.
  
Use Branches
  When making a change check out a branch for that change make your edits before merging it into staging. This is because it is easier to fix merge conflicts betwean branches and you are less likely to lose progress.
  
<Working> -> Staging -> Master
  The master branch should be a stable version of what we would build for VRChat. The staging branch should be whet we are pretty sure works, and is where we merge our new features together when we have tested them. Any other branch is a working branch ad is where your testing and feature aditions should be compleated before merging them into staging.

---

# Errors Galore Fix
Please use this USharp unity package https://github.com/MerlinVR/UdonSharp/releases/tag/v0.19.2

  Because of GitHub locking out some files, you will have to Import this and to do so:
    <br><\br>
    Right Click in Assets -> Import Package -> Select the USharp package
    
  This will have to be done everytime the U# code gets updated over Github's Push and Pull.
