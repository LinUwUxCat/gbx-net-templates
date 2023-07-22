using GBX.NET.Engines.Game;
using GbxToolAPI;

namespace YourProjectName;

[ToolName("YourProjectName")]
[ToolDescription("YourProjectName is a GBX.NET web tool.")]
[ToolAuthors("YOUR_NAME")]
public class YourProjectNameTool : ITool, IHasOutput<NodeFile<CGameCtnBlock>>, IConfigurable<YourProjectNameConfig>
{
    // In the following lines, replace map and CGameCtnChallenge with the tool's input
    // Also replace CGameCtnBlock with the tool's output
    // If not using a config file, remove IConfigurable<YourProjectNameConfig>, YourProjectNameConfig.cs and the variable below
    public YourProjectNameConfig Config { get; set; } = new();
    private readonly CGameCtnChallenge map;

    public YourProjectNameTool(CGameCtnChallenge map) 
    {
        this.map = map;
    }

    public NodeFile<CGameCtnBlock> Produce()
    {
        //Main code
    }
}