using System.ComponentModel;

namespace Catalog.Architecture.Component;

public interface IComponentViewModel: INotifyPropertyChanged
{
    Task OnInitializeAsync();
}