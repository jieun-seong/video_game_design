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
Assets/Animations/NPCAnimController.controller
Assets/Animations/Y_Bot@idle.fbx
Assets/Animations/Zombie Controller.controller
Assets/Animations/ZombieAnimationPackFree/Animations/10-death_fall_backward.fbx
Assets/Animations/ZombieAnimationPackFree/Animations/2-attack_inversed_horizontal_right_hand.fbx
Assets/Animations/ZombieAnimationPackFree/Etc_Walk_Zombi_01.anim
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2.mat
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2_GLASS.mat
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Mesh/BH-2 Free.fbx
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_AlbedoTransparency.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Emission.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_Normal.png
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Textures/Default/BH-2_SpecularSmoothness.png
Assets/DialogueData/FriendDialogue.asset
Assets/DialogueData/Test.asset
Assets/DialogueData/pressEDialogue.asset
Assets/HealthBarPrefab.prefab
Assets/HealthBarSprites/Bar.png
Assets/HealthBarSprites/Heart.png
Assets/Prefabs/HealthBarPrefab.prefab
Assets/Prefabs/ZombiePrefab.prefab
Assets/Scenes/project.unity
Assets/Scenes/project/NavMesh.asset
Assets/Sounds/POL-owl-woods-short.wav
Assets/Zombie/Materials/RetopoPantsUV_TXTR.mat
Assets/Zombie/Materials/ZombieHQ_material4_Albedo.mat
Assets/Zombie/Materials/ZombieHQ_material5_AlbedoTransparency.mat
Assets/Zombie/Materials/ZombieHQ_material_AlbedoTransparency.mat
Assets/Zombie/Materials/material.001.mat
Assets/Zombie/Materials/material.002.mat
Assets/Zombie/Materials/material.003.mat
Assets/Zombie/Materials/material.005.mat
Assets/Zombie/Materials/material.mat
Assets/Zombie/PantsALpha1.png
Assets/Zombie/ZombieHQ_material1_Normal.png
Assets/Zombie/ZombieHQ_material1_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material2_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material2_Ambient.png
Assets/Zombie/ZombieHQ_material2_Normal.png
Assets/Zombie/ZombieHQ_material2_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material3_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material3_Ambient.png
Assets/Zombie/ZombieHQ_material3_Normal.png
Assets/Zombie/ZombieHQ_material3_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material4_Albedo.png
Assets/Zombie/ZombieHQ_material4_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material4_Ambient.png
Assets/Zombie/ZombieHQ_material4_Normal.png
Assets/Zombie/ZombieHQ_material4_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material5_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material5_Ambient.png
Assets/Zombie/ZombieHQ_material5_Normal.png
Assets/Zombie/ZombieHQ_material5_SpecularSmoothness.png
Assets/Zombie/ZombieHQ_material_AlbedoTransparency.png
Assets/Zombie/ZombieHQ_material_Normal.png
Assets/Zombie/ZombieHQ_material_SpecularSmoothness.png
Assets/Zombie/ZombieRig.fbx
Assets/Zombie/ZombieRig.prefab
ProjectSettings/TagManager.asset
Thisteamnameissolongitcouldbethetitletoafalloutboysong_Billy,TheMissingBoy_readme.txt

Assets/Scripts/DialogueObject.cs
Assets/Scripts/DialogueUI.cs
Assets/Scripts/FaceCamera.cs
Assets/Scripts/FaceCameraScript.cs
Assets/Scripts/HealthBarScript.cs
Assets/Scripts/NPCAI.cs
Assets/Scripts/PlayerController2.cs
Assets/Scripts/Typewriter.cs
Assets/Scripts/ZombieControlScript.cs

Linsey:
I was responsible for enemy death drops, including drop physics and probabilities as well as randomizations for drops for different kinds of drop tables. I also contributed with character design and creation.

