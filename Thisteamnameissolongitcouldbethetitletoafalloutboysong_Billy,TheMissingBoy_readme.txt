Team: This team name is so long it could be the title to a fall out boy song
Game: Billy, The Missing Boy
Members: Linsey Chen, Jieun Seong, Eduardo Rodriguez, Kaitlyn Werho, Jacquelyn Burlison
Start Scene: startGame

How to Play:
Directional Arrows/WASD: Movement in the given direction
Q: Punch
V: Magic attack
E: Interact with something (yellow circle on the ground indicates you can interact here)
Space: Jump
Mouse Click: Go to next piece of dialogue
Escape: Open in-game menu screen
* Note that moving the mouse controls the camera

Upon selecting start new game from the startGame scene, the player will enter the "project" scene, where the gameplay takes place. The dialogue box on the screen will welcome the player and alert them of the first mission: meet up with friends. The player should then find their friends (they are visible upon the start of the scene) and click "E" near the yellow circle on the ground. Note that the player can only interact here if at least one of the friends has already arrived. Upon clicking "E", a dialogue box will open and inform the player of their second mission: find a missing boy. After the dialogue has finished, the NPC friends will eventually leave to go search for him, walking to a variety of waypoints. The missing boy turns out to be a zombie which will follow and attack the player within a certain distance, and he is initially located behind a building on the left. To fight the zombie, the player must use either Q or V to attack, which will lower the zombie's health bar. The zombie will eventually stop following the player if the player gets far enough away. There are also items located on the road near the start of the scene. By colliding with the objects, the player can add them to inventory. To view the inventory, navigate to the in-game menu screen by clicking Escape and then click "Inventory." From the in-game menu screen, one can also restart or close the game. 

Known Problem Areas:
- Dialogue system needs to be further refined in various ways. For example, if the player does not click through the dialogue at the beginning, the dialogue with the friends will not function correctly. Additionally, the NPC friends will eventually leave without finishing dialogue if the player does not click through the dialogue with them. Finally, we would also like to add buttons to the dialogue box so that the player can influence the dialogue and narrative.
- Inventory and items are not yet fully operational yet. Currently, the items will be added to inventory upon player collision, but we have not yet implemented the functionality for the items to be clicked from inventory and used. Additionally, we still need to add audio effects for colliding with/picking up items.
- Camera shakes slightly while backing up
- Player character animation needs improvement. It looks like the character is sliding on the ground. However, when we enable root motion, it doesn't move or moves very fast. 


Team Member Breakdown:
Jacquelyn: 
I was responsible for creating the NPC AI, the zombie (avatar and animations are from unity asset store, zombie controller script and animator controller were made by me), the health bars, and the fighting functionality between the player and enemies.

