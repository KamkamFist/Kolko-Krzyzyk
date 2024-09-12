using System.Numerics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        //aktywny gracz
        char activePlayer = 'O';

        void SwitchPlayer()
        {
            if (activePlayer == 'O')
            {
                activePlayer = 'X';
            }
            else
            {
                activePlayer = 'O';
            }
        }

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ruch gracza: " + activePlayer;
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            //stwórz projekt klasy button i rzutuj z niego zawartosc sender
            Button button = (Button)sender;

            if (button.Text != "")
            {
                return;
            }

            //wyswietl tekst z przycisku
            button.Text = activePlayer.ToString();
            SwitchPlayer();

            label1.Text = "Ruch gracza: " + activePlayer;

            CheckResult();
        }

        void DisplayResult(string player)
        {
            var result = MessageBox.Show("Wygra gracz: " + player, "Kółko i Krzyżyk", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Retry)
            {
                TopLeft.Text = String.Empty;
                TopCenter.Text = String.Empty;
                TopRight.Text = String.Empty;
                CenterLeft.Text = String.Empty;
                CenterCenter.Text = String.Empty;
                CenterRight.Text = String.Empty;
                BottomLeft.Text = String.Empty;
                BottomCenter.Text = String.Empty;
                BottomRight.Text = String.Empty;

                activePlayer = 'O';
            }
            else
            {
                Application.Exit();
            }
        }

        void CheckResult()
        {
            {

                if (TopLeft.Text != String.Empty &&
                    TopCenter.Text != String.Empty &&
                    TopRight.Text != String.Empty)
                {

                    if (TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                    {
                        DisplayResult(TopLeft.Text);
                    }
                }

                if (CenterLeft.Text != String.Empty &&
                    CenterCenter.Text != String.Empty &&
                    CenterRight.Text != String.Empty)
                {

                    if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                    {

                        DisplayResult(CenterLeft.Text);
                    }
                }
                if (BottomLeft.Text != String.Empty &&
                    BottomCenter.Text != String.Empty &&
                    BottomRight.Text != String.Empty)
                {

                    if (BottomLeft.Text == BottomCenter.Text && BottomCenter.Text == BottomRight.Text)
                    {

                        DisplayResult(BottomCenter.Text);
                    }
                }
                if (TopLeft.Text != String.Empty &&
                    CenterLeft.Text != String.Empty &&
                    BottomLeft.Text != String.Empty)
                {

                    if (TopLeft.Text == CenterLeft.Text && CenterLeft.Text == BottomLeft.Text)
                    {

                        DisplayResult(CenterLeft.Text);
                    }
                }
                if (TopCenter.Text != String.Empty &&
                    CenterCenter.Text != String.Empty &&
                    BottomCenter.Text != String.Empty)
                {

                    if (TopCenter.Text == CenterCenter.Text && CenterCenter.Text == BottomCenter.Text)
                    {

                        DisplayResult(CenterCenter.Text);
                    }
                }
                if (TopRight.Text != String.Empty &&
                    CenterRight.Text != String.Empty &&
                    BottomRight.Text != String.Empty)
                {

                    if (TopRight.Text == CenterRight.Text && CenterRight.Text == BottomRight.Text)
                    {

                        DisplayResult(CenterRight.Text);
                    }
                }
                if (TopLeft.Text != String.Empty &&
                    CenterCenter.Text != String.Empty &&
                    BottomRight.Text != String.Empty)
                {

                    if (TopLeft.Text == CenterCenter.Text && CenterCenter.Text == BottomRight.Text)
                    {

                        DisplayResult(CenterCenter.Text);
                    }
                }
                if (TopRight.Text != String.Empty &&
                    CenterCenter.Text != String.Empty &&
                    BottomLeft.Text != String.Empty)
                {

                    if (TopRight.Text == CenterCenter.Text && CenterCenter.Text == BottomLeft.Text)
                    {

                        DisplayResult(CenterCenter.Text);
                    }
                }
                if (TopLeft.Text != String.Empty &&
                    TopCenter.Text != String.Empty &&
                    TopRight.Text != String.Empty &&
                    CenterLeft.Text != String.Empty &&
                    CenterCenter.Text != String.Empty &&
                    CenterRight.Text != String.Empty &&
                    BottomLeft.Text != String.Empty &&
                    BottomCenter.Text != String.Empty &&
                    BottomRight.Text != String.Empty)
                {

                    var result = MessageBox.Show("Pat/Remis", "Kółko i Krzyżyk", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {
                        TopLeft.Text = String.Empty;
                        TopCenter.Text = String.Empty;
                        TopRight.Text = String.Empty;
                        CenterLeft.Text = String.Empty;
                        CenterCenter.Text = String.Empty;
                        CenterRight.Text = String.Empty;
                        BottomLeft.Text = String.Empty;
                        BottomCenter.Text = String.Empty;
                        BottomRight.Text = String.Empty;

                        activePlayer = 'O';
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
