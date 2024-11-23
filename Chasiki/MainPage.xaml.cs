using Microsoft.Maui.Controls;
using System;

namespace Chasiki {
    public partial class MainPage : ContentPage {
        private PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        private int HourTens = -1;
        private int HourUnits = -1;
        private int MinuteTens = -1;
        private int MinuteUnits = -1;
        private int SecondTens = -1;
        private int SecondUnits = -1;

        public MainPage() {
            InitializeComponent();
            StartTimer();
        }

        private async void StartTimer() {
            
            cancellationTokenSource = new CancellationTokenSource();
            
            timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

            try {
                while (await timer.WaitForNextTickAsync(cancellationTokenSource.Token)) {
                    UpdateTime();
                }
            }
            catch (OperationCanceledException) {
                Console.WriteLine("....");
            }
        }

        private void UpdateTime() {
            
            DateTime currentTime = DateTime.Now;
            
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;
 
            int hourTens = hours / 10;
            int hourUnits = hours % 10;

            int minuteTens = minutes / 10;
            int minuteUnits = minutes % 10;

            int secondTens = seconds / 10;
            int secondUnits = seconds % 10;


            if (hourTens != HourTens) {
                HourGrid1.Children.Clear();
                DisplayDigit(hourTens, HourGrid1);
                HourTens = hourTens;
            }

            if (hourUnits != HourUnits)
            {
                HourGrid2.Children.Clear();
                DisplayDigit(hourUnits, HourGrid2);
                HourUnits = hourUnits;
            }

            if (minuteTens != MinuteTens)
            {
                MinuteGrid1.Children.Clear();
                DisplayDigit(minuteTens, MinuteGrid1);
                MinuteTens = minuteTens;
            }

            if (minuteUnits != MinuteUnits)
            {
                MinuteGrid2.Children.Clear();
                DisplayDigit(minuteUnits, MinuteGrid2);
                MinuteUnits = minuteUnits;
            }

            if (secondTens != SecondTens)
            {
                SecondGrid1.Children.Clear();
                DisplayDigit(secondTens, SecondGrid1);
                SecondTens = secondTens;
            }

            if (secondUnits != SecondUnits)
            {
                SecondGrid2.Children.Clear();
                DisplayDigit(secondUnits, SecondGrid2);
                SecondUnits = secondUnits;
            }
       }

        private void DisplayDigit(int digit, Grid grid) {
            switch (digit) {
                case 0: DigitZero(grid); break;
                case 1: DigitOne(grid); break;
                case 2: DigitTwo(grid); break;
                case 3: DigitThree(grid); break;
                case 4: DigitFour(grid); break;
                case 5: DigitFive(grid); break;
                case 6: DigitSix(grid); break;
                case 7: DigitSeven(grid); break;
                case 8: DigitEight(grid); break;
                case 9: DigitNine(grid); break;
            }
        }

        class Rect : BoxView {
            public Rect() {
                Color = Colors.White;
            }
        }

        private void DigitZero(Grid grid) {
            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);
            grid.Add(new Rect(), 0, 3);
            grid.Add(new Rect(), 0, 4);
            grid.Add(new Rect(), 0, 5);

            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);
            grid.Add(new Rect(), 4, 3);
            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);
        }

        private void DigitOne(Grid grid) {
            grid.Add(new Rect(), 0, 2);
            grid.Add(new Rect(), 1, 1);

            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 2, 1);
            grid.Add(new Rect(), 2, 2);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 2, 4);
            grid.Add(new Rect(), 2, 5);
            grid.Add(new Rect(), 2, 6);

            grid.Add(new Rect(), 0, 6);
            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);
            grid.Add(new Rect(), 4, 6);
        }

        private void DigitTwo(Grid grid) {
            grid.Add(new Rect(), 0, 1);

            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);
            grid.Add(new Rect(), 3, 3);
            grid.Add(new Rect(), 2, 4);
            grid.Add(new Rect(), 1, 5);

            grid.Add(new Rect(), 0, 6);
            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);
            grid.Add(new Rect(), 4, 6);

        }

        private void DigitThree(Grid grid) {
            grid.Add(new Rect(), 0, 1);

            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);
            grid.Add(new Rect(), 3, 3);
            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);

            grid.Add(new Rect(), 0, 5);
        }

        private void DigitFour(Grid grid) {
            grid.Add(new Rect(), 0, 0);
            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);
            grid.Add(new Rect(), 0, 3);

            grid.Add(new Rect(), 1, 3);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 3, 3);

            grid.Add(new Rect(), 4, 0);
            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);
            grid.Add(new Rect(), 4, 3);
            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);
            grid.Add(new Rect(), 4, 6);

        }

        private void DigitFive(Grid grid) {
            grid.Add(new Rect(), 0, 0);
            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);
            grid.Add(new Rect(), 4, 0);

            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);
            grid.Add(new Rect(), 1, 3);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 3, 3);

            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);

            grid.Add(new Rect(), 0, 5);
        }

        private void DigitSix(Grid grid) {
            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);
            grid.Add(new Rect(), 0, 3);
            grid.Add(new Rect(), 0, 4);
            grid.Add(new Rect(), 0, 5);

            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);
            grid.Add(new Rect(), 4, 1);

            grid.Add(new Rect(), 1, 3);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 3, 3);

            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);
        }

        private void DigitSeven(Grid grid) {
            grid.Add(new Rect(), 0, 0);
            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);
            grid.Add(new Rect(), 4, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);

            grid.Add(new Rect(), 3, 3);
            grid.Add(new Rect(), 2, 4);
            grid.Add(new Rect(), 1, 5);
            grid.Add(new Rect(), 0, 6);
        }

        private void DigitEight(Grid grid) {
            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);

            grid.Add(new Rect(), 1, 3);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 3, 3);

            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);

            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);

            grid.Add(new Rect(), 0, 4);
            grid.Add(new Rect(), 0, 5);
        }

        private void DigitNine(Grid grid) {
            grid.Add(new Rect(), 1, 0);
            grid.Add(new Rect(), 2, 0);
            grid.Add(new Rect(), 3, 0);

            grid.Add(new Rect(), 4, 1);
            grid.Add(new Rect(), 4, 2);

            grid.Add(new Rect(), 1, 3);
            grid.Add(new Rect(), 2, 3);
            grid.Add(new Rect(), 3, 3);

            grid.Add(new Rect(), 0, 1);
            grid.Add(new Rect(), 0, 2);

            grid.Add(new Rect(), 4, 4);
            grid.Add(new Rect(), 4, 5);

            grid.Add(new Rect(), 1, 6);
            grid.Add(new Rect(), 2, 6);
            grid.Add(new Rect(), 3, 6);

            grid.Add(new Rect(), 0, 5);
        }
    }
}