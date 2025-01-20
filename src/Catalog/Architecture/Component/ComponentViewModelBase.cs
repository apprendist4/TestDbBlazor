using CommunityToolkit.Mvvm.ComponentModel;

namespace Catalog.Architecture.Component;

public class ComponentViewModelBase
{
    public async Task OnInitializeAsync()
    {
        await InitializeAsync();
    }

    protected virtual async Task InitializeAsync()
    {
        //override this method for initialize component
    }
}