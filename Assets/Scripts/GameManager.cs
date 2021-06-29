using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;

        setScoreText(ref playerScoreText, _playerScore);
        if(_playerScore == 1000)
        {
            ball.ResetPosition();
        }
        {
            ResetRound();
        }
    }

    public void ComputerScores()
    {
        _computerScore++;

        setScoreText(ref computerScoreText, _computerScore);
        if (_computerScore == 1000)
        {
            ball.ResetPosition();
        }
        {
            ResetRound();
        }
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    private void setScoreText(ref Text text, int score)
    {
        switch (score)
        {
            case 1000:
                text.fontSize = 70;
                text.text = "You are the best!";
                break;
            case 500:
                text.fontSize = 60;
                text.text = "Halfway to glory! (really)";
                break;
            case 101:
                text.fontSize = 60;
                text.text = "It's not over yet...";
                break;
            case 100:
                text.fontSize = 70;
                text.text = "God of Pong!";
                break;
            case 50:
                text.fontSize = 70;
                text.text = "Halfway to glory!";
                break;
            case 20:
                text.fontSize = 70;
                text.text = "What a score!";
                break;
            case 10:
                text.fontSize = 70;
                text.text = "Not bad...";
                break;
            default:
                text.fontSize = 200;
                text.text = score.ToString();
                break;
        }
       
    }
}
