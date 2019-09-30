namespace FBReader.Core.Interfaces
{
    public interface IDisplayedInSystemNotification
    {
        bool DisplayedInSystemNotification { get; set; }
        byte ShowedInPopupCount { get; set; }
    }
}
