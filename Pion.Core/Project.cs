using System.Collections.Specialized;
using System.IO;
using System.Windows;

namespace Pion.Core;

public sealed class Project
{

    private readonly Dictionary<string, string> _files = [];
    private readonly Guid _id = Guid.NewGuid();

    private string Root => Path.Combine(Path.GetTempPath(), _id.ToString());

    private Project()
    {
    }

    public static Project Create()
    {
        var project = new Project();
        Directory.CreateDirectory(project.Root);
        return project;
    }

    public Project Add<T>()
        where T : FrameworkElement
    {
        var type = typeof(T);
        _files.Add(type.Name + ".cs", ElementGenerator.Generate(type));
        return this;
    }

    public void Finish()
    {
        var paths = new StringCollection();

        _files.ToList().ForEach(file =>
        {
            var path = Path.Combine(Root, file.Key);
            File.WriteAllText(path, file.Value);
            paths.Add(path);
        });

        Clipboard.SetFileDropList(paths);
        Console.WriteLine("Generated files copied to clipboard, press any key to close the app...");
        Console.ReadKey();
    }

}
