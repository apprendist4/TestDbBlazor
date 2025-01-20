using Catalog.Architecture.Enum;
using Catalog.Architecture.Page;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Catalog.Architecture;

public partial class PageViewModelBase : ObservableObject, IPageViewModelBase
{
    [ObservableProperty]
    private PageState _pageState;

    public async Task OnInitializedAsync()
    {
        PageState = PageState.Loading;
        try
        {
            await InitializeAsync().ConfigureAwait(true);
        }
        catch (Exception ) 
        { 
            PageState = PageState.Error;
        }
    }

    protected virtual void NotifyStateChanged() => OnPropertyChanged((string?)null);

    protected virtual async Task InitializeAsync()
    {
        PageState = PageState.Loaded;
        await Task.CompletedTask;
    }

}