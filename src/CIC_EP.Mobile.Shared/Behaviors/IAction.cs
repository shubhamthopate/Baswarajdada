using Xamarin.Forms.Internals;

namespace CIC_EP.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}