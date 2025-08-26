// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ICE_Task1 : ModuleRules
{
	public ICE_Task1(ReadOnlyTargetRules Target) : base(Target)
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
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ICE_Task1",
			"ICE_Task1/Variant_Platforming",
			"ICE_Task1/Variant_Combat",
			"ICE_Task1/Variant_Combat/AI",
			"ICE_Task1/Variant_SideScrolling",
			"ICE_Task1/Variant_SideScrolling/Gameplay",
			"ICE_Task1/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
