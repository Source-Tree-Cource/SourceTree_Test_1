// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SourceTree_Test_1Target : TargetRules
{
	public SourceTree_Test_1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "SourceTree_Test_1" } );
	}
}
