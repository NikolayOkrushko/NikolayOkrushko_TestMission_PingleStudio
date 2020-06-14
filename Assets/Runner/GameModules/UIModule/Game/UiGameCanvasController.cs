using PingleStudio.Runner.GameModule.UIModule.Game;
using UnityEngine;

public class UiGameCanvasController : MonoBehaviour
{
    [SerializeField] private GoldView _goldView;
    [SerializeField] private GameInputView _gameInputView;
    [SerializeField] private LoseGameView _loseGameView;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Init();
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            ShowGamePlayIntarface();
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            ShowLoseGame();
        }
    }

    public void Init()
    {
        // Init needed reference on external controller 

        _goldView.Init();
        _gameInputView.Init();
        _loseGameView.Init();
    }

    public void ShowGamePlayIntarface()
    {
        _goldView.Show();
        _gameInputView.Show();
        _loseGameView.Hide();
    }


    public void ShowLoseGame()
    {
        _goldView.Hide();
        _gameInputView.Hide();
        _loseGameView.Show();
    }
}