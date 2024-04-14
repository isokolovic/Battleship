using System;
using System.Drawing;
using Battleship.Model;

namespace View
{
    enum SquareButtonState
    {
        Initial,
        Ship,
        Eliminated,
        Missed,
        Hit,
        Sunken
    }
    class SquareButton : System.Windows.Forms.Button
    {
        private readonly int row;
        private readonly int column;
        private readonly Player player;
        private SquareButtonState state;

        public SquareButton(int row, int column, Player player, SquareButtonState state) : base()
        {
            this.row = row;
            this.column = column;
            this.player = player;
            if (player == Player.Human)
            {
                DisableButtonClick();
            }
            this.state = state;
            UpdateButtonColor();
        }

        public void UpdateButtonColor()
        {
            switch (state)
            {
                case SquareButtonState.Initial:
                    this.BackColor = Color.White;
                    if (player == Player.Computer)
                    {
                        EnableButtonClick();
                    }
                    return;
                case SquareButtonState.Ship:
                    this.BackColor = Color.Black;
                    return;
                case SquareButtonState.Eliminated:
                    this.BackColor = Color.LightGray;
                    break;
                case SquareButtonState.Missed:
                    this.BackColor = Color.Green;
                    break;
                case SquareButtonState.Hit:
                    this.BackColor = Color.OrangeRed;
                    break;
                case SquareButtonState.Sunken:
                    this.BackColor = Color.Red;
                    break;
                default:
                    this.BackColor = Color.White;
                    return;
            }
            if (player == Player.Computer)
            {
                DisableButtonClick();
            }
        }

        private void DisableButtonClick()
        {
            this.Enabled = false;
        }

        private void EnableButtonClick()
        {
            this.Enabled = true;
        }

        public int Row => row;
        public int Column => column;
        public Player Player => player;
        public SquareButtonState SquareButtonState {
            get => state;
            set { 
                state = value;
                UpdateButtonColor();
            } 
        }

    }
}