Assets/3DModels.meta
Assets/Ammo.meta
Assets/Ammo/Prefabs.meta
Assets/Ammo/Prefabs/Ammo_00.prefab
Assets/Ammo/Prefabs/Ammo_00.prefab.meta
Assets/Ammo/Prefabs/Ammo_01.prefab
Assets/Ammo/Prefabs/Ammo_01.prefab.meta
Assets/Ammo/Prefabs/Ammo_02.prefab
Assets/Ammo/Prefabs/Ammo_02.prefab.meta
Assets/Ammo/Prefabs/Ammo_Pack_00.prefab
Assets/Ammo/Prefabs/Ammo_Pack_00.prefab.meta
Assets/Ammo/Resources.meta
Assets/Ammo/Resources/Geometry.meta
Assets/Ammo/Resources/Geometry/Ammo_00.fbx
Assets/Ammo/Resources/Geometry/Ammo_00.fbx.meta
Assets/Ammo/Resources/Geometry/Ammo_Pack_00.fbx
Assets/Ammo/Resources/Geometry/Ammo_Pack_00.fbx.meta
Assets/Ammo/Resources/Materials.meta
Assets/Ammo/Resources/Materials/Ammo_00.mat
Assets/Ammo/Resources/Materials/Ammo_00.mat.meta
Assets/Ammo/Resources/Materials/Ammo_Ground.mat
Assets/Ammo/Resources/Materials/Ammo_Ground.mat.meta
Assets/Ammo/Resources/Materials/Ammo_Pack_00.mat
Assets/Ammo/Resources/Materials/Ammo_Pack_00.mat.meta
Assets/Ammo/Resources/Textures.meta
Assets/Ammo/Resources/Textures/Ammo_00_AlbedoTransparency.png
Assets/Ammo/Resources/Textures/Ammo_00_AlbedoTransparency.png.meta
Assets/Ammo/Resources/Textures/Ammo_00_MetallicSmoothness.png
Assets/Ammo/Resources/Textures/Ammo_00_MetallicSmoothness.png.meta
Assets/Ammo/Resources/Textures/Ammo_00_Normal.png
Assets/Ammo/Resources/Textures/Ammo_00_Normal.png.meta
Assets/Ammo/Resources/Textures/Ammo_Pack_00_AlbedoTransparency.png
Assets/Ammo/Resources/Textures/Ammo_Pack_00_AlbedoTransparency.png.meta
Assets/Ammo/Resources/Textures/Ammo_Pack_00_MetallicSmoothness.png
Assets/Ammo/Resources/Textures/Ammo_Pack_00_MetallicSmoothness.png.meta
Assets/Ammo/Resources/Textures/Ammo_Pack_00_Normal.png
Assets/Ammo/Resources/Textures/Ammo_Pack_00_Normal.png.meta
Assets/Ammo/Scenes.meta
Assets/Ammo/Scenes/Post-processing Profile.asset
Assets/Ammo/Scenes/Post-processing Profile.asset.meta
Assets/Animations/EiriAnimations.meta
Assets/Animations/EiriAnimations/ActionAdventurePack.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/cover_to_stand.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/cover_to_stand.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/cover_to_stand2.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/cover_to_stand2.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/crouched_sneaking_left.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/crouched_sneaking_left.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/crouched_sneaking_right.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/crouched_sneaking_right.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/falling_idle.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/falling_idle.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/falling_to_roll.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/falling_to_roll.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/hard_landing.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/hard_landing.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/idle.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/idle.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/idle2.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/idle2.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/idle3.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/idle3.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/idle4.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/idle4.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/idle5.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/idle5.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/jumping_up.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/jumping_up.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/left turn.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/left turn.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/left_cover_sneak.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/left_cover_sneak.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/right turn.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/right turn.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/right_cover_sneak.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/right_cover_sneak.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/run_to_stop.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/run_to_stop.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/running.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/running.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/stand_to_cover.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/stand_to_cover.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/stand_to_cover2.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/stand_to_cover2.fbx.meta
Assets/Animations/EiriAnimations/ActionAdventurePack/walking.fbx
Assets/Animations/EiriAnimations/ActionAdventurePack/walking.fbx.meta
Assets/Animations/EiriAnimations/Eiri.fbx
Assets/Animations/EiriAnimations/Eiri.fbx.meta
Assets/Animations/EiriAnimations/Eiri@BatJumpAttack.fbx
Assets/Animations/EiriAnimations/Eiri@BatJumpAttack.fbx.meta
Assets/Animations/EiriAnimations/Eiri@BatSwingDown.fbx
Assets/Animations/EiriAnimations/Eiri@BatSwingDown.fbx.meta
Assets/Animations/EiriAnimations/Eiri@Bazooka.fbx
Assets/Animations/EiriAnimations/Eiri@Bazooka.fbx.meta
Assets/Animations/EiriAnimations/Eiri@Idle.fbx
Assets/Animations/EiriAnimations/Eiri@Idle.fbx.meta
Assets/Animations/EiriAnimations/Eiri@KnifeSlash.fbx
Assets/Animations/EiriAnimations/Eiri@KnifeSlash.fbx.meta
Assets/Animations/EiriAnimations/Eiri@KnifeSlashDown.fbx
Assets/Animations/EiriAnimations/Eiri@KnifeSlashDown.fbx.meta
Assets/Animations/EiriAnimations/Eiri@Pistol.fbx
Assets/Animations/EiriAnimations/Eiri@Pistol.fbx.meta
Assets/Animations/EiriAnimations/Eiri@Rifle.fbx
Assets/Animations/EiriAnimations/Eiri@Rifle.fbx.meta
Assets/Animations/EiriAnimations/Eiri@Running.fbx
Assets/Animations/EiriAnimations/Eiri@Running.fbx.meta
Assets/Animations/EiriAnimations/Eiri@ShootingArrow.fbx
Assets/Animations/EiriAnimations/Eiri@ShootingArrow.fbx.meta
Assets/Animations/EiriAnimations/Eiri_arma_nobake_cp.fbx
Assets/Animations/EiriAnimations/Eiri_arma_nobake_cp.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/idle.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/idle.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/jump.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/jump.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/left_strafe.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/left_strafe.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/left_strafe_walking.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/left_strafe_walking.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/left_turn.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/left_turn.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/left_turn_90.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/left_turn_90.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/right_strafe.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/right_strafe.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/right_strafe_walking.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/right_strafe_walking.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/right_turn.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/right_turn.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/right_turn_90.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/right_turn_90.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/running.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/running.fbx.meta
Assets/Animations/EiriAnimations/Locomotion_Pack/walking.fbx
Assets/Animations/EiriAnimations/Locomotion_Pack/walking.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack.meta
Assets/Animations/EiriAnimations/MeleeAxePack/crouch_idle.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/crouch_idle.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/crouch_to_standing_idle.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/crouch_to_standing_idle.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_block_idle.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_block_idle.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_block_react_large.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_block_react_large.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_disarm_over_shoulder.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_disarm_over_shoulder.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_disarm_underarm.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_disarm_underarm.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle_looking1.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle_looking1.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle_looking2.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_idle_looking2.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_jump.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_jump.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_360_high.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_360_high.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_360_low.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_360_low.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_backhand.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_backhand.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_downward.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_downward.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_horizontal.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_horizontal.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_kick_ver1.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_kick_ver1.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_kick2.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_attack_kick2.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack1.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack1.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack2.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack2.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack3.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_combo_attack3.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_run_jump_attack.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_melee_run_jump_attack.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_react_large_from_right.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_react_large_from_right.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_run_back.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_run_back.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_run_forward.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_run_forward.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_taunt_battlecry.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_taunt_battlecry.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_taunt_chest_thump.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_taunt_chest_thump.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_turn_left_90.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_turn_left_90.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_turn_right_90.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_turn_right_90.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_back.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_back.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_forward.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_forward.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_left.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_left.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_right.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/standing_walk_right.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_equip_over_shoulder.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_equip_over_shoulder.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_equip_underarm.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_equip_underarm.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle_looking1.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle_looking1.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle_looking2.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_idle_looking2.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_jump.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_jump.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_jump_running.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_jump_running.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_run_back.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_run_back.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_run_forward.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_run_forward.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_turn_left_90.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_turn_left_90.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_turn_right_90.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_turn_right_90.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_walk_back.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_walk_back.fbx.meta
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_walk_forward.fbx
Assets/Animations/EiriAnimations/MeleeAxePack/unarmed_walk_forward.fbx.meta
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2.mat
Assets/Animations/ZombieAnimationPackFree/Models/Appearance/BH-2/Material/BH_2_GLASS.mat
Assets/APC Military Vehicle-Mobile.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/APC_lowpoly.fbx
Assets/APC Military Vehicle-Mobile/APC Vehicle/APC_lowpoly.fbx.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/APC_lowpoly2_glass1_Emission.png
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/APC_lowpoly2_glass1_Emission.png.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/body_shell.mat
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/body_shell.mat.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/glass.mat
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/glass.mat.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/glass1_AlbedoTransparency 1.png
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/glass1_AlbedoTransparency 1.png.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/UV_APC_M_AlbedoTransparency 1.png
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/UV_APC_M_AlbedoTransparency 1.png.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/wheel.mat
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/wheel.mat.meta
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/wheelAFV_AlbedoTransparency.png
Assets/APC Military Vehicle-Mobile/APC Vehicle/Materials/wheelAFV_AlbedoTransparency.png.meta
Assets/APC Military Vehicle-Mobile/camara3d.meta
Assets/APC Military Vehicle-Mobile/camara3d/DemoScene.meta
Assets/APC Military Vehicle-Mobile/camara3d/DemoScene/camara3d.unity
Assets/APC Military Vehicle-Mobile/camara3d/DemoScene/camara3d.unity.meta
Assets/APC Military Vehicle-Mobile/camara3d/Scripts.meta
Assets/APC Military Vehicle-Mobile/camara3d/Scripts/Camera.meta
Assets/APC Military Vehicle-Mobile/camara3d/Scripts/Camera/CameraDefault.cs
Assets/APC Military Vehicle-Mobile/camara3d/Scripts/Camera/CameraDefault.cs.meta
Assets/APC Military Vehicle-Mobile/Documentation.pdf
Assets/APC Military Vehicle-Mobile/Documentation.pdf.meta
Assets/APC Military Vehicle-Mobile/Materials.meta
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Ambient_Occlusion.tga
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Ambient_Occlusion.tga.meta
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Base_Color.tga
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Base_Color.tga.meta
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Normal.tga
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Normal.tga.meta
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Roughness.tga
Assets/APC Military Vehicle-Mobile/Materials/Bitmap2Material_3_Roughness.tga.meta
Assets/APC Military Vehicle-Mobile/Materials/plane_AlbedoTransparency.png
Assets/APC Military Vehicle-Mobile/Materials/plane_AlbedoTransparency.png.meta
Assets/APC Military Vehicle-Mobile/Materials/plane_MetallicSmoothness.png
Assets/APC Military Vehicle-Mobile/Materials/plane_MetallicSmoothness.png.meta
Assets/APC Military Vehicle-Mobile/Materials/plane_Normal.png
Assets/APC Military Vehicle-Mobile/Materials/plane_Normal.png.meta
Assets/APC Military Vehicle-Mobile/Materials/Road.mat
Assets/APC Military Vehicle-Mobile/Materials/Road.mat.meta
Assets/APC Military Vehicle-Mobile/Materials/road2.mat
Assets/APC Military Vehicle-Mobile/Materials/road2.mat.meta
Assets/APC Military Vehicle-Mobile/Materials/Sky box.exr
Assets/APC Military Vehicle-Mobile/Materials/Sky box.exr.meta
Assets/APC Military Vehicle-Mobile/Materials/SKYBOX.mat
Assets/APC Military Vehicle-Mobile/Materials/SKYBOX.mat.meta
Assets/APC Military Vehicle-Mobile/Platform.meta
Assets/APC Military Vehicle-Mobile/Platform.unity
Assets/APC Military Vehicle-Mobile/Platform.unity.meta
Assets/APC Military Vehicle-Mobile/Platform/Materials.meta
Assets/APC Military Vehicle-Mobile/Platform/Materials/Albedo Fix low poly.png
Assets/APC Military Vehicle-Mobile/Platform/Materials/Albedo Fix low poly.png.meta
Assets/APC Military Vehicle-Mobile/Platform/Materials/Platform.mat
Assets/APC Military Vehicle-Mobile/Platform/Materials/Platform.mat.meta
Assets/APC Military Vehicle-Mobile/Platform/Platform.fbx
Assets/APC Military Vehicle-Mobile/Platform/Platform.fbx.meta
Assets/APC Military Vehicle-Mobile/PlatformSettings.lighting
Assets/APC Military Vehicle-Mobile/PlatformSettings.lighting.meta
Assets/APC Military Vehicle-Mobile/Prefab.meta
Assets/APC Military Vehicle-Mobile/Prefab/APC_lowpoly.prefab
Assets/APC Military Vehicle-Mobile/Prefab/APC_lowpoly.prefab.meta
Assets/APC Military Vehicle-Mobile/Prefab/Plane.prefab
Assets/APC Military Vehicle-Mobile/Prefab/Plane.prefab.meta
Assets/APC Military Vehicle-Mobile/Prefab/Platform.prefab
Assets/APC Military Vehicle-Mobile/Prefab/Platform.prefab.meta
Assets/APC Military Vehicle-Mobile/Read Me.txt
Assets/APC Military Vehicle-Mobile/Read Me.txt.meta
Assets/Break.fbx
Assets/Break.fbx.meta
Assets/Ches.fbx
Assets/Ches.fbx.meta
Assets/Eiri.fbx
Assets/Eiri.fbx.meta
Assets/ExplosivesPackage.meta
Assets/ExplosivesPackage/Materials.meta
Assets/ExplosivesPackage/Materials/Explosives.mat
Assets/ExplosivesPackage/Materials/Explosives.mat.meta
Assets/ExplosivesPackage/Models.meta
Assets/ExplosivesPackage/Models/ExplosivesPackage.fbx
Assets/ExplosivesPackage/Models/ExplosivesPackage.fbx.meta
Assets/ExplosivesPackage/Models/Materials.meta
Assets/ExplosivesPackage/Models/Materials/ExplosiveColours.mat
Assets/ExplosivesPackage/Models/Materials/ExplosiveColours.mat.meta
Assets/ExplosivesPackage/Prefabs.meta
Assets/ExplosivesPackage/Prefabs/Dynamite_1.prefab
Assets/ExplosivesPackage/Prefabs/Dynamite_1.prefab.meta
Assets/ExplosivesPackage/Prefabs/Dynamite_2.prefab
Assets/ExplosivesPackage/Prefabs/Dynamite_2.prefab.meta
Assets/ExplosivesPackage/Prefabs/Gas_Can.prefab
Assets/ExplosivesPackage/Prefabs/Gas_Can.prefab.meta
Assets/ExplosivesPackage/Prefabs/Oil_Drum.prefab
Assets/ExplosivesPackage/Prefabs/Oil_Drum.prefab.meta
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Large.prefab
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Large.prefab.meta
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Medium.prefab
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Medium.prefab.meta
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Small.prefab
Assets/ExplosivesPackage/Prefabs/Propane_Tank_Small.prefab.meta
Assets/ExplosivesPackage/Scenes.meta
Assets/ExplosivesPackage/Scenes/ExplosivesPackage.meta
Assets/ExplosivesPackage/Scenes/ExplosivesPackage.unity
Assets/ExplosivesPackage/Scenes/ExplosivesPackage.unity.meta
Assets/ExplosivesPackage/Scenes/ExplosivesPackage/LightmapFar-0.exr
Assets/ExplosivesPackage/Scenes/ExplosivesPackage/LightmapFar-0.exr.meta
Assets/ExplosivesPackage/Scenes/ExplosivesPackage/LightmapNear-0.exr
Assets/ExplosivesPackage/Scenes/ExplosivesPackage/LightmapNear-0.exr.meta
Assets/ExplosivesPackage/Scenes/ExplosivesPackageSettings.lighting
Assets/ExplosivesPackage/Scenes/ExplosivesPackageSettings.lighting.meta
Assets/ExplosivesPackage/Textures.meta
Assets/ExplosivesPackage/Textures/ExplosivesDiffuse.png
Assets/ExplosivesPackage/Textures/ExplosivesDiffuse.png.meta
Assets/ExplosivesPackage/Textures/ExplosivesNormals.png
Assets/ExplosivesPackage/Textures/ExplosivesNormals.png.meta
Assets/ExplosivesPackage/Textures/ExplosivesSpecular.png
Assets/ExplosivesPackage/Textures/ExplosivesSpecular.png.meta
Assets/ExplosivesPackage/Textures/ExplosivesSpecularDiffuse.tga
Assets/ExplosivesPackage/Textures/ExplosivesSpecularDiffuse.tga.meta
Assets/LootTables.meta
Assets/LootTables/BasicDropTable.asset
Assets/LootTables/BasicDropTable.asset.meta
Assets/LootTables/BatteryTable.asset
Assets/LootTables/BatteryTable.asset.meta
Assets/LootTables/BulletTable.asset
Assets/LootTables/BulletTable.asset.meta
Assets/LootTables/FirstAidTable.asset
Assets/LootTables/FirstAidTable.asset.meta
Assets/LootTables/FuelTable.asset
Assets/LootTables/FuelTable.asset.meta
Assets/March.fbx
Assets/March.fbx.meta
Assets/Materials/BlenderVrmAddonImport0305998715Image0_Image_0.png
Assets/Materials/BlenderVrmAddonImport0305998715Image0_Image_0.png.meta
Assets/Materials/BlenderVrmAddonImport0305998715Image6_Image_6.png
Assets/Materials/BlenderVrmAddonImport0305998715Image6_Image_6.png.meta
Assets/Materials/BlenderVrmAddonImport8727566701Image0_Image_0.png
Assets/Materials/BlenderVrmAddonImport8727566701Image0_Image_0.png.meta
Assets/Materials/BlenderVrmAddonImport8727566701Image6_Image_6.png
Assets/Materials/BlenderVrmAddonImport8727566701Image6_Image_6.png.meta
Assets/Materials/Break.meta
Assets/Materials/Break/BlenderVrmAddonImport5178926776Image0_Image_0.png
Assets/Materials/Break/BlenderVrmAddonImport5178926776Image0_Image_0.png.meta
Assets/Materials/Break/BlenderVrmAddonImport5178926776Image7_Image_7.png
Assets/Materials/Break/BlenderVrmAddonImport5178926776Image7_Image_7.png.meta
Assets/Materials/Ches.meta
Assets/Materials/Ches/BlenderVrmAddonImport7905845077Image0_Image_0.png
Assets/Materials/Ches/BlenderVrmAddonImport7905845077Image0_Image_0.png.meta
Assets/Materials/Ches/BlenderVrmAddonImport7905845077Image7_Image_7.png
Assets/Materials/Ches/BlenderVrmAddonImport7905845077Image7_Image_7.png.meta
Assets/Materials/edited_face1.png
Assets/Materials/edited_face1.png.meta
Assets/Materials/Eiri.meta
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0 1.png
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0 1.png.meta
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0 2.png
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0 2.png.meta
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0.png
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image0_Image_0.png.meta
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image6_Image_6 1.png
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image6_Image_6 1.png.meta
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image6_Image_6 2.png
Assets/Materials/Eiri/BlenderVrmAddonImport8727566701Image6_Image_6 2.png.meta
Assets/Materials/Eiri/Eiri_BODY.png
Assets/Materials/Eiri/Eiri_BODY.png.meta
Assets/Materials/Eiri/Eiri_FACE.png
Assets/Materials/Eiri/Eiri_FACE.png.meta
Assets/Materials/March.meta
Assets/Materials/March/BlenderVrmAddonImport8447904939Image0_Image_0.png
Assets/Materials/March/BlenderVrmAddonImport8447904939Image0_Image_0.png.meta
Assets/Materials/March/BlenderVrmAddonImport8447904939Image7_Image_7.png
Assets/Materials/March/BlenderVrmAddonImport8447904939Image7_Image_7.png.meta
Assets/Materials/Yara.meta
Assets/Materials/Yara/BlenderVrmAddonImport1563750998Image0_Image_0.png
Assets/Materials/Yara/BlenderVrmAddonImport1563750998Image0_Image_0.png.meta
Assets/Materials/Yara/BlenderVrmAddonImport1563750998Image7_Image_7.png
Assets/Materials/Yara/BlenderVrmAddonImport1563750998Image7_Image_7.png.meta
Assets/Prefabs/BatteryDrop Variant.prefab
Assets/Prefabs/BatteryDrop Variant.prefab.meta
Assets/Prefabs/BulletDrop Variant.prefab
Assets/Prefabs/BulletDrop Variant.prefab.meta
Assets/Prefabs/FirstAidBox Variant.prefab
Assets/Prefabs/FirstAidBox Variant.prefab.meta
Assets/Prefabs/FuelDrop Variant.prefab
Assets/Prefabs/FuelDrop Variant.prefab.meta
Assets/Prefabs/HealthBarPrefab.prefab
Assets/Prefabs/ZombiePrefab.prefab
Assets/Scenes/Intro.unity
Assets/Scenes/Intro.unity.meta
Assets/Scenes/project.unity
Assets/Scripts/DropCollisionController.cs
Assets/Scripts/DropCollisionController.cs.meta
Assets/Scripts/LootTable.cs
Assets/Scripts/LootTable.cs.meta
Assets/Scripts/ZombieControlScript.cs
Assets/Survival Tools.meta
Assets/Survival Tools/Materials.meta
Assets/Survival Tools/Materials/Backdrop.mat
Assets/Survival Tools/Materials/Backdrop.mat.meta
Assets/Survival Tools/Materials/Battery.mat
Assets/Survival Tools/Materials/Battery.mat.meta
Assets/Survival Tools/Materials/CannedFood.mat
Assets/Survival Tools/Materials/CannedFood.mat.meta
Assets/Survival Tools/Materials/FirstAid.mat
Assets/Survival Tools/Materials/FirstAid.mat.meta
Assets/Survival Tools/Materials/Flashlight.mat
Assets/Survival Tools/Materials/Flashlight.mat.meta
Assets/Survival Tools/Materials/FlashlightGlass.mat
Assets/Survival Tools/Materials/FlashlightGlass.mat.meta
Assets/Survival Tools/Materials/Matchbox.mat
Assets/Survival Tools/Materials/Matchbox.mat.meta
Assets/Survival Tools/Materials/Matches.mat
Assets/Survival Tools/Materials/Matches.mat.meta
Assets/Survival Tools/Materials/Pills.mat
Assets/Survival Tools/Materials/Pills.mat.meta
Assets/Survival Tools/Materials/SkyHanger.mat
Assets/Survival Tools/Materials/SkyHanger.mat.meta
Assets/Survival Tools/Materials/Tape.mat
Assets/Survival Tools/Materials/Tape.mat.meta
Assets/Survival Tools/Materials/Walkie.mat
Assets/Survival Tools/Materials/Walkie.mat.meta
Assets/Survival Tools/Materials/Walkieglass.mat
Assets/Survival Tools/Materials/Walkieglass.mat.meta
Assets/Survival Tools/Materials/WalkieNumbers.mat
Assets/Survival Tools/Materials/WalkieNumbers.mat.meta
Assets/Survival Tools/Materials/WaterBottle.mat
Assets/Survival Tools/Materials/WaterBottle.mat.meta
Assets/Survival Tools/Materials/WaterBottleCap.mat
Assets/Survival Tools/Materials/WaterBottleCap.mat.meta
Assets/Survival Tools/Meshes.meta
Assets/Survival Tools/Meshes/Backdrop.fbx
Assets/Survival Tools/Meshes/Backdrop.fbx.meta
Assets/Survival Tools/Meshes/battery.fbx
Assets/Survival Tools/Meshes/battery.fbx.meta
Assets/Survival Tools/Meshes/cannedfood.fbx
Assets/Survival Tools/Meshes/cannedfood.fbx.meta
Assets/Survival Tools/Meshes/firstaid.fbx
Assets/Survival Tools/Meshes/firstaid.fbx.meta
Assets/Survival Tools/Meshes/flashlight.fbx
Assets/Survival Tools/Meshes/flashlight.fbx.meta
Assets/Survival Tools/Meshes/matchbox.fbx
Assets/Survival Tools/Meshes/matchbox.fbx.meta
Assets/Survival Tools/Meshes/pills.fbx
Assets/Survival Tools/Meshes/pills.fbx.meta
Assets/Survival Tools/Meshes/tape.fbx
Assets/Survival Tools/Meshes/tape.fbx.meta
Assets/Survival Tools/Meshes/walkie.fbx
Assets/Survival Tools/Meshes/walkie.fbx.meta
Assets/Survival Tools/Meshes/waterbottle.fbx
Assets/Survival Tools/Meshes/waterbottle.fbx.meta
Assets/Survival Tools/Prefabs.meta
Assets/Survival Tools/Prefabs/battery.prefab
Assets/Survival Tools/Prefabs/battery.prefab.meta
Assets/Survival Tools/Prefabs/cannedfood.prefab
Assets/Survival Tools/Prefabs/cannedfood.prefab.meta
Assets/Survival Tools/Prefabs/firstaid.prefab
Assets/Survival Tools/Prefabs/firstaid.prefab.meta
Assets/Survival Tools/Prefabs/flashlight.prefab
Assets/Survival Tools/Prefabs/flashlight.prefab.meta
Assets/Survival Tools/Prefabs/matchbox.prefab
Assets/Survival Tools/Prefabs/matchbox.prefab.meta
Assets/Survival Tools/Prefabs/pills.prefab
Assets/Survival Tools/Prefabs/pills.prefab.meta
Assets/Survival Tools/Prefabs/tape.prefab
Assets/Survival Tools/Prefabs/tape.prefab.meta
Assets/Survival Tools/Prefabs/walkie.prefab
Assets/Survival Tools/Prefabs/walkie.prefab.meta
Assets/Survival Tools/Prefabs/waterbottle.prefab
Assets/Survival Tools/Prefabs/waterbottle.prefab.meta
Assets/Survival Tools/ReadMe.meta
Assets/Survival Tools/ReadMe/ReadMe.txt
Assets/Survival Tools/ReadMe/ReadMe.txt.meta
Assets/Survival Tools/Scene.meta
Assets/Survival Tools/Scene/Example Scene.unity
Assets/Survival Tools/Scene/Example Scene.unity.meta
Assets/Survival Tools/Textures.meta
Assets/Survival Tools/Textures/small_hangar_01.png
Assets/Survival Tools/Textures/small_hangar_01.png.meta
Assets/Survival Tools/Textures/survivaltools2_Battery_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Battery_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Battery_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Battery_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Battery_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Battery_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_CannedFood_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_CannedFood_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_CannedFood_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_CannedFood_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_CannedFood_Normal.png
Assets/Survival Tools/Textures/survivaltools2_CannedFood_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_Normal.png
Assets/Survival Tools/Textures/survivaltools2_FirstAidKit_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Flashlight_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Flashlight_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Flashlight_Emission.png
Assets/Survival Tools/Textures/survivaltools2_Flashlight_Emission.png.meta
Assets/Survival Tools/Textures/survivaltools2_Flashlight_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Flashlight_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Flashlight_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Flashlight_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_MatchBox_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_MatchBox_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_MatchBox_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_MatchBox_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_MatchBox_Normal.png
Assets/Survival Tools/Textures/survivaltools2_MatchBox_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Matches_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Matches_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Matches_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Matches_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Matches_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Matches_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Pills_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Pills_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Pills_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Pills_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Pills_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Pills_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Tape_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Tape_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Tape_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Tape_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Tape_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Tape_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Walkie_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Walkie_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Walkie_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Walkie_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Walkie_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Walkie_Normal.png.meta
Assets/Survival Tools/Textures/survivaltools2_Water_AlbedoTransparency.png
Assets/Survival Tools/Textures/survivaltools2_Water_AlbedoTransparency.png.meta
Assets/Survival Tools/Textures/survivaltools2_Water_MetallicSmoothness.png
Assets/Survival Tools/Textures/survivaltools2_Water_MetallicSmoothness.png.meta
Assets/Survival Tools/Textures/survivaltools2_Water_Normal.png
Assets/Survival Tools/Textures/survivaltools2_Water_Normal.png.meta
Assets/Survival Tools/Textures/walkiescreen.png
Assets/Survival Tools/Textures/walkiescreen.png.meta
Assets/UniGLTF.meta
Assets/UniGLTF/Editor.meta
Assets/UniGLTF/Editor/Animation.meta
Assets/UniGLTF/Editor/Animation/AnimationCurveData.cs
Assets/UniGLTF/Editor/Animation/AnimationCurveData.cs.meta
Assets/UniGLTF/Editor/Animation/AnimationExporter.cs
Assets/UniGLTF/Editor/Animation/AnimationExporter.cs.meta
Assets/UniGLTF/Editor/Animation/AnimationKeyframeData.cs
Assets/UniGLTF/Editor/Animation/AnimationKeyframeData.cs.meta
Assets/UniGLTF/Editor/Animation/AnimationValidator.cs
Assets/UniGLTF/Editor/Animation/AnimationValidator.cs.meta
Assets/UniGLTF/Editor/Animation/EditorAnimationExporter.cs
Assets/UniGLTF/Editor/Animation/EditorAnimationExporter.cs.meta
Assets/UniGLTF/Editor/EditorSettingsValidator.meta
Assets/UniGLTF/Editor/EditorSettingsValidator/IUnitySettingsValidator.cs
Assets/UniGLTF/Editor/EditorSettingsValidator/IUnitySettingsValidator.cs.meta
Assets/UniGLTF/Editor/EditorSettingsValidator/Messages.cs
Assets/UniGLTF/Editor/EditorSettingsValidator/Messages.cs.meta
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityColorSpaceSettingsValidator.cs
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityColorSpaceSettingsValidator.cs.meta
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityEditorSettingsValidator.cs
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityEditorSettingsValidator.cs.meta
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityEditorSettingsValidatorWindow.cs
Assets/UniGLTF/Editor/EditorSettingsValidator/UnityEditorSettingsValidatorWindow.cs.meta
Assets/UniGLTF/Editor/Generator.meta
Assets/UniGLTF/Editor/Generator/DeserializerWriter.cs
Assets/UniGLTF/Editor/Generator/DeserializerWriter.cs.meta
Assets/UniGLTF/Editor/Generator/FormatWriter.cs
Assets/UniGLTF/Editor/Generator/FormatWriter.cs.meta
Assets/UniGLTF/Editor/Generator/Generator.cs
Assets/UniGLTF/Editor/Generator/Generator.cs.meta
Assets/UniGLTF/Editor/Generator/SerializerWriter.cs
Assets/UniGLTF/Editor/Generator/SerializerWriter.cs.meta
Assets/UniGLTF/Editor/JsonSchema.meta
Assets/UniGLTF/Editor/JsonSchema/IndexTargets.cs
Assets/UniGLTF/Editor/JsonSchema/IndexTargets.cs.meta
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaParser.cs
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaParser.cs.meta
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaSource.cs
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaSource.cs.meta
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaType.cs
Assets/UniGLTF/Editor/JsonSchema/JsonSchemaType.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/ArrayJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/ArrayJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/DictionaryJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/DictionaryJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/EnumJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/EnumJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/ExtensionJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/ExtensionJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/JsonSchemaBase.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/JsonSchemaBase.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/JsonSchemaBaseExtensions.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/JsonSchemaBaseExtensions.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/ObjectJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/ObjectJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/PrimitiveJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/PrimitiveJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/StringJsonSchema.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/StringJsonSchema.cs.meta
Assets/UniGLTF/Editor/JsonSchema/Schemas/TraverseContext.cs
Assets/UniGLTF/Editor/JsonSchema/Schemas/TraverseContext.cs.meta
Assets/UniGLTF/Editor/JsonSchema/StringExtensions.cs
Assets/UniGLTF/Editor/JsonSchema/StringExtensions.cs.meta
Assets/UniGLTF/Editor/MeshUtility.meta
Assets/UniGLTF/Editor/MeshUtility/AssetsPath.cs
Assets/UniGLTF/Editor/MeshUtility/AssetsPath.cs.meta
Assets/UniGLTF/Editor/MeshUtility/GameObjectType.cs
Assets/UniGLTF/Editor/MeshUtility/GameObjectType.cs.meta
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialog.cs
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialog.cs.meta
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialogEditor.cs
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialogEditor.cs.meta
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialogTabs.cs
Assets/UniGLTF/Editor/MeshUtility/MeshProcessDialogTabs.cs.meta
Assets/UniGLTF/Editor/MeshUtility/MeshProcessingMessages.cs
Assets/UniGLTF/Editor/MeshUtility/MeshProcessingMessages.cs.meta
Assets/UniGLTF/Editor/MeshUtility/TabBoneMeshRemover.cs
Assets/UniGLTF/Editor/MeshUtility/TabBoneMeshRemover.cs.meta
Assets/UniGLTF/Editor/MeshUtility/TabMeshIntegrator.cs
Assets/UniGLTF/Editor/MeshUtility/TabMeshIntegrator.cs.meta
Assets/UniGLTF/Editor/MeshUtility/TabMeshSeparator.cs
Assets/UniGLTF/Editor/MeshUtility/TabMeshSeparator.cs.meta
Assets/UniGLTF/Editor/SerializedPropertyEditor.cs
Assets/UniGLTF/Editor/SerializedPropertyEditor.cs.meta
Assets/UniGLTF/Editor/TopMenu.cs
Assets/UniGLTF/Editor/TopMenu.cs.meta
Assets/UniGLTF/Editor/TopMenuImplementation.cs
Assets/UniGLTF/Editor/TopMenuImplementation.cs.meta
Assets/UniGLTF/Editor/UniGLTF.Editor.asmdef
Assets/UniGLTF/Editor/UniGLTF.Editor.asmdef.meta
Assets/UniGLTF/Editor/UniGLTF.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/EditorProgress.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/EditorProgress.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/ExportDialogBase.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/ExportDialogBase.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/ExportDialogState.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/ExportDialogState.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/GltfExportWindow.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/GltfExportWindow.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/InternalTPose.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/InternalTPose.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/M17N.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/M17N.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MaterialValidator.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MaterialValidator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MeshExportValidator.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MeshExportValidator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MeshExportValidatorEditor.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/MeshExportValidatorEditor.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/SaveFileDialog.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/SaveFileDialog.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/TabBar.cs
Assets/UniGLTF/Editor/UniGLTF/ExportDialog/TabBar.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneInfo.cs
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneInfo.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneInfoDrawer.cs
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneInfoDrawer.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneSelector.cs
Assets/UniGLTF/Editor/UniGLTF/Gizmo/BoneSelector.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/Bone.fbx
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/Bone.fbx.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/Bone.mat
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/Bone.mat.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/BoneGizmo.prefab
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/BoneGizmo.prefab.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/HoverBone.mat
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/HoverBone.mat.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/HoverBoneGizmo.prefab
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/HoverBoneGizmo.prefab.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/OverlayGizmo.shader
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/OverlayGizmo.shader.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/SelectedBone.mat
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/SelectedBone.mat.meta
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/SelectedBoneGizmo.prefab
Assets/UniGLTF/Editor/UniGLTF/Gizmo/Models/SelectedBoneGizmo.prefab.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/EnabledScope.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/EnabledScope.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GlbScriptedImporter.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GlbScriptedImporter.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GlbScriptedImporterEditor.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GlbScriptedImporterEditor.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporter.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporter.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporterBase.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporterBase.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporterEditor.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/GltfScriptedImporterEditor.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorAnimation.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorAnimation.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorBase.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorBase.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorMaterial.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapEditorMaterial.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapScriptedImporterEditorBase.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/RemapScriptedImporterEditorBase.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ScriptedImporterAxes.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ScriptedImporterAxes.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/TextureExtractor.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/TextureExtractor.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ZipArchivedGltfScriptedImporter.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ZipArchivedGltfScriptedImporter.cs.meta
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ZipArchivedGltfScriptedImporterEditor.cs
Assets/UniGLTF/Editor/UniGLTF/ScriptedImporter/ZipArchivedGltfScriptedImporterEditor.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/ArraySerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/ArraySerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/CollectionSerializationBase.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/CollectionSerializationBase.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/DeserializerGenerator.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/DeserializerGenerator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/EnumSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/EnumSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/ExtensionSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/ExtensionSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/FieldSerializationInfo.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/FieldSerializationInfo.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/IValueSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/IValueSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/ListSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/ListSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/ObjectSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/ObjectSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/PrimitiveSerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/PrimitiveSerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/SerializerGenerator.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/SerializerGenerator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Serialization/StringKeyDictionarySerialization.cs
Assets/UniGLTF/Editor/UniGLTF/Serialization/StringKeyDictionarySerialization.cs.meta
Assets/UniGLTF/Editor/UniGLTF/UniGLTFPreference.cs
Assets/UniGLTF/Editor/UniGLTF/UniGLTFPreference.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Validation.meta
Assets/UniGLTF/Editor/UniGLTF/Validation/HierarchyValidator.cs
Assets/UniGLTF/Editor/UniGLTF/Validation/HierarchyValidator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Validation/HumanoidValidator.cs
Assets/UniGLTF/Editor/UniGLTF/Validation/HumanoidValidator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Validation/NameValidator.cs
Assets/UniGLTF/Editor/UniGLTF/Validation/NameValidator.cs.meta
Assets/UniGLTF/Editor/UniGLTF/Validation/ValidationExtensions.cs
Assets/UniGLTF/Editor/UniGLTF/Validation/ValidationExtensions.cs.meta
Assets/UniGLTF/Editor/UniHumanoid.meta
Assets/UniGLTF/Editor/UniHumanoid/BoneMappingEditor.cs
Assets/UniGLTF/Editor/UniHumanoid/BoneMappingEditor.cs.meta
Assets/UniGLTF/Editor/UniHumanoid/bvhAssetPostprocessor.cs
Assets/UniGLTF/Editor/UniHumanoid/bvhAssetPostprocessor.cs.meta
Assets/UniGLTF/Editor/UniHumanoid/HumanoidEditor.cs
Assets/UniGLTF/Editor/UniHumanoid/HumanoidEditor.cs.meta
Assets/UniGLTF/Editor/UniHumanoid/HumanPoseTransferEditor.cs
Assets/UniGLTF/Editor/UniHumanoid/HumanPoseTransferEditor.cs.meta
Assets/UniGLTF/Editor/UniHumanoid/MuscleInspectorEditor.cs
Assets/UniGLTF/Editor/UniHumanoid/MuscleInspectorEditor.cs.meta
Assets/UniGLTF/Editor/UniHumanoid/UniHumanoid.Editor.asmdef
Assets/UniGLTF/Editor/UniHumanoid/UniHumanoid.Editor.asmdef.meta
Assets/UniGLTF/LICENSE.md
Assets/UniGLTF/LICENSE.md.meta
Assets/UniGLTF/package.json
Assets/UniGLTF/package.json.meta
Assets/UniGLTF/README.md
Assets/UniGLTF/README.md.meta
Assets/UniGLTF/Runtime.meta
Assets/UniGLTF/Runtime/Extensions.meta
Assets/UniGLTF/Runtime/Extensions/ArrayExtensions.cs
Assets/UniGLTF/Runtime/Extensions/ArrayExtensions.cs.meta
Assets/UniGLTF/Runtime/Extensions/ColorConversionExtensions.cs
Assets/UniGLTF/Runtime/Extensions/ColorConversionExtensions.cs.meta
Assets/UniGLTF/Runtime/Extensions/glTFExtensions.cs
Assets/UniGLTF/Runtime/Extensions/glTFExtensions.cs.meta
Assets/UniGLTF/Runtime/Extensions/NumericsExtensions.cs
Assets/UniGLTF/Runtime/Extensions/NumericsExtensions.cs.meta
Assets/UniGLTF/Runtime/Extensions/StringExtensions.cs
Assets/UniGLTF/Runtime/Extensions/StringExtensions.cs.meta
Assets/UniGLTF/Runtime/Extensions/UnityExtensions.cs
Assets/UniGLTF/Runtime/Extensions/UnityExtensions.cs.meta
Assets/UniGLTF/Runtime/MeshUtility.meta
Assets/UniGLTF/Runtime/MeshUtility/BindposeGizmo.cs
Assets/UniGLTF/Runtime/MeshUtility/BindposeGizmo.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/BoneMeshEraser.cs
Assets/UniGLTF/Runtime/MeshUtility/BoneMeshEraser.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/BoneNormalizer.cs
Assets/UniGLTF/Runtime/MeshUtility/BoneNormalizer.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshEnumerateOption.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshEnumerateOption.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshExclude.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshExclude.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshExtensions.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshExtensions.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegrationResult.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegrationResult.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegrator.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegrator.cs.meta
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegratorUtility.cs
Assets/UniGLTF/Runtime/MeshUtility/MeshIntegratorUtility.cs.meta
Assets/UniGLTF/Runtime/Resources.meta
Assets/UniGLTF/Runtime/Resources/test_motion.txt
Assets/UniGLTF/Runtime/Resources/test_motion.txt.meta
Assets/UniGLTF/Runtime/Resources/T-Pose.pose.asset
Assets/UniGLTF/Runtime/Resources/T-Pose.pose.asset.meta
Assets/UniGLTF/Runtime/Scenes.meta
Assets/UniGLTF/Runtime/Scenes/LookDev.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/ballroom_1k.unity
Assets/UniGLTF/Runtime/Scenes/LookDev/ballroom_1k.unity.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/ballroom_1k.exr
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/ballroom_1k.exr.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/ballroom_1k.mat
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/ballroom_1k.mat.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/lilienstein_1k.exr
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/lilienstein_1k.exr.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/lilienstein_1k.mat
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/lilienstein_1k.mat.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/moonless_golf_1k.exr
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/moonless_golf_1k.exr.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/moonless_golf_1k.mat
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/moonless_golf_1k.mat.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/spruit_sunrise_1k.exr
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/spruit_sunrise_1k.exr.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/spruit_sunrise_1k.mat
Assets/UniGLTF/Runtime/Scenes/LookDev/cubemap/spruit_sunrise_1k.mat.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/floor.mat
Assets/UniGLTF/Runtime/Scenes/LookDev/floor.mat.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/floor.prefab
Assets/UniGLTF/Runtime/Scenes/LookDev/floor.prefab.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/lilienstein_1k.unity
Assets/UniGLTF/Runtime/Scenes/LookDev/lilienstein_1k.unity.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/moonless_golf_1k.unity
Assets/UniGLTF/Runtime/Scenes/LookDev/moonless_golf_1k.unity.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/RenderingServicePostProcessingProfile.asset
Assets/UniGLTF/Runtime/Scenes/LookDev/RenderingServicePostProcessingProfile.asset.meta
Assets/UniGLTF/Runtime/Scenes/LookDev/spruit_sunrise_1k.unity
Assets/UniGLTF/Runtime/Scenes/LookDev/spruit_sunrise_1k.unity.meta
Assets/UniGLTF/Runtime/UniGLTF.asmdef
Assets/UniGLTF/Runtime/UniGLTF.asmdef.meta
Assets/UniGLTF/Runtime/UniGLTF.meta
Assets/UniGLTF/Runtime/UniGLTF/Format.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Deserializer.g.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Deserializer.g.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Format.g.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Format.g.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Serializer.g.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/EmissiveMultiplier/Serializer.g.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/gltf_mesh_extras_targetNames.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/gltf_mesh_extras_targetNames.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/gltfExtension.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/gltfExtension.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_materials_emissive_strength.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_materials_emissive_strength.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_materials_unlit.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_materials_unlit.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_texture_basisu.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_texture_basisu.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_texture_transform.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/ExtensionsAndExtras/KHR_texture_transform.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glbTypes.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glbTypes.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glEnum.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glEnum.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTF.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTF.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFAnimation.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFAnimation.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFAssets.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFAssets.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFBuffer.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFBuffer.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFCamera.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFCamera.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/GltfDeserializer.g.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/GltfDeserializer.g.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFMaterial.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFMaterial.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFMesh.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFMesh.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFNode.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFNode.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/GltfSerializer.g.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/GltfSerializer.g.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFSkin.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFSkin.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFTexture.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/glTFTexture.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/IStorage.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/IStorage.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/JsonSchemaAttribute.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/JsonSchemaAttribute.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Format/UnityEngineCompatibility.cs
Assets/UniGLTF/Runtime/UniGLTF/Format/UnityEngineCompatibility.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/AnimationIO.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/AnimationIO/AnimationImporterUtil.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/AnimationIO/AnimationImporterUtil.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/AnimationIO/IAnimationExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/AnimationIO/IAnimationExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ArrayByteBuffer.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ArrayByteBuffer.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ArrayPin.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ArrayPin.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Axes.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Axes.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/BufferAccessor.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/BufferAccessor.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Byte4.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Byte4.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/BytesReader.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/BytesReader.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ExportingGltfData.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ExportingGltfData.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/FileSystemStorage.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/FileSystemStorage.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/glbImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/glbImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfData.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfData.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/gltfExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/gltfExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfExportSettings.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfExportSettings.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfJsonUtil.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfJsonUtil.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfUtility.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/GltfUtility.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContext.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContext.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContextExtensions.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContextExtensions.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContextSpeedLog.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ImporterContextSpeedLog.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfMaterialDescriptorGenerator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfMaterialDescriptorGenerator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfPbrMaterialImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfPbrMaterialImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfUnlitMaterialImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/GltfUnlitMaterialImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/IMaterialDescriptorGenerator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/IMaterialDescriptorGenerator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/IMaterialExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/IMaterialExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/MaterialExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/MaterialExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/MaterialImporterParamExtensions.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/MaterialImporterParamExtensions.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/RenderPipelineTypes.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/RenderPipelineTypes.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/TextureTransform.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/TextureTransform.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/URP.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/URP/GltfPbrURPMaterialImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/URP/GltfPbrURPMaterialImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/URP/GltfURPMaterialDescriptorGenerator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MaterialIO/URP/GltfURPMaterialDescriptorGenerator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/BlendShapeExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/BlendShapeExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/BlendShapeFilter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/BlendShapeFilter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/JointsAccessor.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/JointsAccessor.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshContext.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshContext.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExporter_DividedVertexBuffer.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExporter_DividedVertexBuffer.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExporter_SharedVertexBuffer.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExporter_SharedVertexBuffer.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExportInfo.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExportInfo.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExportUtil.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshExportUtil.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshVertex.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshVertex.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshWithMaterials.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/MeshWithMaterials.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/PositionMinMax.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/PositionMinMax.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/PrimitiveExtensions.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/PrimitiveExtensions.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/SkinnedMeshVertex.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/SkinnedMeshVertex.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/TriangleUtil.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/TriangleUtil.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/VertexColorState.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/VertexColorState.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/WeightsAccessor.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MeshIO/WeightsAccessor.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MigrationFlags.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MigrationFlags.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/MonoBehaviourComparator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/MonoBehaviourComparator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/NativeArrayManager.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/NativeArrayManager.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/NodeImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/NodeImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/AutoGltfFileParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/AutoGltfFileParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbBinaryParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbBinaryParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbFileParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbFileParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbLowLevelParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GlbLowLevelParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GltfFileWithResourceFilesParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/GltfFileWithResourceFilesParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/ZipArchivedGltfFileParser.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/Parser/ZipArchivedGltfFileParser.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ProgressInfo.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ProgressInfo.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/SafeMarshalCopy.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/SafeMarshalCopy.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/SByte4.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/SByte4.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/SkinJoint.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/SkinJoint.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfPbrTextureImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfPbrTextureImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureDescriptorGenerator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureDescriptorGenerator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureExporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureExporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureImporter.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/GltfTextureImporter.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/ITextureDescriptorGenerator.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/ITextureDescriptorGenerator.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/TextureSamplerUtil.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/TextureIO/TextureSamplerUtil.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/UnityPath.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/UnityPath.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/UriByteBuffer.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/UriByteBuffer.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/UShort2.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/UShort2.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/UShort4.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/UShort4.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/IO/ZipArchiveStorage.cs
Assets/UniGLTF/Runtime/UniGLTF/IO/ZipArchiveStorage.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/RuntimeGltfInstance.cs
Assets/UniGLTF/Runtime/UniGLTF/RuntimeGltfInstance.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFException.cs
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFException.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFVersion.cs
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFVersion.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFVersion_partial.cs
Assets/UniGLTF/Runtime/UniGLTF/UniGLTFVersion_partial.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Util.meta
Assets/UniGLTF/Runtime/UniGLTF/Util/CacheEnum.cs
Assets/UniGLTF/Runtime/UniGLTF/Util/CacheEnum.cs.meta
Assets/UniGLTF/Runtime/UniGLTF/Validation.meta
Assets/UniGLTF/Runtime/UniGLTF/Validation/Validation.cs
Assets/UniGLTF/Runtime/UniGLTF/Validation/Validation.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid.meta
Assets/UniGLTF/Runtime/UniHumanoid/AnimationClipUtility.cs
Assets/UniGLTF/Runtime/UniHumanoid/AnimationClipUtility.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/AvatarDescription.cs
Assets/UniGLTF/Runtime/UniHumanoid/AvatarDescription.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/BoneGizmoDrawer.cs
Assets/UniGLTF/Runtime/UniHumanoid/BoneGizmoDrawer.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/BoneMapping.cs
Assets/UniGLTF/Runtime/UniHumanoid/BoneMapping.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/BvhBone.cs
Assets/UniGLTF/Runtime/UniHumanoid/BvhBone.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/Extensions.meta
Assets/UniGLTF/Runtime/UniHumanoid/Extensions/EnumExtensions.cs
Assets/UniGLTF/Runtime/UniHumanoid/Extensions/EnumExtensions.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/Format.meta
Assets/UniGLTF/Runtime/UniHumanoid/Format/Bvh.cs
Assets/UniGLTF/Runtime/UniHumanoid/Format/Bvh.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/Humanoid.cs
Assets/UniGLTF/Runtime/UniHumanoid/Humanoid.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/HumanoidLoader.cs
Assets/UniGLTF/Runtime/UniHumanoid/HumanoidLoader.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/HumanPoseClip.cs
Assets/UniGLTF/Runtime/UniHumanoid/HumanPoseClip.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/HumanPoseTransfer.cs
Assets/UniGLTF/Runtime/UniHumanoid/HumanPoseTransfer.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IBone.cs
Assets/UniGLTF/Runtime/UniHumanoid/IBone.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhAnimationClip.cs
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhAnimationClip.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhImporter.cs
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhImporter.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhImporterContext.cs
Assets/UniGLTF/Runtime/UniHumanoid/IO/BvhImporterContext.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/Extensions.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/Extensions/BvhExtensions.cs
Assets/UniGLTF/Runtime/UniHumanoid/IO/Extensions/BvhExtensions.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/IO/Extensions/UnityExtensions.cs
Assets/UniGLTF/Runtime/UniHumanoid/IO/Extensions/UnityExtensions.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/MuscleDebug.cs
Assets/UniGLTF/Runtime/UniHumanoid/MuscleDebug.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/MuscleInspector.cs
Assets/UniGLTF/Runtime/UniHumanoid/MuscleInspector.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier.meta
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/HandPose.cs
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/HandPose.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/HandRig.cs
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/HandRig.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/IPoseModifier.cs
Assets/UniGLTF/Runtime/UniHumanoid/PoseModifier/IPoseModifier.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/Skeleton.cs
Assets/UniGLTF/Runtime/UniHumanoid/Skeleton.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/SkeletonEstimator.cs
Assets/UniGLTF/Runtime/UniHumanoid/SkeletonEstimator.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/SkeletonMeshUtility.cs
Assets/UniGLTF/Runtime/UniHumanoid/SkeletonMeshUtility.cs.meta
Assets/UniGLTF/Runtime/UniHumanoid/UniHumanoid.asmdef
Assets/UniGLTF/Runtime/UniHumanoid/UniHumanoid.asmdef.meta
Assets/UniGLTF/Runtime/UniJSON.meta
Assets/UniGLTF/Runtime/UniJSON/ByteBuffer.cs
Assets/UniGLTF/Runtime/UniJSON/ByteBuffer.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ConcreteCast.cs
Assets/UniGLTF/Runtime/UniJSON/ConcreteCast.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ConcreteCast.g.cs
Assets/UniGLTF/Runtime/UniJSON/ConcreteCast.g.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Exceptions.cs
Assets/UniGLTF/Runtime/UniJSON/Exceptions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/ArraySegmentExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/ArraySegmentExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/ByteExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/ByteExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/DateTimeOffsetExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/DateTimeOffsetExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/EnumExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/EnumExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/ParserExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/ParserExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Extensions/TypeExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Extensions/TypeExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/FormatterExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/FormatterExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IFileSystemAccessor.cs
Assets/UniGLTF/Runtime/UniJSON/IFileSystemAccessor.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IFormatter.cs
Assets/UniGLTF/Runtime/UniJSON/IFormatter.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IStore.meta
Assets/UniGLTF/Runtime/UniJSON/IStore/BytesStore.cs
Assets/UniGLTF/Runtime/UniJSON/IStore/BytesStore.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IStore/ByteUnion.cs
Assets/UniGLTF/Runtime/UniJSON/IStore/ByteUnion.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IStore/IStore.cs
Assets/UniGLTF/Runtime/UniJSON/IStore/IStore.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IStore/StreamStore.cs
Assets/UniGLTF/Runtime/UniJSON/IStore/StreamStore.cs.meta
Assets/UniGLTF/Runtime/UniJSON/IStore/StringBuilderStore.cs
Assets/UniGLTF/Runtime/UniJSON/IStore/StringBuilderStore.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonDiff.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonDiff.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonFormatter.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonFormatter.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonParser.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonParser.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonPointer.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonPointer.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonString.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonString.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Json/JsonValue.cs
Assets/UniGLTF/Runtime/UniJSON/Json/JsonValue.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNode.cs
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNode.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeArrayExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeArrayExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeJsonPointerExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeJsonPointerExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeObjectExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/ListTreeNode/ListTreeNodeObjectExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/IUtf8String.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/IUtf8String.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8Iterator.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8Iterator.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8String.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8String.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringBuilder.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringBuilder.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringSplitterExtensions.cs
Assets/UniGLTF/Runtime/UniJSON/Utf8String/Utf8StringSplitterExtensions.cs.meta
Assets/UniGLTF/Runtime/UniJSON/ValueNodeType.cs
Assets/UniGLTF/Runtime/UniJSON/ValueNodeType.cs.meta
Assets/UniGLTF/Samples.meta
Assets/UniGLTF/Samples/ScreenSpace.meta
Assets/UniGLTF/Samples/ScreenSpace/a.mat
Assets/UniGLTF/Samples/ScreenSpace/a.mat.meta
Assets/UniGLTF/Samples/ScreenSpace/a.png
Assets/UniGLTF/Samples/ScreenSpace/a.png.meta
Assets/UniGLTF/Samples/ScreenSpace/b.mat
Assets/UniGLTF/Samples/ScreenSpace/b.mat.meta
Assets/UniGLTF/Samples/ScreenSpace/b.png
Assets/UniGLTF/Samples/ScreenSpace/b.png.meta
Assets/UniGLTF/Samples/ScreenSpace/ScaleOffset.cs
Assets/UniGLTF/Samples/ScreenSpace/ScaleOffset.cs.meta
Assets/UniGLTF/Samples/ScreenSpace/ScreenSpace.unity
Assets/UniGLTF/Samples/ScreenSpace/ScreenSpace.unity.meta
Assets/UniGLTF/Samples/ScreenSpace/UniGLTF.Samples.ScreenSpace.asmdef
Assets/UniGLTF/Samples/ScreenSpace/UniGLTF.Samples.ScreenSpace.asmdef.meta
Assets/UniGLTF/Samples/ScreenSpace/uv_color.shader
Assets/UniGLTF/Samples/ScreenSpace/uv_color.shader.meta
Assets/UniGLTF/Samples/UniHumanoid.meta
Assets/UniGLTF/Samples/UniHumanoid/HumanBuilderTest.cs
Assets/UniGLTF/Samples/UniHumanoid/HumanBuilderTest.cs.meta
Assets/UniGLTF/Samples/UniHumanoid/PoseTransfer.unity
Assets/UniGLTF/Samples/UniHumanoid/PoseTransfer.unity.meta
Assets/UniGLTF/Samples/UniHumanoid/RuntimeBvhLoader.cs
Assets/UniGLTF/Samples/UniHumanoid/RuntimeBvhLoader.cs.meta
Assets/UniGLTF/Samples/UniHumanoid/RuntimeBvhLoader.unity
Assets/UniGLTF/Samples/UniHumanoid/RuntimeBvhLoader.unity.meta
Assets/UniGLTF/Samples/UniHumanoid/target.mat
Assets/UniGLTF/Samples/UniHumanoid/target.mat.meta
Assets/UniGLTF/Tests.meta
Assets/UniGLTF/Tests/UniGLTF.meta
Assets/UniGLTF/Tests/UniGLTF.Tests.asmdef
Assets/UniGLTF/Tests/UniGLTF.Tests.asmdef.meta
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_linear.png
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_linear.png.meta
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_normal_map.png
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_normal_map.png.meta
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_srgb.png
Assets/UniGLTF/Tests/UniGLTF/4x4_gray_import_as_srgb.png.meta
Assets/UniGLTF/Tests/UniGLTF/AssetTests.cs
Assets/UniGLTF/Tests/UniGLTF/AssetTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/CacheEnumTest.cs
Assets/UniGLTF/Tests/UniGLTF/CacheEnumTest.cs.meta
Assets/UniGLTF/Tests/UniGLTF/EditorTextureSerializerTests.cs
Assets/UniGLTF/Tests/UniGLTF/EditorTextureSerializerTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/GlbParserTests.cs
Assets/UniGLTF/Tests/UniGLTF/GlbParserTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/GltfJsonUtilTests.cs
Assets/UniGLTF/Tests/UniGLTF/GltfJsonUtilTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/GltfLoadTests.cs
Assets/UniGLTF/Tests/UniGLTF/GltfLoadTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/JsonDeserializeTests.cs
Assets/UniGLTF/Tests/UniGLTF/JsonDeserializeTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/M17NTest.cs
Assets/UniGLTF/Tests/UniGLTF/M17NTest.cs.meta
Assets/UniGLTF/Tests/UniGLTF/MaterialTests.cs
Assets/UniGLTF/Tests/UniGLTF/MaterialTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/MatrixTests.cs
Assets/UniGLTF/Tests/UniGLTF/MatrixTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/MeshExportValidatorTests.cs
Assets/UniGLTF/Tests/UniGLTF/MeshExportValidatorTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/MeshTests.cs
Assets/UniGLTF/Tests/UniGLTF/MeshTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/NativeArrayTests.cs
Assets/UniGLTF/Tests/UniGLTF/NativeArrayTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/New Material.mat
Assets/UniGLTF/Tests/UniGLTF/New Material.mat.meta
Assets/UniGLTF/Tests/UniGLTF/NumericTests.cs
Assets/UniGLTF/Tests/UniGLTF/NumericTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/TextureEnumerateTests.cs
Assets/UniGLTF/Tests/UniGLTF/TextureEnumerateTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/TextureTests.cs
Assets/UniGLTF/Tests/UniGLTF/TextureTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/UniGLTFTests.cs
Assets/UniGLTF/Tests/UniGLTF/UniGLTFTests.cs.meta
Assets/UniGLTF/Tests/UniGLTF/UnityEngineAndNumerics.cs
Assets/UniGLTF/Tests/UniGLTF/UnityEngineAndNumerics.cs.meta
Assets/UniGLTF/Tests/UniHumanoid.meta
Assets/UniGLTF/Tests/UniHumanoid/BvhLoaderTests.cs
Assets/UniGLTF/Tests/UniHumanoid/BvhLoaderTests.cs.meta
Assets/UniGLTF/Tests/UniHumanoid/UniHumanoid.Editor.Tests.asmdef
Assets/UniGLTF/Tests/UniHumanoid/UniHumanoid.Editor.Tests.asmdef.meta
Assets/UniGLTF/Tests/UniJSON.meta
Assets/UniGLTF/Tests/UniJSON/GenericCallUtilityTests.cs
Assets/UniGLTF/Tests/UniJSON/GenericCallUtilityTests.cs.meta
Assets/UniGLTF/Tests/UniJSON/IWriteStreamTest.cs
Assets/UniGLTF/Tests/UniJSON/IWriteStreamTest.cs.meta
Assets/UniGLTF/Tests/UniJSON/Json.meta
Assets/UniGLTF/Tests/UniJSON/Json/JsonDiffTests.cs
Assets/UniGLTF/Tests/UniJSON/Json/JsonDiffTests.cs.meta
Assets/UniGLTF/Tests/UniJSON/Json/JsonFormatterTest.cs
Assets/UniGLTF/Tests/UniJSON/Json/JsonFormatterTest.cs.meta
Assets/UniGLTF/Tests/UniJSON/Json/JsonParserTest.cs
Assets/UniGLTF/Tests/UniJSON/Json/JsonParserTest.cs.meta
Assets/UniGLTF/Tests/UniJSON/Json/JsonSerializerTests.cs
Assets/UniGLTF/Tests/UniJSON/Json/JsonSerializerTests.cs.meta
Assets/UniGLTF/Tests/UniJSON/Json/JsonValueTests.cs
Assets/UniGLTF/Tests/UniJSON/Json/JsonValueTests.cs.meta
Assets/UniGLTF/Tests/UniJSON/TreeTest.cs
Assets/UniGLTF/Tests/UniJSON/TreeTest.cs.meta
Assets/UniGLTF/Tests/UniJSON/Utf8StringTest.cs
Assets/UniGLTF/Tests/UniJSON/Utf8StringTest.cs.meta
Assets/VRM.meta
Assets/VRM/CHANGELOG.md
Assets/VRM/CHANGELOG.md.meta
Assets/VRM/Documentation.meta
Assets/VRM/Documentation/VRM.md
Assets/VRM/Documentation/VRM.md.meta
Assets/VRM/Editor.meta
Assets/VRM/Editor/AOT.meta
Assets/VRM/Editor/AOT/VRMAOTCodeGenerator.cs
Assets/VRM/Editor/AOT/VRMAOTCodeGenerator.cs.meta
Assets/VRM/Editor/AOT/VRMDeserializerGenerator.cs
Assets/VRM/Editor/AOT/VRMDeserializerGenerator.cs.meta
Assets/VRM/Editor/AOT/VRMSerializerGenerator.cs
Assets/VRM/Editor/AOT/VRMSerializerGenerator.cs.meta
Assets/VRM/Editor/BlendShape.meta
Assets/VRM/Editor/BlendShape/BlendShapeAvatarEditor.cs
Assets/VRM/Editor/BlendShape/BlendShapeAvatarEditor.cs.meta
Assets/VRM/Editor/BlendShape/BlendShapeClipDrawer.cs
Assets/VRM/Editor/BlendShape/BlendShapeClipDrawer.cs.meta
Assets/VRM/Editor/BlendShape/BlendShapeClipEditor.cs
Assets/VRM/Editor/BlendShape/BlendShapeClipEditor.cs.meta
Assets/VRM/Editor/BlendShape/BlendShapeClipEditorHelper.cs
Assets/VRM/Editor/BlendShape/BlendShapeClipEditorHelper.cs.meta
Assets/VRM/Editor/BlendShape/BlendShapeClipSelector.cs
Assets/VRM/Editor/BlendShape/BlendShapeClipSelector.cs.meta
Assets/VRM/Editor/BlendShape/PreviewEditor.cs
Assets/VRM/Editor/BlendShape/PreviewEditor.cs.meta
Assets/VRM/Editor/BlendShape/PreviewFaceRenderer.cs
Assets/VRM/Editor/BlendShape/PreviewFaceRenderer.cs.meta
Assets/VRM/Editor/BlendShape/SerializedBlendShapeClipEditor.cs
Assets/VRM/Editor/BlendShape/SerializedBlendShapeClipEditor.cs.meta
Assets/VRM/Editor/BlendShape/VRMBlendShapeProxyEditor.cs
Assets/VRM/Editor/BlendShape/VRMBlendShapeProxyEditor.cs.meta
Assets/VRM/Editor/BlendShape/VRMBlendShapeProxyValidator.cs
Assets/VRM/Editor/BlendShape/VRMBlendShapeProxyValidator.cs.meta
Assets/VRM/Editor/BuildClass.cs
Assets/VRM/Editor/BuildClass.cs.meta
Assets/VRM/Editor/FirstPerson.meta
Assets/VRM/Editor/FirstPerson/RendererFirstPersonFlagsDrawer.cs
Assets/VRM/Editor/FirstPerson/RendererFirstPersonFlagsDrawer.cs.meta
Assets/VRM/Editor/FirstPerson/VRMFirstPersonEditor.cs
Assets/VRM/Editor/FirstPerson/VRMFirstPersonEditor.cs.meta
Assets/VRM/Editor/FirstPerson/VRMFirstPersonValidator.cs
Assets/VRM/Editor/FirstPerson/VRMFirstPersonValidator.cs.meta
Assets/VRM/Editor/Format.meta
Assets/VRM/Editor/Format/RecordDisposer.cs
Assets/VRM/Editor/Format/RecordDisposer.cs.meta
Assets/VRM/Editor/Format/vrmAssetPostprocessor.cs
Assets/VRM/Editor/Format/vrmAssetPostprocessor.cs.meta
Assets/VRM/Editor/Format/VRMAssetWriter.cs
Assets/VRM/Editor/Format/VRMAssetWriter.cs.meta
Assets/VRM/Editor/Format/VRMBlendShapeExportFilter.cs
Assets/VRM/Editor/Format/VRMBlendShapeExportFilter.cs.meta
Assets/VRM/Editor/Format/VRMEditorExporter.cs
Assets/VRM/Editor/Format/VRMEditorExporter.cs.meta
Assets/VRM/Editor/Format/VRMEditorImporterContext.cs
Assets/VRM/Editor/Format/VRMEditorImporterContext.cs.meta
Assets/VRM/Editor/Format/VRMExporterVaildator.cs
Assets/VRM/Editor/Format/VRMExporterVaildator.cs.meta
Assets/VRM/Editor/Format/VRMExporterWizard.cs
Assets/VRM/Editor/Format/VRMExporterWizard.cs.meta
Assets/VRM/Editor/Format/VRMExportOptions.cs
Assets/VRM/Editor/Format/VRMExportOptions.cs.meta
Assets/VRM/Editor/Format/VRMExportSettings.cs
Assets/VRM/Editor/Format/VRMExportSettings.cs.meta
Assets/VRM/Editor/Format/VRMExportSettingsEditor.cs
Assets/VRM/Editor/Format/VRMExportSettingsEditor.cs.meta
Assets/VRM/Editor/Format/VRMHumanoidNormalizerMenu.cs
Assets/VRM/Editor/Format/VRMHumanoidNormalizerMenu.cs.meta
Assets/VRM/Editor/Format/VRMImporterMenu.cs
Assets/VRM/Editor/Format/VRMImporterMenu.cs.meta
Assets/VRM/Editor/Format/VRMMaterialValidator.cs
Assets/VRM/Editor/Format/VRMMaterialValidator.cs.meta
Assets/VRM/Editor/Format/VRMSampleCopy.cs
Assets/VRM/Editor/Format/VRMSampleCopy.cs.meta
Assets/VRM/Editor/Format/VRMVersionMenu.cs
Assets/VRM/Editor/Format/VRMVersionMenu.cs.meta
Assets/VRM/Editor/LookAt.meta
Assets/VRM/Editor/LookAt/VRMLookAtHeadEditor.cs
Assets/VRM/Editor/LookAt/VRMLookAtHeadEditor.cs.meta
Assets/VRM/Editor/Meta.meta
Assets/VRM/Editor/Meta/VRMMetaEditor.cs
Assets/VRM/Editor/Meta/VRMMetaEditor.cs.meta
Assets/VRM/Editor/Meta/VRMMetaObjectEditor.cs
Assets/VRM/Editor/Meta/VRMMetaObjectEditor.cs.meta
Assets/VRM/Editor/SkinnedMeshUtility.meta
Assets/VRM/Editor/SkinnedMeshUtility/VRMMeshIntegratorUtility.cs
Assets/VRM/Editor/SkinnedMeshUtility/VRMMeshIntegratorUtility.cs.meta
Assets/VRM/Editor/SkinnedMeshUtility/VrmMeshIntegratorWizard.cs
Assets/VRM/Editor/SkinnedMeshUtility/VrmMeshIntegratorWizard.cs.meta
Assets/VRM/Editor/SkinnedMeshUtility/VrmPrefabUtility.cs
Assets/VRM/Editor/SkinnedMeshUtility/VrmPrefabUtility.cs.meta
Assets/VRM/Editor/SpringBone.meta
Assets/VRM/Editor/SpringBone/VRMSpringBoneColliderGroupEditor.cs
Assets/VRM/Editor/SpringBone/VRMSpringBoneColliderGroupEditor.cs.meta
Assets/VRM/Editor/SpringBone/VRMSpringBoneUtilityEditor.cs
Assets/VRM/Editor/SpringBone/VRMSpringBoneUtilityEditor.cs.meta
Assets/VRM/Editor/SpringBone/VRMSpringBoneValidator.cs
Assets/VRM/Editor/SpringBone/VRMSpringBoneValidator.cs.meta
Assets/VRM/Editor/VRM.Editor.asmdef
Assets/VRM/Editor/VRM.Editor.asmdef.meta
Assets/VRM/Editor/VRMExportUnityPackage.cs
Assets/VRM/Editor/VRMExportUnityPackage.cs.meta
Assets/VRM/Editor/VRMMonoBehaviourComparator.cs
Assets/VRM/Editor/VRMMonoBehaviourComparator.cs.meta
Assets/VRM/Editor/VrmPreference.cs
Assets/VRM/Editor/VrmPreference.cs.meta
Assets/VRM/Editor/VrmTopMenu.cs
Assets/VRM/Editor/VrmTopMenu.cs.meta
Assets/VRM/LICENSE.md
Assets/VRM/LICENSE.md.meta
Assets/VRM/package.json
Assets/VRM/package.json.meta
Assets/VRM/README.md
Assets/VRM/README.md.meta
Assets/VRM/README.url
Assets/VRM/README.url.meta
Assets/VRM/Runtime.meta
Assets/VRM/Runtime/BlendShape.meta
Assets/VRM/Runtime/BlendShape/BlendShapeAvatar.cs
Assets/VRM/Runtime/BlendShape/BlendShapeAvatar.cs.meta
Assets/VRM/Runtime/BlendShape/BlendShapeBindingMerger.cs
Assets/VRM/Runtime/BlendShape/BlendShapeBindingMerger.cs.meta
Assets/VRM/Runtime/BlendShape/BlendShapeClip.cs
Assets/VRM/Runtime/BlendShape/BlendShapeClip.cs.meta
Assets/VRM/Runtime/BlendShape/BlendShapeClipHandler.cs
Assets/VRM/Runtime/BlendShape/BlendShapeClipHandler.cs.meta
Assets/VRM/Runtime/BlendShape/BlendShapeKey.cs
Assets/VRM/Runtime/BlendShape/BlendShapeKey.cs.meta
Assets/VRM/Runtime/BlendShape/BlendShapeMerger.cs
Assets/VRM/Runtime/BlendShape/BlendShapeMerger.cs.meta
Assets/VRM/Runtime/BlendShape/Blinker.cs
Assets/VRM/Runtime/BlendShape/Blinker.cs.meta
Assets/VRM/Runtime/BlendShape/MaterialValueBindingMerger.cs
Assets/VRM/Runtime/BlendShape/MaterialValueBindingMerger.cs.meta
Assets/VRM/Runtime/BlendShape/MeshPreviewItem.cs
Assets/VRM/Runtime/BlendShape/MeshPreviewItem.cs.meta
Assets/VRM/Runtime/BlendShape/PreviewSceneManager.cs
Assets/VRM/Runtime/BlendShape/PreviewSceneManager.cs.meta
Assets/VRM/Runtime/BlendShape/VRMBlendShapeProxy.cs
Assets/VRM/Runtime/BlendShape/VRMBlendShapeProxy.cs.meta
Assets/VRM/Runtime/EnumUtil.cs
Assets/VRM/Runtime/EnumUtil.cs.meta
Assets/VRM/Runtime/Extensions.meta
Assets/VRM/Runtime/Extensions/EnumExtensions.cs
Assets/VRM/Runtime/Extensions/EnumExtensions.cs.meta
Assets/VRM/Runtime/Extensions/glTF_VRMExtensions.cs
Assets/VRM/Runtime/Extensions/glTF_VRMExtensions.cs.meta
Assets/VRM/Runtime/Extensions/VrmHumanoidExtensions.cs
Assets/VRM/Runtime/Extensions/VrmHumanoidExtensions.cs.meta
Assets/VRM/Runtime/FastSpringBone.meta
Assets/VRM/Runtime/FastSpringBone/Blittables.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableCollider.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableCollider.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliderGroup.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliderGroup.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliderGroups.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliderGroups.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliders.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableColliders.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittablePoint.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittablePoint.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittablePoints.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittablePoints.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableRootBone.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableRootBone.cs.meta
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableTransform.cs
Assets/VRM/Runtime/FastSpringBone/Blittables/BlittableTransform.cs.meta
Assets/VRM/Runtime/FastSpringBone/Components.meta
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringBoneColliderGroup.cs
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringBoneColliderGroup.cs.meta
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringBoneScheduler.cs
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringBoneScheduler.cs.meta
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringRootBone.cs
Assets/VRM/Runtime/FastSpringBone/Components/FastSpringRootBone.cs.meta
Assets/VRM/Runtime/FastSpringBone/FastSpringBone.asmdef
Assets/VRM/Runtime/FastSpringBone/FastSpringBone.asmdef.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeColliderGroup.cs
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeColliderGroup.cs.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeColliderGroups.cs
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeColliderGroups.cs.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativePointer.cs
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativePointer.cs.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativePoints.cs
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativePoints.cs.meta
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeTransform.cs
Assets/VRM/Runtime/FastSpringBone/NativeWrappers/NativeTransform.cs.meta
Assets/VRM/Runtime/FastSpringBone/Registries.meta
Assets/VRM/Runtime/FastSpringBone/Registries/ColliderGroupRegistry.cs
Assets/VRM/Runtime/FastSpringBone/Registries/ColliderGroupRegistry.cs.meta
Assets/VRM/Runtime/FastSpringBone/Registries/Registry.cs
Assets/VRM/Runtime/FastSpringBone/Registries/Registry.cs.meta
Assets/VRM/Runtime/FastSpringBone/Registries/RootBoneRegistry.cs
Assets/VRM/Runtime/FastSpringBone/Registries/RootBoneRegistry.cs.meta
Assets/VRM/Runtime/FastSpringBone/Registries/TransformRegistry.cs
Assets/VRM/Runtime/FastSpringBone/Registries/TransformRegistry.cs.meta
Assets/VRM/Runtime/FastSpringBone/Registries/TransformSynchronizationType.cs
Assets/VRM/Runtime/FastSpringBone/Registries/TransformSynchronizationType.cs.meta
Assets/VRM/Runtime/FastSpringBone/Schedulers.meta
Assets/VRM/Runtime/FastSpringBone/Schedulers/PullTransformJobScheduler.cs
Assets/VRM/Runtime/FastSpringBone/Schedulers/PullTransformJobScheduler.cs.meta
Assets/VRM/Runtime/FastSpringBone/Schedulers/PushTransformJobScheduler.cs
Assets/VRM/Runtime/FastSpringBone/Schedulers/PushTransformJobScheduler.cs.meta
Assets/VRM/Runtime/FastSpringBone/Schedulers/UpdateSpringBoneJobScheduler.cs
Assets/VRM/Runtime/FastSpringBone/Schedulers/UpdateSpringBoneJobScheduler.cs.meta
Assets/VRM/Runtime/FirstPerson.meta
Assets/VRM/Runtime/FirstPerson/VRMFirstPerson.cs
Assets/VRM/Runtime/FirstPerson/VRMFirstPerson.cs.meta
Assets/VRM/Runtime/FirstPerson/VRMFirstPersonCameraManager.cs
Assets/VRM/Runtime/FirstPerson/VRMFirstPersonCameraManager.cs.meta
Assets/VRM/Runtime/Format.meta
Assets/VRM/Runtime/Format/glTF_VRM_BlendShape.cs
Assets/VRM/Runtime/Format/glTF_VRM_BlendShape.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_extensions.cs
Assets/VRM/Runtime/Format/glTF_VRM_extensions.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_FirstPerson.cs
Assets/VRM/Runtime/Format/glTF_VRM_FirstPerson.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_Humanoid.cs
Assets/VRM/Runtime/Format/glTF_VRM_Humanoid.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_Material.cs
Assets/VRM/Runtime/Format/glTF_VRM_Material.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_Meta.cs
Assets/VRM/Runtime/Format/glTF_VRM_Meta.cs.meta
Assets/VRM/Runtime/Format/glTF_VRM_SecondaryAnimation.cs
Assets/VRM/Runtime/Format/glTF_VRM_SecondaryAnimation.cs.meta
Assets/VRM/Runtime/Format/VRMDeserializer.g.cs
Assets/VRM/Runtime/Format/VRMDeserializer.g.cs.meta
Assets/VRM/Runtime/Format/VRMException.cs
Assets/VRM/Runtime/Format/VRMException.cs.meta
Assets/VRM/Runtime/Format/VRMSerializer.g.cs
Assets/VRM/Runtime/Format/VRMSerializer.g.cs.meta
Assets/VRM/Runtime/Format/VRMSpecVersion.cs
Assets/VRM/Runtime/Format/VRMSpecVersion.cs.meta
Assets/VRM/Runtime/Format/VRMVersion.cs
Assets/VRM/Runtime/Format/VRMVersion.cs.meta
Assets/VRM/Runtime/Format/VRMVersionPartial.cs
Assets/VRM/Runtime/Format/VRMVersionPartial.cs.meta
Assets/VRM/Runtime/Humanoid.meta
Assets/VRM/Runtime/Humanoid/VRMHumanoidDescription.cs
Assets/VRM/Runtime/Humanoid/VRMHumanoidDescription.cs.meta
Assets/VRM/Runtime/IO.meta
Assets/VRM/Runtime/IO/VRMData.cs
Assets/VRM/Runtime/IO/VRMData.cs.meta
Assets/VRM/Runtime/IO/VRMException.cs
Assets/VRM/Runtime/IO/VRMException.cs.meta
Assets/VRM/Runtime/IO/VRMExporter.cs
Assets/VRM/Runtime/IO/VRMExporter.cs.meta
Assets/VRM/Runtime/IO/VRMImporterContext.cs
Assets/VRM/Runtime/IO/VRMImporterContext.cs.meta
Assets/VRM/Runtime/IO/VRMImporterContextExtensions.cs
Assets/VRM/Runtime/IO/VRMImporterContextExtensions.cs.meta
Assets/VRM/Runtime/IO/VRMMaterialDescriptorGenerator.cs
Assets/VRM/Runtime/IO/VRMMaterialDescriptorGenerator.cs.meta
Assets/VRM/Runtime/IO/VRMMaterialExporter.cs
Assets/VRM/Runtime/IO/VRMMaterialExporter.cs.meta
Assets/VRM/Runtime/IO/VRMMToonMaterialImporter.cs
Assets/VRM/Runtime/IO/VRMMToonMaterialImporter.cs.meta
Assets/VRM/Runtime/IO/VRMMToonTextureImporter.cs
Assets/VRM/Runtime/IO/VRMMToonTextureImporter.cs.meta
Assets/VRM/Runtime/IO/VrmTextureDescriptorGenerator.cs
Assets/VRM/Runtime/IO/VrmTextureDescriptorGenerator.cs.meta
Assets/VRM/Runtime/IO/VRMUnlitTransparentZWriteMaterialImporter.cs
Assets/VRM/Runtime/IO/VRMUnlitTransparentZWriteMaterialImporter.cs.meta
Assets/VRM/Runtime/IO/VRMURPMaterialDescriptorGenerator.cs
Assets/VRM/Runtime/IO/VRMURPMaterialDescriptorGenerator.cs.meta
Assets/VRM/Runtime/IO/VrmUtility.cs
Assets/VRM/Runtime/IO/VrmUtility.cs.meta
Assets/VRM/Runtime/IVRMComponent.cs
Assets/VRM/Runtime/IVRMComponent.cs.meta
Assets/VRM/Runtime/LookAt.meta
Assets/VRM/Runtime/LookAt/CurveMapper.cs
Assets/VRM/Runtime/LookAt/CurveMapper.cs.meta
Assets/VRM/Runtime/LookAt/LookAtTargetSwitcher.cs
Assets/VRM/Runtime/LookAt/LookAtTargetSwitcher.cs.meta
Assets/VRM/Runtime/LookAt/LookTarget.cs
Assets/VRM/Runtime/LookAt/LookTarget.cs.meta
Assets/VRM/Runtime/LookAt/Matrix4x4Extensions.cs
Assets/VRM/Runtime/LookAt/Matrix4x4Extensions.cs.meta
Assets/VRM/Runtime/LookAt/OffsetOnTransform.cs
Assets/VRM/Runtime/LookAt/OffsetOnTransform.cs.meta
Assets/VRM/Runtime/LookAt/VRMLookAt.cs
Assets/VRM/Runtime/LookAt/VRMLookAt.cs.meta
Assets/VRM/Runtime/LookAt/VRMLookAtBlendShapeApplyer.cs
Assets/VRM/Runtime/LookAt/VRMLookAtBlendShapeApplyer.cs.meta
Assets/VRM/Runtime/LookAt/VRMLookAtBoneApplyer.cs
Assets/VRM/Runtime/LookAt/VRMLookAtBoneApplyer.cs.meta
Assets/VRM/Runtime/LookAt/VRMLookAtHead.cs
Assets/VRM/Runtime/LookAt/VRMLookAtHead.cs.meta
Assets/VRM/Runtime/Meta.meta
Assets/VRM/Runtime/Meta/VRMMeta.cs
Assets/VRM/Runtime/Meta/VRMMeta.cs.meta
Assets/VRM/Runtime/Meta/VRMMetaInformation.cs
Assets/VRM/Runtime/Meta/VRMMetaInformation.cs.meta
Assets/VRM/Runtime/Meta/VRMMetaObject.cs
Assets/VRM/Runtime/Meta/VRMMetaObject.cs.meta
Assets/VRM/Runtime/SkinnedMeshUtility.meta
Assets/VRM/Runtime/SkinnedMeshUtility/VRMBoneNormalizer.cs
Assets/VRM/Runtime/SkinnedMeshUtility/VRMBoneNormalizer.cs.meta
Assets/VRM/Runtime/SpringBone.meta
Assets/VRM/Runtime/SpringBone/FastSpringBoneDisposer.cs
Assets/VRM/Runtime/SpringBone/FastSpringBoneDisposer.cs.meta
Assets/VRM/Runtime/SpringBone/FastSpringBoneReplacer.cs
Assets/VRM/Runtime/SpringBone/FastSpringBoneReplacer.cs.meta
Assets/VRM/Runtime/SpringBone/FastSpringBoneService.cs
Assets/VRM/Runtime/SpringBone/FastSpringBoneService.cs.meta
Assets/VRM/Runtime/SpringBone/TransformExtensions.cs
Assets/VRM/Runtime/SpringBone/TransformExtensions.cs.meta
Assets/VRM/Runtime/SpringBone/VRMSpringBone.cs
Assets/VRM/Runtime/SpringBone/VRMSpringBone.cs.meta
Assets/VRM/Runtime/SpringBone/VRMSpringBoneColliderGroup.cs
Assets/VRM/Runtime/SpringBone/VRMSpringBoneColliderGroup.cs.meta
Assets/VRM/Runtime/SpringBone/VRMSpringUtility.cs
Assets/VRM/Runtime/SpringBone/VRMSpringUtility.cs.meta
Assets/VRM/Runtime/VRM.asmdef
Assets/VRM/Runtime/VRM.asmdef.meta
Assets/VRM/Tests.meta
Assets/VRM/Tests/EnumUtilTest.cs
Assets/VRM/Tests/EnumUtilTest.cs.meta
Assets/VRM/Tests/Exception.cs
Assets/VRM/Tests/Exception.cs.meta
Assets/VRM/Tests/InvalidFileNameTest.cs
Assets/VRM/Tests/InvalidFileNameTest.cs.meta
Assets/VRM/Tests/MeshTests.cs
Assets/VRM/Tests/MeshTests.cs.meta
Assets/VRM/Tests/MToonTest.cs
Assets/VRM/Tests/MToonTest.cs.meta
Assets/VRM/Tests/NormalizeTests.cs
Assets/VRM/Tests/NormalizeTests.cs.meta
Assets/VRM/Tests/SampleTests.meta
Assets/VRM/Tests/SampleTests/Resources.meta
Assets/VRM/Tests/SampleTests/Resources/Materials.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_culloff.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_culloff.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_cutout.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_cutout.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_opaque.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_opaque.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_transparent.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/mtoon_transparent.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_cutout.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_cutout.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_texture.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_texture.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_transparent.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_transparent.mat.meta
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_transparent_zwrite.mat
Assets/VRM/Tests/SampleTests/Resources/Materials/vrm_unlit_transparent_zwrite.mat.meta
Assets/VRM/Tests/SampleTests/VRM.Samples.Editor.Tests.asmdef
Assets/VRM/Tests/SampleTests/VRM.Samples.Editor.Tests.asmdef.meta
Assets/VRM/Tests/SampleTests/VRMImportExportTests.cs
Assets/VRM/Tests/SampleTests/VRMImportExportTests.cs.meta
Assets/VRM/Tests/SampleTests/VRMMaterialTests.cs
Assets/VRM/Tests/SampleTests/VRMMaterialTests.cs.meta
Assets/VRM/Tests/UniVRMSerializeTests.cs
Assets/VRM/Tests/UniVRMSerializeTests.cs.meta
Assets/VRM/Tests/VersionTests.cs
Assets/VRM/Tests/VersionTests.cs.meta
Assets/VRM/Tests/VRM.Tests.asmdef
Assets/VRM/Tests/VRM.Tests.asmdef.meta
Assets/VRM/Tests/VRMBlendShapeKeyTest.cs
Assets/VRM/Tests/VRMBlendShapeKeyTest.cs.meta
Assets/VRM/Tests/VrmDividedMeshTests.cs
Assets/VRM/Tests/VrmDividedMeshTests.cs.meta
Assets/VRM/Tests/VRMLoadTests.cs
Assets/VRM/Tests/VRMLoadTests.cs.meta
Assets/VRM/Tests/VRMLookAtTests.cs
Assets/VRM/Tests/VRMLookAtTests.cs.meta
Assets/VRM/Tests/VRMTestAssets.cs
Assets/VRM/Tests/VRMTestAssets.cs.meta
Assets/VRM/Tests/VRMTextureEnumerateTests.cs
Assets/VRM/Tests/VRMTextureEnumerateTests.cs.meta
Assets/VRMShaders.meta
Assets/VRMShaders/CHANGELOG.md
Assets/VRMShaders/CHANGELOG.md.meta
Assets/VRMShaders/Documentation.meta
Assets/VRMShaders/Documentation/VRMShaders.md
Assets/VRMShaders/Documentation/VRMShaders.md.meta
Assets/VRMShaders/GLTF.meta
Assets/VRMShaders/GLTF/IO.meta
Assets/VRMShaders/GLTF/IO/Editor.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture/EditorTextureUtility.cs
Assets/VRMShaders/GLTF/IO/Editor/Texture/EditorTextureUtility.cs.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture/Exporter.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture/Exporter/EditorTextureSerializer.cs
Assets/VRMShaders/GLTF/IO/Editor/Texture/Exporter/EditorTextureSerializer.cs.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture/Importer.meta
Assets/VRMShaders/GLTF/IO/Editor/Texture/Importer/TextureImporterConfigurator.cs
Assets/VRMShaders/GLTF/IO/Editor/Texture/Importer/TextureImporterConfigurator.cs.meta
Assets/VRMShaders/GLTF/IO/Editor/VRMShaders.GLTF.IO.Editor.asmdef
Assets/VRMShaders/GLTF/IO/Editor/VRMShaders.GLTF.IO.Editor.asmdef.meta
Assets/VRMShaders/GLTF/IO/Resources.meta
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF.meta
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/NormalMapExporter.shader
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/NormalMapExporter.shader.meta
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/StandardMapExporter.shader
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/StandardMapExporter.shader.meta
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/StandardMapImporter.shader
Assets/VRMShaders/GLTF/IO/Resources/UniGLTF/StandardMapImporter.shader.meta
Assets/VRMShaders/GLTF/IO/Runtime.meta
Assets/VRMShaders/GLTF/IO/Runtime/Animation.meta
Assets/VRMShaders/GLTF/IO/Runtime/Animation/Importer.meta
Assets/VRMShaders/GLTF/IO/Runtime/Animation/Importer/AnimationClipFactory.cs
Assets/VRMShaders/GLTF/IO/Runtime/Animation/Importer/AnimationClipFactory.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/IAwaitCaller.cs
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/IAwaitCaller.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/ImmediateCaller.cs
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/ImmediateCaller.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/NextFrameTaskScheduler.cs
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/NextFrameTaskScheduler.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/RuntimeOnlyAwaitCaller.cs
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/RuntimeOnlyAwaitCaller.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/TinyManagedTaskScheduler.cs
Assets/VRMShaders/GLTF/IO/Runtime/AwaitCaller/TinyManagedTaskScheduler.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/ColorSpace.cs
Assets/VRMShaders/GLTF/IO/Runtime/ColorSpace.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/IResponsibilityForDestroyObjects.cs
Assets/VRMShaders/GLTF/IO/Runtime/IResponsibilityForDestroyObjects.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Material.meta
Assets/VRMShaders/GLTF/IO/Runtime/Material/Importer.meta
Assets/VRMShaders/GLTF/IO/Runtime/Material/Importer/MaterialDescriptor.cs
Assets/VRMShaders/GLTF/IO/Runtime/Material/Importer/MaterialDescriptor.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Material/Importer/MaterialFactory.cs
Assets/VRMShaders/GLTF/IO/Runtime/Material/Importer/MaterialFactory.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/SubAssetKey.cs
Assets/VRMShaders/GLTF/IO/Runtime/SubAssetKey.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/NormalConverter.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/NormalConverter.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/OcclusionMetallicRoughnessConverter.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/OcclusionMetallicRoughnessConverter.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/TextureConverter.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Converter/TextureConverter.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/ITextureExporter.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/ITextureExporter.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/ITextureSerializer.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/ITextureSerializer.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/RuntimeTextureSerializer.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/RuntimeTextureSerializer.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExporter.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExporter.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExportParam.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExportParam.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExportTypes.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Exporter/TextureExportTypes.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/DeserializingTextureInfo.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/DeserializingTextureInfo.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/ITextureDeserializer.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/ITextureDeserializer.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/SamplerParam.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/SamplerParam.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureDescriptor.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureDescriptor.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureDescriptorSet.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureDescriptorSet.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureFactory.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureFactory.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureImportName.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureImportName.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureImportTypes.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/TextureImportTypes.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/UnityTextureDeserializer.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Importer/UnityTextureDeserializer.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Util.meta
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Util/TextureExtensions.cs
Assets/VRMShaders/GLTF/IO/Runtime/Texture/Util/TextureExtensions.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Util.meta
Assets/VRMShaders/GLTF/IO/Runtime/Util/KeyValuePariExtensions.cs
Assets/VRMShaders/GLTF/IO/Runtime/Util/KeyValuePariExtensions.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Util/Symbols.cs
Assets/VRMShaders/GLTF/IO/Runtime/Util/Symbols.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/Util/UnityObjectDestroyer.cs
Assets/VRMShaders/GLTF/IO/Runtime/Util/UnityObjectDestroyer.cs.meta
Assets/VRMShaders/GLTF/IO/Runtime/VRMShaders.GLTF.IO.Runtime.asmdef
Assets/VRMShaders/GLTF/IO/Runtime/VRMShaders.GLTF.IO.Runtime.asmdef.meta
Assets/VRMShaders/GLTF/IO/Tests.meta
Assets/VRMShaders/GLTF/IO/Tests/4x4_non_readable.png
Assets/VRMShaders/GLTF/IO/Tests/4x4_non_readable.png.meta
Assets/VRMShaders/GLTF/IO/Tests/4x4_non_readable_compressed.DDS
Assets/VRMShaders/GLTF/IO/Tests/4x4_non_readable_compressed.DDS.meta
Assets/VRMShaders/GLTF/IO/Tests/CopyTextureTests.cs
Assets/VRMShaders/GLTF/IO/Tests/CopyTextureTests.cs.meta
Assets/VRMShaders/GLTF/IO/Tests/MetallicRoughnessConverterTests.cs
Assets/VRMShaders/GLTF/IO/Tests/MetallicRoughnessConverterTests.cs.meta
Assets/VRMShaders/GLTF/IO/Tests/TextureBytesTests.cs
Assets/VRMShaders/GLTF/IO/Tests/TextureBytesTests.cs.meta
Assets/VRMShaders/GLTF/IO/Tests/VRMShaders.GLTF.IO.Tests.asmdef
Assets/VRMShaders/GLTF/IO/Tests/VRMShaders.GLTF.IO.Tests.asmdef.meta
Assets/VRMShaders/GLTF/UniUnlit.meta
Assets/VRMShaders/GLTF/UniUnlit/Editor.meta
Assets/VRMShaders/GLTF/UniUnlit/Editor/UniUnlitEditor.cs
Assets/VRMShaders/GLTF/UniUnlit/Editor/UniUnlitEditor.cs.meta
Assets/VRMShaders/GLTF/UniUnlit/Editor/VRMShaders.GLTF.UniUnlit.Editor.asmdef
Assets/VRMShaders/GLTF/UniUnlit/Editor/VRMShaders.GLTF.UniUnlit.Editor.asmdef.meta
Assets/VRMShaders/GLTF/UniUnlit/Resources.meta
Assets/VRMShaders/GLTF/UniUnlit/Resources/UniGLTF.meta
Assets/VRMShaders/GLTF/UniUnlit/Resources/UniGLTF/UniUnlit.shader
Assets/VRMShaders/GLTF/UniUnlit/Resources/UniGLTF/UniUnlit.shader.meta
Assets/VRMShaders/GLTF/UniUnlit/Runtime.meta
Assets/VRMShaders/GLTF/UniUnlit/Runtime/UniUnlitUtil.cs
Assets/VRMShaders/GLTF/UniUnlit/Runtime/UniUnlitUtil.cs.meta
Assets/VRMShaders/GLTF/UniUnlit/Runtime/VRMShaders.GLTF.UniUnlit.Runtime.asmdef
Assets/VRMShaders/GLTF/UniUnlit/Runtime/VRMShaders.GLTF.UniUnlit.Runtime.asmdef.meta
Assets/VRMShaders/LICENSE.md
Assets/VRMShaders/LICENSE.md.meta
Assets/VRMShaders/package.json
Assets/VRMShaders/package.json.meta
Assets/VRMShaders/README.md
Assets/VRMShaders/README.md.meta
Assets/VRMShaders/VRM.meta
Assets/VRMShaders/VRM/IO.meta
Assets/VRMShaders/VRM/IO/Editor.meta
Assets/VRMShaders/VRM/IO/Editor/ShaderPropMenu.cs
Assets/VRMShaders/VRM/IO/Editor/ShaderPropMenu.cs.meta
Assets/VRMShaders/VRM/IO/Editor/VRMShaders.VRM.IO.Editor.asmdef
Assets/VRMShaders/VRM/IO/Editor/VRMShaders.VRM.IO.Editor.asmdef.meta
Assets/VRMShaders/VRM/IO/Runtime.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/PreExportShaders_GLTF.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/PreExportShaders_GLTF.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Standard.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Standard.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/UniGLTF_UniUnlit.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/UniGLTF_UniUnlit.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Color.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Color.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Texture.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Texture.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Transparent.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Transparent.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Transparent_Cutout.cs
Assets/VRMShaders/VRM/IO/Runtime/GLTF/Unlit_Transparent_Cutout.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/PreShaderPropExporter.cs
Assets/VRMShaders/VRM/IO/Runtime/PreShaderPropExporter.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/ShaderProps.cs
Assets/VRMShaders/VRM/IO/Runtime/ShaderProps.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/PreExportShaders_VRM.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/PreExportShaders_VRM.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_MToon.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_MToon.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitCutout.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitCutout.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTexture.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTexture.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTransparent.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTransparent.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTransparentZWrite.cs
Assets/VRMShaders/VRM/IO/Runtime/VRM/VRM_UnlitTransparentZWrite.cs.meta
Assets/VRMShaders/VRM/IO/Runtime/VRMShaders.VRM.IO.Runtime.asmdef
Assets/VRMShaders/VRM/IO/Runtime/VRMShaders.VRM.IO.Runtime.asmdef.meta
Assets/VRMShaders/VRM/MToon.meta
Assets/VRMShaders/VRM/MToon/LICENSE
Assets/VRMShaders/VRM/MToon/LICENSE.meta
Assets/VRMShaders/VRM/MToon/MToon.meta
Assets/VRMShaders/VRM/MToon/MToon/Editor.meta
Assets/VRMShaders/VRM/MToon/MToon/Editor/EditorEnums.cs
Assets/VRMShaders/VRM/MToon/MToon/Editor/EditorEnums.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Editor/EditorUtils.cs
Assets/VRMShaders/VRM/MToon/MToon/Editor/EditorUtils.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Editor/MToon.Editor.asmdef
Assets/VRMShaders/VRM/MToon/MToon/Editor/MToon.Editor.asmdef.meta
Assets/VRMShaders/VRM/MToon/MToon/Editor/MToonInspector.cs
Assets/VRMShaders/VRM/MToon/MToon/Editor/MToonInspector.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/MToon.asmdef
Assets/VRMShaders/VRM/MToon/MToon/MToon.asmdef.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToon.shader
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToon.shader.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonCore.cginc
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonCore.cginc.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonSM3.cginc
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonSM3.cginc.meta
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonSM4.cginc
Assets/VRMShaders/VRM/MToon/MToon/Resources/Shaders/MToonSM4.cginc.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ex_OutlineWidth_World.mat
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ex_OutlineWidth_World.mat.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ground.mat
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Ground.mat.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Toon.mat
Assets/VRMShaders/VRM/MToon/MToon/Samples/Materials/Toon.mat.meta
Assets/VRMShaders/VRM/MToon/MToon/Samples/OutlineWidthModes.unity
Assets/VRMShaders/VRM/MToon/MToon/Samples/OutlineWidthModes.unity.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/Enums.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/Enums.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/MToonDefinition.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/MToonDefinition.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/Utils.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/Utils.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsGetter.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsGetter.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsSetter.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsSetter.cs.meta
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsVersion.cs
Assets/VRMShaders/VRM/MToon/MToon/Scripts/UtilsVersion.cs.meta
Assets/VRMShaders/VRM/MToon/README.md
Assets/VRMShaders/VRM/MToon/README.md.meta
Assets/VRMShaders/VRM/VRMShaders.shadervariants
Assets/VRMShaders/VRM/VRMShaders.shadervariants.meta
Assets/VRMShaders/VRM10.meta
Assets/VRMShaders/VRM10/Format.meta
Assets/VRMShaders/VRM10/Format/Runtime.meta
Assets/VRMShaders/VRM10/Format/Runtime/MaterialsMToon.meta
Assets/VRMShaders/VRM10/Format/Runtime/MaterialsMToon/Format.g.cs
Assets/VRMShaders/VRM10/Format/Runtime/MaterialsMToon/Format.g.cs.meta
Assets/VRMShaders/VRM10/Format/Runtime/VRMShaders.VRM10.Format.Runtime.asmdef
Assets/VRMShaders/VRM10/Format/Runtime/VRMShaders.VRM10.Format.Runtime.asmdef.meta
Assets/VRMShaders/VRM10/MToon10.meta
Assets/VRMShaders/VRM10/MToon10/Editor.meta
Assets/VRMShaders/VRM10/MToon10/Editor/LabelScope.cs
Assets/VRMShaders/VRM10/MToon10/Editor/LabelScope.cs.meta
Assets/VRMShaders/VRM10/MToon10/Editor/MToon10EditorEditMode.cs
Assets/VRMShaders/VRM10/MToon10/Editor/MToon10EditorEditMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Editor/MToonInspector.cs
Assets/VRMShaders/VRM10/MToon10/Editor/MToonInspector.cs.meta
Assets/VRMShaders/VRM10/MToon10/Editor/VRMShaders.VRM10.MToon10.Editor.asmdef
Assets/VRMShaders/VRM10/MToon10/Editor/VRMShaders.VRM10.MToon10.Editor.asmdef.meta
Assets/VRMShaders/VRM10/MToon10/Resources.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon.shader
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon.shader.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_attribute.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_attribute.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_define.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_define.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_forward_fragment.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_forward_fragment.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_forward_vertex.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_forward_vertex.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_alpha.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_alpha.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_normal.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_normal.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_uv.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_uv.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_vertex.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_geometry_vertex.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_input.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_input.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_lighting_mtoon.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_lighting_mtoon.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_lighting_unity.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_lighting_unity.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_utility.hlsl
Assets/VRMShaders/VRM10/MToon10/Resources/VRM10/vrmc_materials_mtoon_utility.hlsl.meta
Assets/VRMShaders/VRM10/MToon10/Runtime.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/Extensions.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/Extensions/MaterialExtensions.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/Extensions/MaterialExtensions.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/MToon10Context.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/MToon10Context.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/MToon10Migrator.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/MToon10Migrator.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/MToonValidator.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/MToonValidator.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10AlphaMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10AlphaMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10DoubleSidedMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10DoubleSidedMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10EmissiveMapKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10EmissiveMapKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10NormalMapKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10NormalMapKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10OutlineMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10OutlineMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10OutlineModeKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10OutlineModeKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10ParameterMapKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10ParameterMapKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10RimMapKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10RimMapKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10TransparentWithZWriteMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/MToonDefinedValues/MToon10TransparentWithZWriteMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Meta.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Meta.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Prop.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Prop.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Properties.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/Properties/MToon10Properties.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityAlphaModeKeyword.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityAlphaModeKeyword.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityAlphaToMaskMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityAlphaToMaskMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityCullMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityCullMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityRenderTag.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityRenderTag.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityZWriteMode.cs
Assets/VRMShaders/VRM10/MToon10/Runtime/UnityShaderLab/ShaderLabDefinedValues/UnityZWriteMode.cs.meta
Assets/VRMShaders/VRM10/MToon10/Runtime/VRMShaders.VRM10.MToon10.Runtime.asmdef
Assets/VRMShaders/VRM10/MToon10/Runtime/VRMShaders.VRM10.MToon10.Runtime.asmdef.meta
Assets/VRMShaders/VRM10/MToon10/Tests.meta
Assets/VRMShaders/VRM10/MToon10/Tests/MigrationTests.cs
Assets/VRMShaders/VRM10/MToon10/Tests/MigrationTests.cs.meta
Assets/VRMShaders/VRM10/MToon10/Tests/VRMShaders.VRM10.MToon10.Tests.asmdef
Assets/VRMShaders/VRM10/MToon10/Tests/VRMShaders.VRM10.MToon10.Tests.asmdef.meta
Assets/VRMShaders/VRM10/VRM10Shaders.shadervariants
Assets/VRMShaders/VRM10/VRM10Shaders.shadervariants.meta
Assets/Yara.fbx
Assets/Yara.fbx.meta
Packages/manifest.json
Packages/packages-lock.json
ProjectSettings/DynamicsManager.asset
ProjectSettings/ProjectSettings.asset
ProjectSettings/TagManager.asset


