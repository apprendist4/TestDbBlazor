using System.ComponentModel;

namespace Catalog.Architecture.Page;

public interface IPageViewModelBase: INotifyPropertyChanged
{
    Task OnInitializedAsync();

}
