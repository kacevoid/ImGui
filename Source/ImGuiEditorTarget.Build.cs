using Flax.Build;

public class ImGuiEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        Modules.Add("ImGui");
    }
}
