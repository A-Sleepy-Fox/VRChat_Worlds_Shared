# VRChat_Worlds_Shared
A place to collaborate on our VR Chat worlds

General Practices:

Use Prefabs
  In unity rather than editing the scene directly it is often better to split sections of your scene into prefabs and edit them. This way when changing that part you only have to push the prefab not the scene. This avoids unnesesary merge conflicts when multiple people are working on the same scene at the same time.
  
Use Branches
  When making a change check out a branch for that change make your edits before merging it into staging. This is because it is easier to fix merge conflicts betwean branches and you are less likely to lose progress.
  
<Working> -> Staging -> Master
  The master branch should be a stable version of what we would build for VRChat. The staging branch should be whet we are pretty sure works, and is where we merge our new features together when we have tested them. Any other branch is a working branch ad is where your testing and feature aditions should be compleated before merging them into staging.
