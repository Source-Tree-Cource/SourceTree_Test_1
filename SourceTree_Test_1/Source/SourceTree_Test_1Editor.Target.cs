// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SourceTree_Test_1EditorTarget : TargetRules
{
	public SourceTree_Test_1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "SourceTree_Test_1" } );
	}
}
