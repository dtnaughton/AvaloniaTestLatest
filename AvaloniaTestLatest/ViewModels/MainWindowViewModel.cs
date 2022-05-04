using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using System.Windows.Input;

namespace AvaloniaTestLatest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase content;

        public ViewModelBase Content
        {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }


        public MainWindowViewModel()
        {
            FirstViewModel = new FirstViewModel();
            Content = FirstViewModel;

            FirstViewCommand = ReactiveCommand.Create(
                () => Content = new FirstViewModel());

            SecondViewCommand = ReactiveCommand.Create(
                () => Content = new SecondViewModel());

            ThirdViewCommand = ReactiveCommand.Create(
                () => Content = new ThirdViewModel());

            LoadStreamsCommand = ReactiveCommand.Create(() =>
            {
                Content = FirstViewModel.Streams;
            });
        }

        public ICommand FirstViewCommand { get; }
        public ICommand SecondViewCommand { get; }
        public ICommand ThirdViewCommand { get; }
        public ICommand LoadStreamsCommand { get; }
        public FirstViewModel FirstViewModel { get; }

    }
}
