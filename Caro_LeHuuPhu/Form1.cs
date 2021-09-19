using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_LeHuuPhu
{
    public partial class Form1 : Form
    {
        Cls_Phu cls_Phu = new Cls_Phu();
        Button ButtonWinGame;
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();

            progressBarCountDownTmer.Maximum = cls_Phu.TIME_DOWM_END_GAME;
            progressBarCountDownTmer.Minimum = 0;
            progressBarCountDownTmer.Value = 0;
            progressBarCountDownTmer.Step = cls_Phu.TIME_STEP_PROCESSBAR;
            timerCountDownTimer.Interval = cls_Phu.TIME_DOWN_INTERVAL;
            timerHightLine.Interval = 500;
        }
        void DrawChessBoard()
        {
            cls_Phu.matrixButton = new List<List<Button>>();
            cls_Phu.undoStack = new Stack<InformationPlayer>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cls_Phu.getHeightBoard(); i++)
            {
                cls_Phu.matrixButton.Add(new List<Button>());
                for (int j = 0; j < cls_Phu.getWidthBoard(); j++)
                {
                    Button btn = new Button()
                    {
                        Tag = i.ToString(),
                        Width = cls_Phu.getWidthButton(),
                        Height = cls_Phu.getHeightButton(),
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                    btn.Click += btnActionEvenClick;
                    panelChessBoard.Controls.Add(btn);
                    oldButton = btn;
                    cls_Phu.matrixButton[i].Add(btn);
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cls_Phu.getHeightButton());
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void btnActionEvenClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if ( button.Text.Equals("X") || button.Text.Equals("O")){
                return;
            }
            if (cls_Phu.getIsStart())
            {
                Console.WriteLine("Timer: " + progressBarCountDownTmer.Value);
                cls_Phu.CountTime(progressBarCountDownTmer.Value);
                SetInformationPlayer();
                restartTimerDownGame();
                int numberPlayer = cls_Phu.getNumberPlayer();
                cls_Phu.undoStack.Push(new InformationPlayer(cls_Phu.getPointButton(button), numberPlayer));
                button.Text = cls_Phu.getPlayer();
                button.BackColor = cls_Phu.getColor();
                button.ForeColor = Color.Black;
                labelPlayer.Text = cls_Phu.getNamePlayerContinue();
                labelPlayer.ForeColor = button.BackColor == Color.Red ? Color.Blue : Color.Red;
                buttonToPlayer.Text = button.Text.Equals("X") ? "O" : "X";
                buttonToPlayer.BackColor = button.BackColor == Color.Red ? Color.Blue : Color.Red;

                if (cls_Phu.checkIsEndGame(button))
                {
                    timerHightLine.Start();

                    ButtonWinGame = button;
                    timerCountDownTimer.Stop();

                    progressBarCountDownTmer.Value = 0;
                    labelPlayer.Text = "_____";
                    labelPlayer.ForeColor = Color.Blue;
                    buttonToPlayer.Text = "";
                    buttonToPlayer.BackColor = Color.White;
                    cls_Phu.endGame();
                    SetInformationPlayer();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Start để bắt đầu!", "Thông báo");
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerHightLine.Stop();

            cls_Phu.Start();

            SetInformationPlayer();

            labelPlayer.Text = cls_Phu.getNamePlayerContinue();
            labelPlayer.ForeColor = Color.Red;
            buttonToPlayer.Text = "X";
            buttonToPlayer.BackColor = Color.Red;
            restartTimerDownGame();
        }

        private void timerCountDownTimer_Tick(object sender, EventArgs e)
        {
            progressBarCountDownTmer.PerformStep();
            if (progressBarCountDownTmer.Value == cls_Phu.TIME_DOWM_END_GAME)
            {
                timerCountDownTimer.Stop();
                cls_Phu.outOfTime();
                SetInformationPlayer();
            }
        }

        private void restartTimerDownGame()
        {
            timerCountDownTimer.Stop();
            progressBarCountDownTmer.Maximum = cls_Phu.TIME_DOWM_END_GAME;
            progressBarCountDownTmer.Minimum = 0;
            progressBarCountDownTmer.Value = 0;
            progressBarCountDownTmer.Step = cls_Phu.TIME_STEP_PROCESSBAR;
            timerCountDownTimer.Interval = cls_Phu.TIME_DOWN_INTERVAL;
            timerCountDownTimer.Start();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (cls_Phu.getIsStart())
            {
                timerCountDownTimer.Stop();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa bàn cờ?", "Thông báo", buttons);
                if (result == DialogResult.Yes)
                {
                    restartTimerDownGame();
                    cls_Phu.actionClickButtonClear();
                }
                timerCountDownTimer.Start();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Start để bắt đầu!", "Thông báo");
            }
        }

        private void buttonUndoPlay1_Click(object sender, EventArgs e)
        {
            restartTimerDownGame();
            string checkUndu = cls_Phu.actionUndoGame("X");
            if (checkUndu.Equals("ok"))
            {
                Button button = sender as Button;
                cls_Phu.getPlayer();
                labelPlayer.Text = cls_Phu.getNamePlayerContinue();
                labelPlayer.ForeColor = cls_Phu.getNamePlayerContinue().Equals("PLAY 2") ? Color.Blue : Color.Red;
                buttonToPlayer.Text = cls_Phu.getNamePlayerContinue().Equals("PLAY 1") ? "X" : "O";
                buttonToPlayer.BackColor = cls_Phu.getNamePlayerContinue().Equals("PLAY 2") ? Color.Blue : Color.Red;
                restartTimerDownGame();
                SetInformationPlayer();
            }
            else
            {
                ShowMessager("ERROR", checkUndu);
            }
        }

        private void buttonUndoPlay2_Click(object sender, EventArgs e)
        {
            restartTimerDownGame();
            string checkUndu = cls_Phu.actionUndoGame("O");
            if (checkUndu.Equals("ok"))
            {
                Button button = sender as Button;
                cls_Phu.getPlayer();
                labelPlayer.Text = cls_Phu.getNamePlayerContinue();
                labelPlayer.ForeColor = cls_Phu.getNamePlayerContinue().Equals("PLAY 2") ? Color.Blue : Color.Red;
                buttonToPlayer.Text = cls_Phu.getNamePlayerContinue().Equals("PLAY 1") ? "X" : "O";
                buttonToPlayer.BackColor = cls_Phu.getNamePlayerContinue().Equals("PLAY 2") ? Color.Blue : Color.Red;
                restartTimerDownGame();
                SetInformationPlayer();
            }
            else
            {
                ShowMessager("ERROR", checkUndu);
            }
        }
        public void ShowMessager(string title, string message)
        {
            timerCountDownTimer.Stop();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                if(! message.Equals("Bạn không được phép đi lại!"))
                {
                    timerCountDownTimer.Start();
                }
            }
        }
        public void SetInformationPlayer() 
        {
            buttonWinPlay1.Text = "Win "+cls_Phu.WinPlay1 + "/" + cls_Phu.TotalNumberGame;
            buttonWinPlay2.Text = "Win "+cls_Phu.WinPlay2 + "/" + cls_Phu.TotalNumberGame;

            buttonUndoPlay1.Text = "Undo: "+cls_Phu.UndoPlay1.ToString();
            buttonUndoPlay2.Text = "Undo: "+cls_Phu.UndoPlay2.ToString();

            buttonTimePlay1.Text = "Timer " + cls_Phu.stringWinPlay1;
            buttonTimePlay2.Text = "Timer " + cls_Phu.stringWinPlay2;
        }

        private void timerHightLine_Tick(object sender, EventArgs e)
        {
            cls_Phu.ShowLineChessWin(ButtonWinGame);
        }
    }
}