Assets/Animations/Etc_Walk_Zombi_01.anim
Assets/Animations/Etc_Walk_Zombi_01.anim.meta
Assets/Animations/Fast Run.fbx.meta
Assets/Animations/Jumping.fbx.meta
Assets/Animations/NPCAnimController.controller
Assets/Animations/NPCAnimController.controller.meta
Assets/Animations/PlayerAnimations/Falling Forward Death.fbx.meta
Assets/Animations/PlayerAnimations/Walking.fbx.meta
Assets/Animations/Running.fbx.meta
Assets/Animations/Walking.fbx.meta
Assets/Animations/Y_Bot@idle.fbx
Assets/Animations/Y_Bot@idle.fbx.meta
Assets/Animations/Zombie Controller.controller
Assets/Animations/Zombie Controller.controller.meta
Assets/Animations/ZombieAnimationPackFree.meta
Assets/Animations/ZombieAnimationPackFree/Animations.meta
Assets/Animations/ZombieAnimationPackFree/Animations/10-death_fall_backward.fbx
Assets/Animations/ZombieAnimationPackFree/Animations/10-death_fall_backward.fbx.meta
Assets/Animations/ZombieAnimationPackFree/Animations/2-attack_inversed_horizontal_right_hand.fbx
Assets/Animations/ZombieAnimationPackFree/Animations/2-attack_inversed_horizontal_right_hand.fbx.meta
Assets/Animations/ZombieAnimationPackFree/Etc_Walk_Zombi_01.anim
Assets/Animations/ZombieAnimationPackFree/Etc_Walk_Zombi_01.anim.meta
Assets/Animations/ZombieAnimationPackFree/Models.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2.mat
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2.mat.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2_GLASS.mat
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2_GLASS.mat.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Mesh.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Mesh/BH-2 Free.fbx
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Mesh/BH-2 Free.fbx.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_AlbedoTransparency.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_AlbedoTransparency.png.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Emission.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Emission.png.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Normal.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Normal.png.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_SpecularSmoothness.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_SpecularSmoothness.png.meta
Assets/DialogueData.meta
Assets/DialogueData/FriendDialogue.asset
Assets/DialogueData/FriendDialogue.asset.meta
Assets/DialogueData/Test.asset
Assets/DialogueData/Test.asset.meta
Assets/DialogueData/pressEDialogue.asset
Assets/DialogueData/pressEDialogue.asset.meta
Assets/HealthBarPrefab.prefab
Assets/HealthBarPrefab.prefab.meta
Assets/HealthBarSprites.meta
Assets/HealthBarSprites/Bar.png
Assets/HealthBarSprites/Bar.png.meta
Assets/HealthBarSprites/Heart.png
Assets/HealthBarSprites/Heart.png.meta
Assets/Prefabs/HealthBarPrefab.prefab
Assets/Prefabs/HealthBarPrefab.prefab.meta
Assets/Prefabs/ZombiePrefab.prefab
Assets/Prefabs/ZombiePrefab.prefab.meta
Assets/Scenes/gameMenu.unity
Assets/Scenes/project.meta
Assets/Scenes/project.unity
Assets/Scenes/project/NavMesh.asset
Assets/Scenes/project/NavMesh.asset.meta
Assets/Sounds.meta
Assets/Sounds/POL-owl-woods-short.wav
Assets/Sounds/POL-owl-woods-short.wav.meta
Assets/Template/ExampleAssets/Materials/Plastic_Yellow_Mat.mat
Assets/Template/Presets/NormalTexture.preset
Assets/Template/Presets/UtilityTexture.preset
Assets/Zombie.meta
Assets/Zombie/Materials.meta
Assets/Zombie/Materials/RetopoPantsUV_TXTR.mat
Assets/Zombie/Materials/RetopoPantsUV_TXTR.mat.meta
Assets/Zombie/Materials/ZombieHQ_material4_Albedo.mat
Assets/Zombie/Materials/ZombieHQ_material4_Albedo.mat.meta
Assets/Zombie/Materials/ZombieHQ_material5_AlbedoTransparency.mat
Assets/Zombie/Materials/ZombieHQ_material5_AlbedoTransparency.mat.meta
Assets/Zombie/Materials/ZombieHQ_material_AlbedoTransparency.mat
Assets/Zombie/Materials/ZombieHQ_material_AlbedoTransparency.mat.meta
Assets/Zombie/Materials/material.001.mat
Assets/Zombie/Materials/material.001.mat.meta
Assets/Zombie/Materials/material.002.mat
Assets/Zombie/Materials/material.002.mat.meta
Assets/Zombie/Materials/material.003.mat
Assets/Zombie/Materials/material.003.mat.meta
Assets/Zombie/Materials/material.005.mat
Assets/Zombie/Materials/material.005.mat.meta
Assets/Zombie/Materials/material.mat
Assets/Zombie/Materials/material.mat.meta
Assets/Zombie/PantsALpha1.png
Assets/Zombie/PantsALpha1.png.meta
Assets/Zombie/ZombieHQ_material1_Normal.png
Assets/Zombie/ZombieHQ_material1_Normal.png.meta
Assets/Zombie/ZombieHQ_material1_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material1_SpecularSmoothness.png.meta
Assets/Zombie/ZombieHQ_material2_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material2_AlbedoTransparency.png.meta
Assets/Zombie/ZombieHQ_material2_Ambient.png
Assets/Zombie/ZombieHQ_material2_Ambient.png.meta
Assets/Zombie/ZombieHQ_material2_Normal.png
Assets/Zombie/ZombieHQ_material2_Normal.png.meta
Assets/Zombie/ZombieHQ_material2_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material2_SpecularSmoothness.png.meta
Assets/Zombie/ZombieHQ_material3_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material3_AlbedoTransparency.png.meta
Assets/Zombie/ZombieHQ_material3_Ambient.png
Assets/Zombie/ZombieHQ_material3_Ambient.png.meta
Assets/Zombie/ZombieHQ_material3_Normal.png
Assets/Zombie/ZombieHQ_material3_Normal.png.meta
Assets/Zombie/ZombieHQ_material3_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material3_SpecularSmoothness.png.meta
Assets/Zombie/ZombieHQ_material4_Albedo.png
Assets/Zombie/ZombieHQ_material4_Albedo.png.meta
Assets/Zombie/ZombieHQ_material4_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material4_AlbedoTransparency.png.meta
Assets/Zombie/ZombieHQ_material4_Ambient.png
Assets/Zombie/ZombieHQ_material4_Ambient.png.meta
Assets/Zombie/ZombieHQ_material4_Normal.png
Assets/Zombie/ZombieHQ_material4_Normal.png.meta
Assets/Zombie/ZombieHQ_material4_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material4_SpecularSmoothness.png.meta
Assets/Zombie/ZombieHQ_material5_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material5_AlbedoTransparency.png.meta
Assets/Zombie/ZombieHQ_material5_Ambient.png
Assets/Zombie/ZombieHQ_material5_Ambient.png.meta
Assets/Zombie/ZombieHQ_material5_Normal.png
Assets/Zombie/ZombieHQ_material5_Normal.png.meta
Assets/Zombie/ZombieHQ_material5_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material5_SpecularSmoothness.png.meta
Assets/Zombie/ZombieHQ_material_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material_AlbedoTransparency.png.meta
Assets/Zombie/ZombieHQ_material_Normal.png
Assets/Zombie/ZombieHQ_material_Normal.png.meta
Assets/Zombie/ZombieHQ_material_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material_SpecularSmoothness.png.meta
Assets/Zombie/ZombieRig.fbx
Assets/Zombie/ZombieRig.fbx.meta
Assets/Zombie/ZombieRig.prefab
Assets/Zombie/ZombieRig.prefab.meta
ProjectSettings/TagManager.asset
Thisteamnameissolongitcouldbethetitletoafalloutboysong_Billy,TheMissingBoy_readme.txt

