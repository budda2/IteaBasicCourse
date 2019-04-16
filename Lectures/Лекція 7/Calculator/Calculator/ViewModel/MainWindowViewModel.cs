using Calculator.Commands;
using System;
using System.Data;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    public class MainWindowViewModel : PropertyChangedViewModel
    {
        public MainWindowViewModel()
        {
            OneCommand = new RelayCommand(param => HandleOneCommand());
            TwoCommand = new RelayCommand(param => HandleTwoCommand());
            ThreeCommand = new RelayCommand(param => HandleThreeCommand());
            FourCommand = new RelayCommand(param => HandleFourCommand());

        FiveCommand = new RelayCommand(param => Handlefivecommand());
            SixCommand = new RelayCommand(param => HandleSixCommand());
            SevenCommand = new RelayCommand(param => HandleSevencommand());
            EightCommand = new RelayCommand(param => HandleEightCommand());
            NineCommand = new RelayCommand(param => HandleNineCommand());
            ZeroCommand = new RelayCommand(param => HandleZerocommand());
            DotCommand = new RelayCommand(param => HandleDotCommand());
            PlusCommand = new RelayCommand(param => HandlePluscommand());
            MinusCommand = new RelayCommand(param => HandleMinusCommand());
            MultiplyCommand = new RelayCommand(param => HandleMultiplyCommand());
            DivideCommand = new RelayCommand(param => HAndleDivideCommand());
            CleanupCommand = new RelayCommand(param => HandlecleanupCommand());
            RemoveLasEnteredSymbolCommand = new RelayCommand(param => HandleRemoveLasEnteredSymbolCommand());
            CalculateCommand = new RelayCommand(param => HandleCalculateCommand());

        }

        private void HandleCalculateCommand()
        {
            if(!string.IsNullOrEmpty(Text))
            {
                try
                {
                    var dataTable = new DataTable();
                    Text = dataTable.Compute(Text, null).ToString();

                }
                catch
                {
                    Text = "Error, enter valid expression for calculation";
                }
            }
        }

        private void HandleRemoveLasEnteredSymbolCommand()
        {
            Text = Text.Substring(0, Text.Length - 1);
        }

        private void HandlecleanupCommand()
        {
            Text = "";
        }

        private void HAndleDivideCommand()
        {
            Text += "/";
        }

        private void HandleMultiplyCommand()
        {
            Text += "*";
        }

        private void HandleMinusCommand()
        {
            Text += "-";
        }

        private void HandlePluscommand()
        {
            Text += "+";
        }

        private void HandleDotCommand()
        {
            Text += ".";
        }

        private void HandleZerocommand()
        {
            Text += "0";
        }

        private void HandleNineCommand()
        {
            Text += "9";
        }

        private void HandleEightCommand()
        {
            Text += "8";
        }

        private void HandleSevencommand()
        {
            Text += "7";
        }

        private void HandleSixCommand()
        {
            Text += "6";
        }

        private void Handlefivecommand()
        {
            Text += "5";
        }

        private void HandleFourCommand()
        {
            Text += "4";
        }

        private void HandleTwoCommand()
        {
            Text += "2";
        }

        private void HandleOneCommand()
        {
            Text += "1";
        }

        private void HandleThreeCommand()
        {
            Text += 3.ToString();
        }

        private string _text = "";
        public string Text
        {
            get
            {
                return _text;
            }
            private set
            {
                _text = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand OneCommand { get; private set; }
        public ICommand TwoCommand { get; private set; }
        public ICommand ThreeCommand { get; private set; }
        public ICommand FourCommand { get; private set; }
        public ICommand FiveCommand { get; private set; }
        public ICommand SixCommand { get; private set; }
        public ICommand SevenCommand { get; private set; }
        public ICommand EightCommand { get; private set; }
        public ICommand NineCommand { get; private set; }
        public ICommand ZeroCommand { get; private set; }
        public ICommand DotCommand { get; private set; }
        public ICommand PlusCommand { get; private set; }
        public ICommand MinusCommand { get; private set; }
        public ICommand MultiplyCommand { get; private set; }
        public ICommand DivideCommand { get; private set; }
        public ICommand CleanupCommand { get; private set; }
        public ICommand CalculateCommand { get; private set; }
        public ICommand RemoveLasEnteredSymbolCommand { get; private set; }

        private void HandleSevenClicked()
        {
            Text += "7";
        }
    }
}
