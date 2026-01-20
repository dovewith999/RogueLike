// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Roguelike : ModuleRules
{
	public Roguelike(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Roguelike",
			"Roguelike/Variant_Platforming",
			"Roguelike/Variant_Platforming/Animation",
			"Roguelike/Variant_Combat",
			"Roguelike/Variant_Combat/AI",
			"Roguelike/Variant_Combat/Animation",
			"Roguelike/Variant_Combat/Gameplay",
			"Roguelike/Variant_Combat/Interfaces",
			"Roguelike/Variant_Combat/UI",
			"Roguelike/Variant_SideScrolling",
			"Roguelike/Variant_SideScrolling/AI",
			"Roguelike/Variant_SideScrolling/Gameplay",
			"Roguelike/Variant_SideScrolling/Interfaces",
			"Roguelike/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
