// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Sec03_BuildingEscapeEditorTarget : TargetRules
{
	public Sec03_BuildingEscapeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Sec03_BuildingEscape" } );
	}
}
