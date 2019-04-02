using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ThiccGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        //saves the current results of box in game
        private MarkType[] mResults;
        private bool mPlayer1Turn;//true if player 1 (X) or player 2 turn (O)
        private bool mGameEnded;//true when player X/O wins 
        #endregion
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }
        #endregion

        private void NewGame()
        {
            mResults = new MarkType[9];
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            mPlayer1Turn = true;
            //inerate all buttons
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
            });
        }
    }
}
