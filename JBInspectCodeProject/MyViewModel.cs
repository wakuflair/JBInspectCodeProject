using CommunityToolkit.Mvvm.ComponentModel;

namespace JBInspectCodeProject;

public partial class MyViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _name;
}