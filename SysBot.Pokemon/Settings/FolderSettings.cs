using System.ComponentModel;
using System.IO;

namespace SysBot.Pokemon;

public class FolderSettings : IDumper
{
    private const string FeatureToggle = nameof(FeatureToggle);
    private const string Files = nameof(Files);
    public override string ToString() => "Folder / Dumping Settings";

    [Category(FeatureToggle), Description("When enabled, all PKM received from users trades will be saved to the Dump folder.")]
    public bool Dump { get; set; }

    [Category(Files), Description("Source folder: The location of the PKM files to distribute while the bot isn't trading.")]
    public string DistributeFolder { get; set; } = string.Empty;

    [Category(Files), Description("Destination folder: where all received PKM files are save to.")]
    public string DumpFolder { get; set; } = string.Empty;

    public void CreateDefaults(string path)
    {
        var dump = Path.Combine(path, "dump");
        Directory.CreateDirectory(dump);
        DumpFolder = dump;
        Dump = true;

        var distribute = Path.Combine(path, "distribute");
        Directory.CreateDirectory(distribute);
        DistributeFolder = distribute;
    }
}
