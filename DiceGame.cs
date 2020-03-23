using System;    
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiddhiNandaniyaAssgt
{     /* Name: Nandaniya Siddhi Virabhai
          Student Number: C3325532
          Purpose of the code: Six of One (DICE GAME)
          This game play between two players or user can play with the Program */
    public partial class rbtndice_1 : Form
    {
        //Declaration of Image class, Random
        Image[] diceImage;
        int[] dice;
        int[] diceValues;
        Random r;
        int Score1 = 0;
        int Score2 = 0;
        int condition;
        // int turnCount = 0;
        int goalScore = 50;
        int TurnScore1 = 0;
        int TurnScore2 = 0;
        int DiceRolled = 0;
        int Roll;
        int number_of_dice = 0;
        int number_of_1s = 0;
        int[] dice_display;
        Boolean checkChange = false;

        public rbtndice_1()
        {
            InitializeComponent();
            //InitializeGame();
        }




        private void RollDice()
        {
            number_of_1s = 0;

            // 7 Dice Images // Intialization
            diceImage = new Image[7];
            diceImage[0] = Properties.Resources.dice_blank;
            diceImage[1] = Properties.Resources.dice_1;
            diceImage[2] = Properties.Resources.dice_2;
            diceImage[3] = Properties.Resources.dice_3;
            diceImage[4] = Properties.Resources.dice_4;
            diceImage[5] = Properties.Resources.dice_5;
            diceImage[6] = Properties.Resources.dice_6;

            r = new Random();

            //position (index of dice) {0,0,0,0,0,0} 
            // every index has some random number that we don't know (random)

            dice = new int[6] { 0, 0, 0, 0, 0, 0 };


            // dice length is 6

            // dice = new int[6];



            // dice_display = new int[6] { 0, 0, 0, 0, 0, 0 };



            //try and catch(exception) Incase some errors occurs in the try block // catch will define a block of code to be executed .

            if (rbtn_roll1.Checked)
            {
                number_of_dice = 1;
            }
            else if (rbtn_roll2.Checked)
            {
                number_of_dice = 2;
            }
            else if (rbtn_roll3.Checked)
            {
                number_of_dice = 3;
            }
            else if (rbtn_roll4.Checked)
            {
                number_of_dice = 4;
            }
            else if (rbtn_roll5.Checked)
            {
                number_of_dice = 5;
            }
            else if (rbtn_roll6.Checked)
            {
                number_of_dice = 6;
            }






            try
            {


                for (int n = 1; n <= 10; n++)
                {
                    for (int i = 0; i < number_of_dice; i++)  // increament of loop // condition is till 1 
                    {
                        dice[i] = r.Next(1, 7);
                        {
                            if (n == 10)
                            {


                                diceValues = new int[6] { dice[0], dice[1], dice[2], dice[3], dice[4], dice[5] };
                                int count1 = 0;

                                foreach (int dvalue in diceValues)

                                {
                                    if (dvalue == 1)
                                        count1++; ;

                                    lbl_p1_Dicerolled.Text = dvalue.ToString();
                                    //number_of_1s++;
                                }








                            }
                        }

                        picbxDice_1.Image = diceImage[dice[0]];  // Using pictureBox to show Image of Dice
                        picbxDice_2.Image = diceImage[dice[1]];             //when one dice will be rolled another 5 will ne invisible for the moment !
                        picbxDice_3.Image = diceImage[dice[2]];
                        picbxDice_4.Image = diceImage[dice[3]];
                        picbxDice_5.Image = diceImage[dice[4]];
                        picbxDice_6.Image = diceImage[dice[5]];
                        System.Threading.Thread.Sleep(100);
                        Application.DoEvents();

                    }
                }

                //diceValues = new int[6] { dice[0], dice[1], dice[2], dice[3], dice[4], dice[5] };
                //int count1 = 0;

                //foreach (int dvalue in diceValues)

                //{
                //    if (dvalue == 1)
                //        count1++; ;

                //    lbl_p1_Dicerolled.Text = dvalue.ToString();
                //    number_of_1s++;
                //}









                //if number of1s ==1 or 2 or.... apply conditions accordingly
                if (number_of_1s == 1)
                {
                    condition = 1;

                }
                if (number_of_1s == 2)
                {
                    condition = 2;

                }
                if (number_of_1s == 3)
                {
                    condition = 3;
                }
                if (number_of_1s >= 4)
                {
                    condition = 4;

                }
                else
                {
                    condition = 5;
                }


                if (condition == 1)
                {
                    TurnScore1 = 0;
                }
                if (condition == 2)
                {
                    Score1 = 0;
                }
                if (condition == 3)
                {
                    TurnScore1 = 0;
                }
                if (condition == 4)
                {
                    TurnScore1 = 0;
                }
                if (condition == 5)
                {
                    foreach (int element in dice)
                        TurnScore1 += element;
                }
                Score1 += TurnScore1;

                //   lbl_p1Score.Text = dice[i] + number_of_1s + " "+  Score1.ToString();


                lbl_p1Score.Text = number_of_1s + " " + Score1.ToString();

                //  lbl_p1Score.Text = Score1.ToString();








            }

            catch (Exception)
            {
                MessageBox.Show(" Sorry ! you haven't select any dice number ! please select number 1-6 !", "Error");
            }


        }


        private void btn_RollDice_Click(object sender, EventArgs e)
        {

            for (int n = 1; n <= 1; n++)
            {
                if (checkChange == true)
                {
                    rbtnPlayer1.Checked = true;
                    rbtnPlayer2.Checked = false;
                }
                else
                {
                    rbtnPlayer1.Checked = false;
                    rbtnPlayer2.Checked = true;
                }
                RollDice();
                if (checkChange == true) checkChange = false;
                else checkChange = true;
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
            if (rbtnPlayer1.Checked)
            {
                string p1 = Convert.ToString(tbx_name1.Text);
                lbl_Instructions.Text = "                   " + p1 + "'s turn ! please choose how many dice you want to roll !";
                if (p1 == "")
                    lbl_Instructions.Text = "                 Player 1's turn ! please choose how many dice you want to roll !";
            }
            if (rbtnPlayer2.Checked)
            {
                string p2 = Convert.ToString(tbx_name2.Text);
                lbl_Instructions.Text = "                 " + p2 + "'s turn ! please choose how many dice you want to roll !";

                if (p2 == "")
                    lbl_Instructions.Text = "                Player 2's turn ! please choose how many dice you want to roll !";
            }


        }

        private void rbtnPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlayerP.Checked == true)
            {
                lbl_Instructions.Text = "         Please Enter Player Name ! Then press start button to play game !";
                lbl_player1_Name.Enabled = true;
                lbl_player2_Name.Enabled = true;
                tbx_name1.Enabled = true;
                tbx_name2.Enabled = true;
                btn_Start.Enabled = true;
                players.Visible = true;
                Programgrp.Visible = false;
            }

        }

        private void rbtnProgramP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProgramP.Checked == true)
            {
                btn_Start.Enabled = true;
                players.Visible = false;
                Programgrp.Visible = true;
            }
        }

        private void rbtnPlayer1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkChange == true)
            {
                rbtnPlayer1.Checked = true;
                rbtnPlayer2.Checked = false;
            }
            else
            {
                rbtnPlayer1.Checked = false;
                rbtnPlayer2.Checked = true;
            }
        }


        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter Number ! 'How many dice you want to roll for the turn' ", "Follow Instructions");
        }


        private void btnS_Click(object sender, EventArgs e)
        {
            lbl_Instructions.Text = "                               Choose how many dice to roll !";
            New();
            players.Enabled = true;
            Btn_acp1.Enabled = true;
            Btn_acp2.Enabled = true;
            btn_RollDice.Enabled = true;
            Programgrp.Enabled = true;
        }

        private void btn_NewStart_Click(object sender, EventArgs e)
        {
            lbl_Instructions.Text = "Please choose one ! you want to play this game with program or player ? ";
            
            rbtnPlayer1.Checked = false;
            rbtnPlayer2.Checked = false;
            players.Enabled = false;
            Btn_acp1.Enabled = false;
            Btn_acp2.Enabled = false;
            rbtnPlayer1.Text = "Player 1";
            rbtnPlayer2.Text = "Player 2";
            btn_RollDice.Enabled = false;
            rbtnPlayerP.Checked = false;
            rbtnProgramP.Checked = false;
            lbl_player1_Name.Enabled = false;
            lbl_player2_Name.Enabled = false;
            btn_Start.Enabled = false;
            tbx_name1.Text = " ";
            tbx_name2.Text = " ";
            tbx_name1.Enabled = false;
            tbx_name2.Enabled = false;
         
            picbxDice_1.Image = diceImage[0];  // Using pictureBox to show Image of Dice
            picbxDice_2.Image = diceImage[0];             //when one dice will be rolled another 5 will ne invisible for the moment !
            picbxDice_3.Image = diceImage[0];
            picbxDice_4.Image = diceImage[0];
            picbxDice_5.Image = diceImage[0];
            picbxDice_6.Image = diceImage[0];
        }



        private void New()
            {
            
           string p1 = Convert.ToString(tbx_name1.Text);
            Btn_acp1.Text = p1;
            rbtnPlayer1.Text = p1;
            string p2 = Convert.ToString(tbx_name2.Text);
            Btn_acp2.Text = p2;
            rbtnPlayer2.Text = p2;
           if(p1 == "")
                rbtnPlayer1.Text = "Player 1";
            if (p2 == "")
                rbtnPlayer2.Text = "Player 2";
        }



    
    }










}
