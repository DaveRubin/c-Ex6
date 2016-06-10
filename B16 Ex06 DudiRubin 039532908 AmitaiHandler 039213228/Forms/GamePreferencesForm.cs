using System;
using System.Drawing;
using System.Windows.Forms;

namespace B16_Ex05.Forms
{

    public partial class GamePreferencesForm : Form
    {
        private readonly int r_minSizeVal;
        private readonly int r_maxSizeVal;

        public MainMenuGameSettingsArgs GameSettings
        {
            get
            {
                return new MainMenuGameSettingsArgs
                           {
                               Columns = (int)NumericCols.Value,
                               Rows = (int)NumericRows.Value,
                               Player1Name = TextboxPlayer1Name.Text,
                               Player2Name = TextboxPlayer2Name.Text
                           };
            }
        }

        public GamePreferencesForm(int i_MinSizeValue, int i_MaxSizeValue)
        {
            r_minSizeVal = i_MinSizeValue;
            r_maxSizeVal = i_MaxSizeValue;
            InitializeComponent();
            SetNumericLimits();
            AddAcceptButtonHandler();
        }

        private void AddAcceptButtonHandler()
        {
            ButtonOk.Click += ButtonStart_Click;
        }

        /// <summary>
        /// When ButtonStart is clicked set DialogRresult to OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SetNumericLimits()
        {
            NumericCols.Minimum = r_minSizeVal;
            NumericCols.Maximum = r_maxSizeVal;
            NumericRows.Minimum = r_minSizeVal;
            NumericRows.Maximum = r_maxSizeVal;
        }
    }
}