Assets/Scripts/DialogueObject.cs
Assets/Scripts/DialogueObject.cs.meta
Assets/Scripts/DialogueUI.cs
Assets/Scripts/DialogueUI.cs.meta
Assets/Scripts/FaceCamera.cs
Assets/Scripts/FaceCamera.cs.meta
Assets/Scripts/FaceCameraScript.cs
Assets/Scripts/FaceCameraScript.cs.meta
Assets/Scripts/HealthBarScript.cs
Assets/Scripts/HealthBarScript.cs.meta
Assets/Scripts/NPCAI.cs
Assets/Scripts/NPCAI.cs.meta
Assets/Scripts/PlayerController2.cs
Assets/Scripts/Typewriter.cs
Assets/Scripts/Typewriter.cs.meta
Assets/Scripts/ZombieControlScript.cs
Assets/Scripts/ZombieControlScript.cs.meta

Linsey - 

Jieun:
I was responsible for character controller, input, locomotion animations, attack animations, third person camera, particle effect, ambience noise, character audio
Assets/Animations/Jumping.fbx.meta
Assets/Animations/PlayerAnimationController.controller
Assets/Animations/PlayerAnimations.meta
Assets/Animations/PlayerAnimations/Cross Punch.fbx
Assets/Animations/PlayerAnimations/Cross Punch.fbx.meta
Assets/Animations/PlayerAnimations/Falling Forward Death.fbx
Assets/Animations/PlayerAnimations/Falling Forward Death.fbx.meta
Assets/Animations/PlayerAnimations/Fast Run.fbx
Assets/Animations/PlayerAnimations/Fast Run.fbx.meta
Assets/Animations/PlayerAnimations/Idle.fbx
Assets/Animations/PlayerAnimations/Idle.fbx.meta
Assets/Animations/PlayerAnimations/Jumping.fbx
Assets/Animations/PlayerAnimations/Jumping.fbx.meta
Assets/Animations/PlayerAnimations/Running.fbx
Assets/Animations/PlayerAnimations/Running.fbx.meta
Assets/Animations/PlayerAnimations/Standing 1H Magic Attack 01.fbx
Assets/Animations/PlayerAnimations/Standing 1H Magic Attack 01.fbx.meta
Assets/Animations/PlayerAnimations/Walking.fbx
Assets/Animations/PlayerAnimations/Walking.fbx.meta
Assets/Eiri.fbx.meta
Assets/Nature - Essentials.meta
Assets/Nature - Essentials/Ambiance_Forest_Birds_Loop_Stereo.wav
Assets/Nature - Essentials/Ambiance_Forest_Birds_Loop_Stereo.wav.meta
Assets/New Terrain.asset
Assets/Prefabs/EiriPrefab.prefab
Assets/Prefabs/EiriPrefab.prefab.meta
Assets/Prefabs/PlayerPrefab.prefab
Assets/Prefabs/PlayerPrefab.prefab.meta
Assets/Prefabs/player.prefab
Assets/Scenes/just_character.unity
Assets/Scenes/just_character.unity.meta
Assets/Scenes/project.unity
Assets/StarterAssets/ThirdPersonController/Character/Sfx.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_01.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_01.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_02.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_02.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_03.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_03.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_04.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_04.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_05.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_05.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_06.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_06.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_07.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_07.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_08.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_08.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_09.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_09.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_10.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_10.wav.meta
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Land.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Land.wav.meta

Assets/Scripts/CharAnimScript.cs
Assets/Scripts/CharAnimScript.cs.meta
Assets/Scripts/FaceCameraScript.cs
Assets/Scripts/PlayerController.cs
Assets/Scripts/PlayerController.cs.meta
Assets/Scripts/PlayerController2.cs
Assets/Scripts/QuaternionUtil.cs
Assets/Scripts/QuaternionUtil.cs.meta
Assets/Scripts/ThirdPersonCamera.cs
Assets/Scripts/ThirdPersonCamera.cs.meta

Kaitlyn - 
Eduardo - 


--
Assets/Prefabs/itemDrops/BatteryDrop Variant.prefab
Assets/Prefabs/itemDrops/BulletDrop Variant.prefab
Assets/Prefabs/itemDrops/FirstAidBox Variant.prefab
Assets/Prefabs/itemDrops/FuelDrop Variant.prefab
