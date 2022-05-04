namespace ReactiveUI.ExecutedTwiceBug.ViewModels;

public class SimpleViewModel : ReactiveObject
{
    public List<string> Values { get; set; } = new()
    {
        "a",
        "b"
    };
}