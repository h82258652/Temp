using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace AiXiFan.Uwp.Collections
{
    public class IncrementalCollection<T> : ObservableCollection<T>, ISupportIncrementalLoading
    {
        private readonly Func<Task<IEnumerable<T>>> _loadFunc;

        private bool _hasMoreItems = true;

        private bool _isLoading;

        public IncrementalCollection(Func<Task<IEnumerable<T>>> loadFunc)
        {
            if (loadFunc == null)
            {
                throw new ArgumentNullException(nameof(loadFunc));
            }

            _loadFunc = loadFunc;
        }

        public bool HasMoreItems
        {
            get
            {
                return _hasMoreItems;
            }
            protected set
            {
                _hasMoreItems = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(HasMoreItems)));
            }
        }

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            protected set
            {
                _isLoading = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsLoading)));
            }
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            return AsyncInfo.Run(c => LoadMoreItemsAsync(c, count));
        }

        public async Task<LoadMoreItemsResult> LoadMoreItemsAsync(CancellationToken cancellationToken, uint count)
        {
            if (IsLoading)
            {
                return new LoadMoreItemsResult()
                {
                    Count = 0
                };
            }

            IsLoading = true;
            try
            {
                var items = await _loadFunc();
                if (items != null)
                {
                    var itemList = items.ToList();
                    foreach (var item in itemList)
                    {
                        Add(item);
                    }
                    return new LoadMoreItemsResult()
                    {
                        Count = (uint)itemList.Count
                    };
                }
                else
                {
                    return new LoadMoreItemsResult()
                    {
                        Count = 0
                    };
                }
            }
            finally
            {
                IsLoading = false;
            }
        }

        public void RaiseHasMoreItemsChanged(bool hasMoreItems)
        {
            HasMoreItems = hasMoreItems;
        }
    }
}