// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Sec03_BuildingEscapeTarget : TargetRules
{
	public Sec03_BuildingEscapeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Sec03_BuildingEscape" } );
	}
}
