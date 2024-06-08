// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TestBaseCharacter : ModuleRules
{
	public TestBaseCharacter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput", 
			"PerfCounters", 
			"NetCore",
			"PhysicsCore",
			"Chaos",
			"ChaosSolverEngine",
			"Iris",
			"IrisCore"
		});
	}
}
