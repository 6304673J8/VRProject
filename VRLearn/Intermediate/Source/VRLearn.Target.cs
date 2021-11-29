using UnrealBuildTool;

public class VRLearnTarget : TargetRules
{
	public VRLearnTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VRLearn");
	}
}