Jieun:
I was responsible for character controller, input, locomotion animations, attack animations, third person camera, particle effect, sound effect, ambience noise
Assets/Animations/PlayerAnimationController.controller
Assets/Animations/PlayerAnimations/Cross Punch.fbx
Assets/Animations/PlayerAnimations/Falling Forward Death.fbx
Assets/Animations/PlayerAnimations/Fast Run.fbx
Assets/Animations/PlayerAnimations/Idle.fbx
Assets/Animations/PlayerAnimations/Jumping.fbx
Assets/Animations/PlayerAnimations/Running.fbx
Assets/Animations/PlayerAnimations/Standing 1H Magic Attack 01.fbx
Assets/Animations/PlayerAnimations/Walking.fbx
Assets/Nature - Essentials/Ambiance_Forest_Birds_Loop_Stereo.wav
Assets/New Terrain.asset
Assets/Prefabs/EiriPrefab.prefab
Assets/Prefabs/PlayerPrefab.prefab
Assets/Prefabs/player.prefab
Assets/Scenes/project.unity
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_01.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_02.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_03.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_04.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_05.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_06.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_07.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_08.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_09.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Footstep_10.wav
Assets/StarterAssets/ThirdPersonController/Character/Sfx/Player_Land.wav

Assets/Scripts/CharAnimScript.cs
Assets/Scripts/FaceCameraScript.cs
Assets/Scripts/PlayerController.cs
Assets/Scripts/PlayerController2.cs
Assets/Scripts/QuaternionUtil.cs
Assets/Scripts/ThirdPersonCamera.cs

