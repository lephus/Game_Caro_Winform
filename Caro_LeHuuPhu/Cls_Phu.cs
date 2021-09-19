using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_LeHuuPhu
{
    class Cls_Phu
    {
        public Stack<InformationPlayer> undoStack; 
        private int width_button = 40;
        private int height_button = 40;
        private int width_board = 15;
        private int height_board = 14;
        private string player = "";
        private string namePlayer = "_____";
        private int numberPlayer = 1;
        private Color _color = Color.Red;
        public List<List<Button>> matrixButton;
        private bool isStart = false;
        public int TIME_DOWN_INTERVAL = 10;
        public int TIME_DOWM_END_GAME = 10*1000;//20s
        public int TIME_STEP_PROCESSBAR = 10;

        public int TotalNumberGame = 0;
        public int TimerPlay1 = 0;
        public int TimerPlay2 = 0;
        public int UndoPlay1 = 0;
        public int UndoPlay2 = 0;
        public int WinPlay1 = 0;
        public int WinPlay2 = 0;
        public string stringWinPlay1 = "00:00";
        public string stringWinPlay2 = "00:00";
        public int getWidthBoard()
        {
            return width_board;
        }
        public int getHeightBoard()
        {
            return height_board;
        }
        public int getWidthButton()
        {
            return width_button;
        }
        public int getHeightButton()
        {
            return height_button;
        }
        public string getPlayer()
        {
            setPlayer();
            return player;
        }
        public string getNamePlayerContinue()
        {
            return namePlayer;
        }
        public void setPlayer()
        {
            if(numberPlayer == 0)
            {
                player = "_____";
                return;
            }
            if (numberPlayer == 1)
            {
                numberPlayer = 2;
                player = "X";
                namePlayer = "PLAY 2";
                _color = Color.Red;
                return;
            }
            if (numberPlayer == 2)
            {
                numberPlayer = 1;
                player = "O";
                namePlayer = "PLAY 1";
                _color = Color.Blue;
                return;
            }
        }
        public int getNumberPlayer()
        {
            return numberPlayer;
        }
        public Color getColor()
        {
            return _color;
        }

        public bool getIsStart()
        {
            return isStart;
        }
        public void Start()
        {
            for (int i = 0; i < getHeightBoard(); i++)
            {
                for (int j = 0; j < getWidthBoard(); j++)
                {
                    matrixButton[i][j].Text = "";
                    matrixButton[i][j].BackColor = Color.White;
                }
            }
            TotalNumberGame += 1;
            numberPlayer = 1;
            namePlayer = "PLAY 1";
            isStart = true;
        }
        public void actionClickButtonClear()
        {
            for (int i = 0; i < getHeightBoard(); i++)
            {
                for (int j = 0; j < getWidthBoard(); j++)
                {
                    matrixButton[i][j].Text = "";
                    matrixButton[i][j].BackColor = Color.White;
                }
            }
        }

        public bool checkIsEndGame(Button btn)
        {
            return checkGameWinHorizontal(btn) || checkGameWinVertiCal(btn) || checkGameWinDiagonalLineMain(btn) || checkGameWinDiagonalLineSub(btn);
        }


        public void endGame()
        {
            undoStack.Clear();
            string namePlayerWin = "PLAY 1";
            isStart = false;
            if (numberPlayer == 1)
            {
                namePlayerWin = "PLAY 2";
                WinPlay2 += 1;
            }
            else
            {
                WinPlay1 += 1;
            }
            MessageBox.Show(namePlayerWin + " Win Game!", "Kết thúc game");
        }

        public void outOfTime()
        {
            undoStack.Clear();
            isStart = false;
            string Winer = getNamePlayerContinue().Equals("PLAY 2") ? "PLAY 1" : "PLAY 2";
            if(Winer.Equals("PLAY 2"))
            {
                WinPlay2 += 1;
            }
            else
            {
                WinPlay1 += 1;
            }
            MessageBox.Show(getNamePlayerContinue() + " đã quá thời gian! \n => "+ Winer + " Win Game.", "Hết thời gian");
        }

        public bool checkGameWinHorizontal(Button btn)
        {
            // hang ngang
            Point p = getPointButton(btn);
            //Console.WriteLine(p);
            int countChessLeft = 0;
            int countChessRight = 0;
            for(int i = p.Y; i>=0; i--)
            {
                if(btn.Text == matrixButton[p.X][i].Text)
                {
                    countChessLeft++;
                }
                else
                {
                    break;
                }
            }
            for (int i = p.Y+1; i < width_board ; i++)
            {
                if (btn.Text == matrixButton[p.X][i].Text)
                {
                    countChessRight++;
                }
                else
                {
                    break;
                }
            }
            //Console.WriteLine(countChessLeft + countChessRight);
            return countChessLeft+countChessRight >= 5;
        }
        public bool checkGameWinVertiCal(Button btn)
        {
            // hang doc
            Point p = getPointButton(btn);
            //Console.WriteLine(p);

            int countChessTop = 0;
            int countChessBot = 0;
            for (int i = p.X; i >= 0; i--)
            {
                if (btn.Text == matrixButton[i][p.Y].Text)
                {
                    countChessTop++;
                }
                else
                {
                    break;
                }
            }
            for (int i = p.X + 1; i < height_board ; i++)
            {
                if (btn.Text == matrixButton[i][p.Y].Text)
                {
                    countChessBot++;
                }
                else
                {
                    break;
                }
            }
            //Console.WriteLine(countChessTop + countChessBot);
            return countChessTop + countChessBot >= 5;

        }
        public bool checkGameWinDiagonalLineMain(Button btn)
        {
            // cheo chinh
            Point p = getPointButton(btn);
            Console.WriteLine(p);
            int countChessDiagonalLineTop = 0;
            int countChessDiagonalLineBot = 0;
            for (int i = 0; i < height_board - p.X; i++)
            {
                try
                {
                    if (btn.Text == matrixButton[p.X + i][p.Y - i].Text)
                    {
                        countChessDiagonalLineTop++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    // index out of
                    break;
                }
            }
            for (int i = 1; i < width_board - p.Y; i++)
            {
                try
                {
                    if (btn.Text == matrixButton[p.X - i][p.Y + i].Text)
                    {
                        countChessDiagonalLineBot++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch(Exception e)
                {
                    // index out of
                    break;
                }
            }
            Console.WriteLine(countChessDiagonalLineTop + countChessDiagonalLineBot);
            return countChessDiagonalLineTop + countChessDiagonalLineBot >= 5;

        }
        public bool checkGameWinDiagonalLineSub(Button btn)
        {
            // cheo phu
            Point p = getPointButton(btn);
            Console.WriteLine(p);
            int countChessDiagonalLineTop = 0;
            int countChessDiagonalLineBot = 0;
            for (int i = 0; i < height_board - p.X; i++)
            {
                try
                {
                    if (btn.Text == matrixButton[p.X - i][p.Y - i].Text)
                    {
                        countChessDiagonalLineTop++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    // index out of
                    break;
                }
            }
            for (int i = 1; i < width_board - p.Y; i++)
            {
                try
                {
                    if (btn.Text == matrixButton[p.X + i][p.Y + i].Text)
                    {
                        countChessDiagonalLineBot++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    // index out of
                    break;
                }
            }
            Console.WriteLine(countChessDiagonalLineTop + countChessDiagonalLineBot);
            return countChessDiagonalLineTop + countChessDiagonalLineBot >= 5;

        }
      
        public Point getPointButton(Button btn)
        {
            Point point         = new Point();
            int Vertical        = Convert.ToInt32(btn.Tag); // hang doc
            int Horizontal      = matrixButton[Vertical].IndexOf(btn); // hang ngang
            point.X             = Vertical;
            point.Y             = Horizontal;
            return point;
        }

        public string actionUndoGame(string chessPlayer)
        {
            try
            {
                // check player undo
                InformationPlayer CheckInformation = undoStack.Peek();
                Button TmpButton = matrixButton[CheckInformation.Point.X][CheckInformation.Point.Y];
                if (TmpButton.Text != chessPlayer)
                {
                    return "Nước cờ của đối thủ, bạn không được phép đi lại!";
                }
                InformationPlayer information = undoStack.Pop();
                Console.WriteLine(information.Point);
                matrixButton[information.Point.X][information.Point.Y].Text = "";
                matrixButton[information.Point.X][information.Point.Y].BackColor = Color.White;
                numberPlayer = information.CurrentPlayer == 1 ? 2 : 1;
                if (chessPlayer.Equals("X"))
                {
                    UndoPlay1 += 1;
                }
                else
                {
                    UndoPlay2 += 1;
                }
                return "ok";
            }
            catch(Exception e)
            {
                return "Bạn không được phép đi lại!";
            }
        }

        public void ShowLineChessWin(Button btn)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            if (checkGameWinHorizontal(btn))
            {
                // hang ngang
                Point p = getPointButton(btn);
                for (int i = p.Y; i >= 0; i--)
                {
                    if (btn.Text == matrixButton[p.X][i].Text)
                    {
                        matrixButton[p.X][i].BackColor = randomColor;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = p.Y + 1; i < width_board; i++)
                {
                    if (btn.Text == matrixButton[p.X][i].Text)
                    {
                        matrixButton[p.X][i].BackColor = randomColor;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (checkGameWinVertiCal(btn))
            {
                // hang doc
                Point p = getPointButton(btn);
                //Console.WriteLine(p);
                for (int i = p.X; i >= 0; i--)
                {
                    if (btn.Text == matrixButton[i][p.Y].Text)
                    {
                        matrixButton[i][p.Y].BackColor = randomColor;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = p.X + 1; i < height_board; i++)
                {
                    if (btn.Text == matrixButton[i][p.Y].Text)
                    {
                        matrixButton[i][p.Y].BackColor = randomColor;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (checkGameWinDiagonalLineMain(btn))
            {
                // cheo chinh
                Point p = getPointButton(btn);
                Console.WriteLine(p);
                for (int i = 0; i < height_board - p.X; i++)
                {
                    try
                    {
                        if (btn.Text == matrixButton[p.X + i][p.Y - i].Text)
                        {
                            matrixButton[p.X + i][p.Y - i].BackColor = randomColor;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        // index out of
                        break;
                    }
                }
                for (int i = 1; i < width_board - p.Y; i++)
                {
                    try
                    {
                        if (btn.Text == matrixButton[p.X - i][p.Y + i].Text)
                        {
                            matrixButton[p.X - i][p.Y + i].BackColor = randomColor;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        // index out of
                        break;
                    }
                }
            }
            if (checkGameWinDiagonalLineSub(btn))
            {
                // cheo phu
                Point p = getPointButton(btn);
                Console.WriteLine(p);
                for (int i = 0; i < height_board - p.X; i++)
                {
                    try
                    {
                        if (btn.Text == matrixButton[p.X - i][p.Y - i].Text)
                        {
                            matrixButton[p.X - i][p.Y - i].BackColor = randomColor;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        // index out of
                        break;
                    }
                }
                for (int i = 1; i < width_board - p.Y; i++)
                {
                    try
                    {
                        if (btn.Text == matrixButton[p.X + i][p.Y + i].Text)
                        {
                            matrixButton[p.X + i][p.Y + i].BackColor = randomColor;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        // index out of
                        break;
                    }
                }
            }
        }

        public void CountTime(int time)
        {
            if(numberPlayer == 1)
            {
                TimerPlay1 += time;
                float t = (float)TimerPlay1 / 1000;
                Console.WriteLine("Second timer: " + t);
                stringWinPlay1 =  t.ToString();
            }
            else
            {
                TimerPlay2 += time;
                float t = (float)TimerPlay2 / 1000;
                Console.WriteLine("Second timer: "+t);
                stringWinPlay2 = t.ToString();
            }
        }
    }


    public class InformationPlayer
    {
        private Point point;
        private int currentPlayer;
        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        public InformationPlayer(Point p, int currentPlayer)
        {
            this.point = p;
            this.currentPlayer = currentPlayer;
        }
    }
}
