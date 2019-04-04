using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplicationSet
{
    public partial class btnPreviousPage : Form
    {
        public btnPreviousPage()
        {
            InitializeComponent();
            
            GenerateCards();
            btnNewGame.Enabled = false;
            ShuffleDeck();

            for (int i = 0; i < cardList.Count; i++)
            {
                pictureWork();
                index++;
            }
            playerJump = 0;
            index = 0;



            //Subscribes the event of panel control
            pboxCanvas.Click += new System.EventHandler(this.pboxCanvas_Click);
            this.Controls.Add(this.pboxCanvas);

        }


        public void GameInitialization()
        {
            for (int i = 0; i < 9; i++)
            {
                xPoint[i] = 460;
                yPoint[i] = 182;

                if (i < 4)
                {
                    playerScores[i] = 0;
                }

            }

            //coordinates = null;
            xTarget = 0;
            yTarget = 0;
            indexValue = 1;
            index = 0;
            tick = 1;
            playerJump = -1;
            columnValue = 0;
            rowValue = 0;
            cardsInput = 0;
            inputtedImage = null;
            jumpLock = false;
            drawCard = false;
            clear = false;

            resizedCardImage = null;
            cardImage = null;
            xPointSelectedCards.Clear();
            cardImages.Clear();
            selectedCards.Clear();
            ImageArray = new Color[126, 95];
            cardList.Clear();
            listPoint = 0;

        }

        Point coordinates;
        double xTarget, yTarget, indexValue = 1;
        int index = 0;
        int width = 126;
        int height = 95;
        int tick = 1;
        int playerJump = -1;
        int columnValue, rowValue,cardsInput;
        string inputtedImage;
        bool jumpLock,drawCard, clear = false;

        bool gameLock = false;
        float jumpTimerTick = 0;
        int gameTimerTick = 0;
        int winningPlayerX = 0;
        int winningPlayerY = 365;
        double x1, x2, x3, y1, y2, y3;

        bool noJump = true;

        Bitmap resizedCardImage;
        Image cardImage;
        List <int> xPointSelectedCards = new List<int>();
        List<Bitmap> cardImages = new List<Bitmap>();
        List<int> playerScores = new List<int>() {0,0,0,0};
        List<double> xPoint = new List<double>() {460, 460, 460, 460, 460, 460, 460, 460, 460};
        List <double> yPoint = new List<double>() { 182, 182, 182, 182, 182, 182, 182, 182, 182};
        List<int> winningPlayers = new List<int>();

        List<int> selectedCards = new List<int>();
        Color[,] ImageArray = new Color[126,95];

        List<Card> cardList = new List<Card>();
        int listPoint = 0;

        
        public void resizeImage()
        {
            resizedCardImage = new Bitmap(cardImage, width, height);

        }

        private int findColumn(int coordinate)
        {
            if ((coordinate > 20) && (coordinate < 146))
            {
                return 1;
            } else if ((coordinate > 166) && (coordinate < 292))
            {
                return 2;
            } else if ((coordinate > 312) && (coordinate < 407))
            {
                return 3;
            } else
            {
                return 0;
            }
        }

        private int findRow (int coordinate)
        {
            if ((coordinate > 20) && (coordinate < 115))
            {
                return 1;
            }
            else if ((coordinate > 135) && (coordinate < 230))
            {
                return 2;
            }
            else if ((coordinate > 250) && (coordinate < 345))
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }


        //Finds Creates an array from the bitmap
        private void BitmapToArray()
        {

            for (int r = 0; r < width; r++)
            {
                for (int c = 0; c <height; c++)
                {

                    ImageArray[r, c] = resizedCardImage.GetPixel(r, c);
                }
            }
        }


        //Creates a bitmap from the array
        private void ArrayToBitmap()
        {

            for (int r = 0; r<width; r++)
            {
                for (int c = 0; c<height; c++)
                {
                    resizedCardImage.SetPixel(r, c, ImageArray[r, c]);
                }
            }

            cardImages.Add(resizedCardImage);

        }

        public string WinnerCheck(List<int> playerScores)
        {
            string returnText = "";
            int[] tempScore = new int[4];

            for(int i = 0; i < 3; i++)
            {
                tempScore[i] = playerScores[i];
            }

            Array.Sort(tempScore);

            if(tempScore[3] > tempScore[2])
            {
                returnText = Convert.ToString(playerScores.IndexOf(tempScore[0]));
            }
            else if(tempScore[3] == tempScore[2])
            {
                returnText = "A Tie!";
            }
            return returnText;

        }

        private void endGame()
        {

            string winners = "";

            for (int i = 0; i < playerScores.Count; i++)
            {
                if (playerScores[i] == playerScores.Max())
                {
                    winningPlayers.Add(i);
                }
            }

            for (int i = 0;  i < winningPlayers.Count; i++)
            {
                int playerNumber = 1;
                //winners = winners + "\r\n" + "Winning Player: " + WinnerCheck(playerScores);
                winners = winners + "\r\n" +  "Winner #" + (Convert.ToString(playerNumber)) + ": Player " + (winningPlayers[i] + 1).ToString();
                playerNumber = playerNumber + 1;
            }


            //Creates dialog if user wins
            DialogResult outputWin = MessageBox.Show("Congratulations"+ winners + "\r\n" + "Would You Like to Play Again?", "Winner Message for Winners", MessageBoxButtons.YesNo);

            switch(outputWin)
            {
                case DialogResult.Yes:

                    btnNewGame.PerformClick();

                break;

                case DialogResult.No:


                    Application.Exit();
                    break;

            }
        }

        private void ChangeColour ()
        {


            for (int r = 0; r < width; r++)
            {
                for (int c = 0; c <height; c++)
                {
                    Color colorArray = ImageArray[r, c];

                    if ((colorArray.R + colorArray.G +colorArray.B) != 765)
                    {
                        if (cardList[index].color == 1)
                        {
                            ImageArray[r, c] = Color.Red;
                        } else if (cardList[index].color == 2)
                        {
                            ImageArray[r, c] = Color.Green;
                        } else if (cardList[index].color == 3)
                        {
                            ImageArray[r, c] = Color.Purple;
                        }
                        
                    } else
                    {
                        ImageArray[r, c] = Color.White;
                    }    
                    
                }
            }

        }


        public void GenerateCards() // Generates the cards by looping through each characteristic
        {

            cardList.Clear();

            for(int a = 1; a <= 3; a++)
            {
                for(int b = 1; b <= 3; b++)
                {
                    for(int c = 1; c <= 3; c++)
                    {
                        for(int d = 1; d <= 3; d++)
                        {
                            Card tempCard = new Card();
                            tempCard.initializeCard(a, b, c, d);
                            cardList.Add(tempCard);
                            listPoint++;
                        }
                    }
                }
            }

            listPoint = 0;

        }


        public void ShuffleDeck() //Shuffles the deck into a randomized form
        {
            Random cardNumber = new Random();

            Card oldCard;

            for (int i = 0; i < 7; i++) // Done 7 times as mathematician Persi Diaconis found 7 times to be the necessary minimum to fully randomize a deck
            {
                listPoint = 0;
                for (int j = 0; j < cardList.Count; j++)
                {
                    int randomNumber = cardNumber.Next(0, 80); //Finds a random number within the bounds of the list

                    oldCard = cardList[listPoint]; //Goes to a current in the list of cards and assigns that as an oldcard
                    cardList[listPoint] = cardList[randomNumber]; //Goes to the current index in the list of cards and assigns that random card to it 
                    cardList[randomNumber] = oldCard; // Assigns the old card to the random place, swapping them

                    listPoint++;

                }
            }
        }


        private void identifyCard()
        {
            inputtedImage = cardList[index].shading.ToString() + cardList[index].number.ToString() + cardList[index].shape.ToString() + ".png";
            cardImage = Image.FromFile(inputtedImage);

            
            
        }


        private void pictureWork ()
        {
            identifyCard();
            resizeImage();
            BitmapToArray();
            ChangeColour();
            ArrayToBitmap();
        }


        private bool checkRepeat(int inputtedIndex)
        {
            if (xPointSelectedCards.Count > 0)
            {
                for (int i = 0; i < xPointSelectedCards.Count; i++)
                {
                    if (inputtedIndex == xPointSelectedCards[i])
                    {
                        return false;
                    }
                    
                }
            }
            return true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = true;

            if (indexValue < 81)
            {
                selectedCards.Clear();


                btnDeal.Enabled = false;
                
                if (index != 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        xPoint[i] = 460;
                        yPoint[i] = 182;
                    }

                    index++;

                }


                drawCard = true;


                gameLock = true;
                animationTimer.Start();

                System.Media.SoundPlayer shuffleSoundPlayer = new System.Media.SoundPlayer("ShuffleSound.wav");
                shuffleSoundPlayer.Play();


                this.Focus();
            }
            else
            {
                endGame();
            }
        }


        private void jumpTimer_Tick(object sender, EventArgs e)
        {
            jumpTimerTick += 1f;
            pboxCanvas.Invalidate();
        }


        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
            gameTimerTick += 1;

            int animationInterval = 200; //speed of animation in milliseconds
            double lerpLimit = Math.Floor(animationInterval / gameTimer.Interval + 0.5);

            xPoint[xPointSelectedCards[0]] = x1 * (1 - gameTimerTick / lerpLimit) + winningPlayerX * (gameTimerTick / lerpLimit);
            xPoint[xPointSelectedCards[1]] = x2 * (1 - gameTimerTick / lerpLimit) + winningPlayerX * (gameTimerTick / lerpLimit);
            xPoint[xPointSelectedCards[2]] = x3 * (1 - gameTimerTick / lerpLimit) + winningPlayerX * (gameTimerTick / lerpLimit);

            yPoint[xPointSelectedCards[0]] = y1 * (1 - gameTimerTick / lerpLimit) + winningPlayerY * (gameTimerTick / lerpLimit);
            yPoint[xPointSelectedCards[1]] = y2 * (1 - gameTimerTick / lerpLimit) + winningPlayerY * (gameTimerTick / lerpLimit);
            yPoint[xPointSelectedCards[2]] = y3 * (1 - gameTimerTick / lerpLimit) + winningPlayerY * (gameTimerTick / lerpLimit);

            pboxCanvas.Invalidate();

            if (gameTimerTick >= lerpLimit)
            {
                for (int i = 0; i < 3; i++)
                {
                    xPoint[xPointSelectedCards[i]] = 460;
                    yPoint[xPointSelectedCards[i]] = 182;
                }

                cardsInput = selectedCards.Count + cardsInput;

                selectedCards.Clear();
                xPointSelectedCards.Clear();

                gameLock = false;

                gameTimer.Stop();
                gameTimerTick = 0;

                if (cardsInput >8 )
                {
                    cardsInput = 0;
                    btnDeal.PerformClick();

                    if (indexValue > 80)
                    {
                        endGame();

                    }
                }

                jumpLock = false;
                playerJump = -1;
                               
            }
        }

        private async void formSetGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49 && (jumpLock == false))
            {
                winningPlayerX = -12;
                noJump = false;
                playerJump = 0;
                jumpLock = true;
                pboxCanvas.Invalidate();
                //selectedCards.Clear();
                await Task.Delay(1000);
                jumpLock = false;
            }
            else if (e.KeyChar == 50 && (jumpLock == false) && numberOfPlayers >= 2)
            {
                winningPlayerX = 107;
                noJump = false;
                playerJump = 1;
                jumpLock = true;
                pboxCanvas.Invalidate();
                //selectedCards.Clear();
                await Task.Delay(1000);
                jumpLock = false;
            }
            else if (e.KeyChar == 51 && (jumpLock == false) && numberOfPlayers >= 3)
            {
                winningPlayerX = 222;
                noJump = false;
                playerJump = 2;
                jumpLock = true;
                pboxCanvas.Invalidate();
                //selectedCards.Clear();
                await Task.Delay(1000);
                jumpLock = false;

            }
            else if (e.KeyChar == 52 && (jumpLock == false) && numberOfPlayers == 4)
            {
                winningPlayerX = 337;
                noJump = false;
                playerJump = 3;
                jumpLock = true;
                pboxCanvas.Invalidate();
                //SselectedCards.Clear();
                await Task.Delay(1000);
                jumpLock = false;
            }
        }


        private async void lockTimer_Tick(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            jumpLock = false;

        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {

        }

        int numberOfPlayers = 0;

        public void ChangeScene()
        {
            btn1Player.Enabled = false;
            btn1Player.Visible = false;
            btn2Player.Enabled = false;
            btn2Player.Visible = false;
            btn3Player.Enabled = false;
            btn3Player.Visible = false;
            btn4Player.Enabled = false;
            btn4Player.Visible = false;
            pboxPlayerSelect.Enabled = false;
            pboxPlayerSelect.Visible = false;
            btnPlayerLabel.Enabled = false;
            btnPlayerLabel.Visible = false;

            if (numberOfPlayers < 2)
            {
                label1.Visible = false;
                score2.Visible = false;

                label2.Visible = false;
                score3.Visible = false;

                label3.Visible = false;
                score4.Visible = false;

            }
            else if (numberOfPlayers < 3)
            {
                label2.Visible = false;
                score3.Visible = false;

                label3.Visible = false;
                score4.Visible = false;
            }
            else if (numberOfPlayers < 4)
            {
                label3.Visible = false;
                score4.Visible = false;
            }

        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            numberOfPlayers = 1;
            ChangeScene();
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            numberOfPlayers = 2;
            ChangeScene();
        }

        private void btn3Player_Click(object sender, EventArgs e)
        {
            numberOfPlayers = 3;
            ChangeScene();
        }

        private void btn4Player_Click(object sender, EventArgs e)
        {
            numberOfPlayers = 4;
            ChangeScene();
        }

        private void btnPlayerLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void formSetGame_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void btnTest_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ");
            
            
        }


        private void buttonRestart_Click(object sender, EventArgs e)
        {

        }


        public bool winCheck(int index1, int index2, int index3) //adds up each characteristic, win conditions have a sum divisible by 3 (3*3,2*3,1*3,1+2+3)
        {

            int colorSum = cardList[index1].color + cardList[index2].color + cardList[index3].color;
            int shadingSum = cardList[index1].shading + cardList[index2].shading + cardList[index3].shading;
            int numberSum = cardList[index1].number + cardList[index2].number + cardList[index3].number;
            int shapeSum = cardList[index1].shape + cardList[index2].shape + cardList[index3].shape;


            if ((colorSum%3 == 0) && (shadingSum%3 == 0) && (numberSum%3 == 0) && (shapeSum%3 ==0))
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    

        private void pboxCanvas_Click(object sender, EventArgs e)
        {                       

        }


        private  void pboxCanvas_Paint(object sender, PaintEventArgs e)
        {         

            //Graphics object
            Graphics g = e.Graphics;

            int intervalValue = Convert.ToInt32(Math.Ceiling(index / 9.0))-1;

            if (index == 0)
            {
                intervalValue = 0;
            }

            if (drawCard == true )
            {

                for (int i = 0; i < 9; i++)
                {

                    columnValue = Convert.ToInt32(indexValue) % 3;
                    rowValue = Convert.ToInt32(Math.Ceiling((indexValue) / 3.0)) % 3;

                    if (columnValue == 0)
                    {
                        columnValue = 3;
                    }

                    if (rowValue == 0)
                    {
                        rowValue = 3;
                    }

                    g.DrawImage(cardImages[(intervalValue*9)+i], Convert.ToInt32(xPoint[i]), Convert.ToInt32(yPoint[i]));
                    
                }
            }

            if (clear == true)
            {
                g.Clear(Color.Black);
                clear = false;
            }

            for (float i = 0; i < numberOfPlayers; i++)
            {
                float x = 90f * i + 25f * i + 10f;

                g.DrawRectangle(Pens.White, x, 395f, 90f, 40f);
            }

            string colorSwitch = "white"; //toggle between black and white
            Image player = Image.FromFile("PlayerBlack.png");

            Image playerYellow = Image.FromFile("PlayerYellow.png");

            if (colorSwitch == "black")
            {
                player = Image.FromFile("PlayerBlack.png");
            }
            else if (colorSwitch == "white")
            {
                player = Image.FromFile("PlayerWhite.png");
            }

            for (float i = 0; i < numberOfPlayers; i++)
            {

                if (playerJump != i)
                {
                    float x = 90f * i + 25f * (i + 1f) + 3f;
                    g.DrawImage(player, x, 370f, 60f, 60f);
                }
            }

            if (playerJump != -1 && !noJump)
            {
                jumpTimer.Start();
                float x = 90f * playerJump + 25f * (playerJump + 1f) + 3f;
                if ((400f - (-1.2f * jumpTimerTick) * (jumpTimerTick - 12f)) < 370f)
                {
                    g.DrawImage(playerYellow, x, 370f - (-2f * jumpTimerTick) * (jumpTimerTick - 12f), 60f, 60f);
                }
                else
                {
                    g.DrawImage(playerYellow, x, 370f, 60f, 60f);
                }

                if (jumpTimerTick > 12f)
                {
                    jumpTimer.Stop();
                    jumpTimerTick = 0;
                    noJump = true;
                }
            }
            else if(noJump)
            {
                float x = 90f * playerJump + 25f * (playerJump + 1f) + 3f;
                g.DrawImage(player, x, 370f, 60f, 60f);
            }

            
            
      
        }
         

        private void formSetGame_Load(object sender, EventArgs e)
        {

        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {         

            int columnValue, rowValue, intervalValue;

            intervalValue = Convert.ToInt32(Math.Ceiling(index / 9.0)) - 1;

            if (index == 0)
            {
                intervalValue = 0;
            }

            columnValue = Convert.ToInt32(indexValue % 3);
            rowValue = Convert.ToInt32(Math.Ceiling((indexValue) / 3.0)) % 3;

            if (columnValue == 0)
            {
                columnValue = 3;
            }

            if (rowValue == 0)
            {
                rowValue = 3;
            }

            xTarget = (126 * (columnValue - 1)) + (20 * columnValue);
            yTarget = (95 * (rowValue - 1)) + (20 * rowValue);

            xPoint[((3 * (rowValue - 1)) + columnValue) - 1] = (460-(((460-xTarget)/4.0)*tick));
            yPoint[((3 * (rowValue - 1)) + columnValue) - 1] = 182+ (((yTarget-182)/4.0)*tick);

            tick++;
            pboxCanvas.Invalidate();
                
            if (tick > 4)
            {
                tick = 0;

                lblCards.Text = "Number of Cards Dealt: " + indexValue;

                if (indexValue > 80)
                {
                    btnDeal.Text = "End Game";
                }

                indexValue++;
                index++;
              
                if (indexValue > ((intervalValue+1)*9))
                {
                    if(intervalValue != 0)
                    {
                        index--;
                    }
                    gameLock = false;
                    btnDeal.Enabled = true;
                    animationTimer.Stop();
                }

            }
         
        }


        private void pboxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameLock == false)
            {
                //Creates all variables needed
                string pboxCoordinates;
                string[] pboxSplittedCoordinates;

                int rowPoint, columnPoint, intervalValue, clickedIndex;

                intervalValue = Convert.ToInt32(Math.Floor(index / 9.0)) - 1;

                //Forms the coordinates relative to the panel
                coordinates = pboxCanvas.PointToClient(Cursor.Position);

                //Gets rid of useless aspects of coordinate string so it can be easily split
                pboxCoordinates = coordinates.ToString();
                pboxCoordinates = coordinates.ToString().Remove(pboxCoordinates.IndexOf("Y"), 2);
                pboxCoordinates = pboxCoordinates.ToString().Trim('{', 'X', '=', '}');

                //Splits the string into x and y coordinates
                pboxSplittedCoordinates = pboxCoordinates.Split(',');

                columnPoint = findColumn(Convert.ToInt32(pboxSplittedCoordinates[0]));
                rowPoint = findRow(Convert.ToInt32(pboxSplittedCoordinates[1]));

                clickedIndex = (intervalValue * 9) + (3 * (rowPoint - 1)) + columnPoint;

                
                if(playerJump != -1)
                {
                    if ((columnPoint != 0) && (rowPoint != 0) && (checkRepeat(((3 * (rowPoint - 1)) + columnPoint) - 1) == true))
                    {

                        selectedCards.Add(clickedIndex - 1);
                        xPointSelectedCards.Add(((3 * (rowPoint - 1)) + columnPoint) - 1);
                    }

                    if (selectedCards.Count >= 3 && gameLock == false)
                    {

                        if (winCheck(selectedCards[0], selectedCards[1], selectedCards[2]) == true)
                        {
                            gameLock = true;
                            x1 = xPoint[xPointSelectedCards[0]];
                            x2 = xPoint[xPointSelectedCards[1]];
                            x3 = xPoint[xPointSelectedCards[2]];
                            y1 = yPoint[xPointSelectedCards[0]];
                            y2 = yPoint[xPointSelectedCards[1]];
                            y3 = yPoint[xPointSelectedCards[2]];

                            if (playerJump != -1)
                            {
                                playerScores[playerJump] = playerScores[playerJump] + 1;
                            }

                            if (playerJump == 0)
                            {
                                score1.Text = Convert.ToString(Convert.ToInt32(score1.Text) + 1);
                            }
                            else if (playerJump == 1)
                            {
                                score2.Text = Convert.ToString(Convert.ToInt32(score2.Text) + 1);
                            }
                            else if (playerJump == 2)
                            {
                                score3.Text = Convert.ToString(Convert.ToInt32(score3.Text) + 1);
                            }
                            else if (playerJump == 3)
                            {
                                score4.Text = Convert.ToString(Convert.ToInt32(score4.Text) + 1);
                            }

                            noJump = true;

                            gameTimer.Start();

                        }
                        else
                        {
                            MessageBox.Show("NO SET!");
                            selectedCards.Clear();
                            xPointSelectedCards.Clear();
                        }

                    }
                }

            }
        }
    }


    public class Card //creates a class for each card
    {
        public int color, shading, number, shape;

        public void initializeCard(int a, int b, int c, int d) //method to easily instantiate class with complete parameters
        {                                                      // Each number represent a characteristic
            color = a;
            shading = b;
            number = c;
            shape = d;
        }

    }

}
