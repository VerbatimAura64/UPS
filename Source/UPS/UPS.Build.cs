// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UPS : ModuleRules
{
	public UPS(ReadOnlyTargetRules Target) : base(Target)
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
			"UPS",
			"UPS/Variant_Platforming",
			"UPS/Variant_Platforming/Animation",
			"UPS/Variant_Combat",
			"UPS/Variant_Combat/AI",
			"UPS/Variant_Combat/Animation",
			"UPS/Variant_Combat/Gameplay",
			"UPS/Variant_Combat/Interfaces",
			"UPS/Variant_Combat/UI",
			"UPS/Variant_SideScrolling",
			"UPS/Variant_SideScrolling/AI",
			"UPS/Variant_SideScrolling/Gameplay",
			"UPS/Variant_SideScrolling/Interfaces",
			"UPS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
