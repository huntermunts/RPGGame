using UnrealBuildTool;

public class RPGGAMEClientTarget : TargetRules
{
	public RPGGAMEClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("RPGGAME");
	}
}