Kaitlyn - 

Eduardo:
I was responsible for menuing and inventory systems.

Assets/Prefabs/itemDrops/BatteryDrop Variant.prefab
Assets/Prefabs/itemDrops/BulletDrop Variant.prefab
Assets/Prefabs/itemDrops/FirstAidBox Variant.prefab
Assets/Prefabs/itemDrops/FuelDrop Variant.prefab
Assets/Prefabs/itemDrops/Image (item).prefab
Assets/Prefabs/itemDrops/battery.png
Assets/Prefabs/itemDrops/battery_D.asset
Assets/Prefabs/itemDrops/bullet.png
Assets/Prefabs/itemDrops/empty.png
Assets/Prefabs/itemDrops/firstAid.png
Assets/Prefabs/itemDrops/fuel.png
Assets/Prefabs/itemDrops/gasoline.asset
Assets/Prefabs/itemDrops/personalFirstAid.asset
Assets/Scenes/startGame.unity
Assets/Scripts/gameData/MyGameStatus.asset

--- SCRIPT FILES ---

Assets/Scripts/gameData/GameStatus.cs
Assets/Scripts/DeathToggle.cs
Assets/Scripts/InventoryPanel.cs
Assets/Scripts/InventoryToggle.cs
Assets/Scripts/PauseMenuToggle.cs
Assets/Scripts/PlayerController2.cs
Assets/Scripts/buttons/DeathRestart.cs
Assets/Scripts/buttons/EndGame.cs
Assets/Scripts/buttons/InventoryAccess.cs
Assets/Scripts/buttons/InventoryExit.cs
Assets/Scripts/buttons/StartGame.cs
Assets/Scripts/items/ConsumableItem.cs
Assets/Scripts/items/GearItem.cs
Assets/Scripts/items/InventoryItem.cs
Assets/Scripts/items/ItemSlot.cs
Assets/Scripts/items/WeaponItem.cs
Assets/Scripts/items/objectAsItem.cs