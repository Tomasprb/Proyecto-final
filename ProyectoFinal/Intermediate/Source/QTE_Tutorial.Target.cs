using UnrealBuildTool;

public class QTE_TutorialTarget : TargetRules
{
	public QTE_TutorialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("QTE_Tutorial");
	}
}
