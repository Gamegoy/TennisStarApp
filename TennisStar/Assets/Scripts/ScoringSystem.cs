using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public bool isBallInPlay;
    public bool isPointWon;
    public bool isPointLost;
    public bool isDeuce;
    public bool isGame;
    public bool isSet;
    public bool isTiebreak;
    public bool isDifferenceOfTwo;
    public bool isDifferenceOfTwoInTiebreak;

    [SerializeField]
    TMP_Text scoreText;
    [SerializeField]
    TMP_Text opponentScoreText;
    [SerializeField]
    TMP_Text gameScoreText;
    [SerializeField]
    TMP_Text opponentGameScoreText;
    [SerializeField]
    TMP_Text setScoreText;
    [SerializeField]
    TMP_Text opponentSetScoreText;
    [SerializeField]
    List<string> scores;
    [SerializeField]
    void Start()
    {
        isBallInPlay = false;
        isPointWon = false;
        isPointLost = false;
        isDeuce = false;
        isSet = false;
        isTiebreak = false;
        isDifferenceOfTwo = false;
        gameScoreText.text = "0";
        opponentGameScoreText.text = "0";
    }


    void Update()
    {
        if (IsTieBreak(isTiebreak))
        {
            Tiebreaker();
        }
        else
        {
            GameScore();
        }
        if (IsSet(isSet))
        {
            AddSet();
        }
        if (Input.GetKeyDown(KeyCode.W))
            isPointWon = true;
        else
            isPointWon = false;
        if (Input.GetKeyDown(KeyCode.Space))
            isPointLost = true;
        else
            isPointLost = false;
    }
    public void AddGame()
    {
        if (isGame && isPointWon)
        {            
            int gameScore = int.Parse(gameScoreText.text);
            gameScore += 1;
            gameScoreText.text = gameScore.ToString();
            ResetScore(scoreText,opponentScoreText);
        }
        if (isGame && isPointLost)
        {
            int gameScore = int.Parse(opponentGameScoreText.text);
            gameScore += 1;
            opponentGameScoreText.text = gameScore.ToString();
            ResetScore(scoreText, opponentScoreText);
        }

    }
   public void GameScore()
    {
        if (isBallInPlay)
            return;
         
        if (isPointWon)
        {
            if (scoreText.text == scores[0])
            {
                scoreText.text = scores[1];
                return;
            } 
            if (scoreText.text == scores[1])
            {
                scoreText.text = scores[2];
                return;
            }
            if (scoreText.text == scores[2])
            {
                scoreText.text = scores[3];
                return;
            }
            if (scoreText.text == scores[3])
            {
                if (IsDeuce(isDeuce))
                {
                    scoreText.text = scores[4];
                    return;
                }
                else if (opponentScoreText.text == scores[4])
                {
                    opponentScoreText.text = scores[3];
                    return;
                }
                else
                {
                    isGame = true;
                    AddGame();
                    return;
                }

            }
            if (scoreText.text == scores[4])
            {
                isGame = true;
                AddGame();
            }

        }
        if (isPointLost)
        {
            if (opponentScoreText.text == scores[0])
            {
                opponentScoreText.text = scores[1];
                return;
            }
            if (opponentScoreText.text == scores[1])
            {
                opponentScoreText.text = scores[2];
                return;
            }
            if (opponentScoreText.text == scores[2])
            {
                opponentScoreText.text = scores[3];
                return;
            }
            if (opponentScoreText.text == scores[3])
            {
                if (IsDeuce(isDeuce))
                {
                    opponentScoreText.text = scores[4];
                    return;
                }
                else if (scoreText.text == scores[4])
                {
                    scoreText.text = scores[3];
                    return;
                }
                else
                {
                    isGame = true;
                    AddGame();
                    return;
                }
                    
            }              
            if (opponentScoreText.text == scores[4])
            {
                isGame = true;
                AddGame();
            }
          
                
        }

        
    }

    public void AddSet()
    {
        if (int.Parse(gameScoreText.text) > int.Parse(opponentGameScoreText.text))
        {
            int setScore = int.Parse(setScoreText.text);
            setScore += 1;
            setScoreText.text = setScore.ToString();
            //has set isSet to false before resetting game score so it doesnt keep looping
            isSet = false;
            ResetScore(gameScoreText, opponentGameScoreText);
            return;
        }
        if (int.Parse(gameScoreText.text) < int.Parse(opponentGameScoreText.text))
        {
            int setScore = int.Parse(opponentSetScoreText.text);
            setScore += 1;
            opponentSetScoreText.text = setScore.ToString();
            //has set isSet to false before resetting game score so it doesnt keep looping
            isSet = false;
            ResetScore(gameScoreText, opponentGameScoreText);
            return;
        }
    }

    public void ResetScore(TMP_Text score, TMP_Text opponentScore)
    {
        score.text = scores[0];
        opponentScore.text = scores[0];
        isGame = false;
    }

    public bool IsDeuce(bool isDeuce)
    {
        if (scoreText.text == scores[3] && opponentScoreText.text == scores[3])
        {
            isDeuce = true;
        }
        else
        {
            isDeuce = false;
        }
        return isDeuce;
    }

    public bool IsSet(bool isSet)
    {
        if (int.Parse(gameScoreText.text) >= 6 || int.Parse(opponentGameScoreText.text) >= 6)
        {         
            if(IsDifferenceOfTwo(isDifferenceOfTwo, gameScoreText, opponentGameScoreText))
                isSet = true; 
        }
        else
        {
            isSet = false;
        }
        return isSet;
    }

    public bool IsDifferenceOfTwo(bool isDifferenceOfTwo, TMP_Text score, TMP_Text opponentScore)
    {
        //converting string to int for calculating whether the score has a difference of two
        int scoreInt = int.Parse(score.text);
        int opponentScoreInt = int.Parse(opponentScore.text);
        if (scoreInt >= (opponentScoreInt + 2) || opponentScoreInt >= (scoreInt + 2))
        {
            isDifferenceOfTwo = true;
        }
        else
        {
            isDifferenceOfTwo = false;
        }
        return isDifferenceOfTwo;
        
    }

    public bool IsTieBreak(bool isTiebreak)
    {
        if (gameScoreText.text == "6" && opponentGameScoreText.text == "6")
        {
            isTiebreak = true;
        }
        return isTiebreak;
    }

    public void Tiebreaker()
    {
        int scoreInt = int.Parse(scoreText.text);
        int opponentScoreInt = int.Parse(opponentScoreText.text);
        if (isBallInPlay)
            return;
        if (isPointWon)
        {
            scoreInt += 1;
            scoreText.text = scoreInt.ToString();
        }
        if (isPointLost)
        {
            opponentScoreInt += 1;
            opponentScoreText.text = opponentScoreInt.ToString();
        }
        if(scoreInt >= 7 || opponentScoreInt >= 7)
        {
            if (IsDifferenceOfTwo(isDifferenceOfTwoInTiebreak, scoreText, opponentScoreText))
            {
                isGame = true;
                isTiebreak = false;
                AddGame();                 
                AddSet();
            }
        }
    }
        
    
}
