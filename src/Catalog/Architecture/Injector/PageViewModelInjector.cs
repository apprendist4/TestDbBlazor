﻿using Catalog.Architecture.Page;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Catalog.Architecture.Injector
{
    public abstract class PageViewModelInjector<TViewModel> : ComponentBase, IDisposable
        where TViewModel : IPageViewModelBase
    {
        [Inject]
        [NotNull]
#pragma warning disable CS8618
        protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

        private void OnStateChange(object? sender, PropertyChangedEventArgs e)
        {
            StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            ViewModel.PropertyChanged += (_, _) => StateHasChanged();
            await ViewModel.OnInitializedAsync();
        }

        public void Dispose()
        {
            ViewModel.PropertyChanged -= OnStateChange;
        }
    }
}
