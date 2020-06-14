//                                                                            //
// Thin controller that is responsible for the interface in the game scene    //
//                                                                            //

using PingleStudio.Runner.GameModule.UIModule.Game;
using UnityEngine;

public class UiGameCanvasController : MonoBehaviour, IUiGameCanvasController
{
    [SerializeField] private GoldView _goldView;
    [SerializeField] private GameInputView _gameInputView;
    [SerializeField] private LoseGameView _loseGameView;


    // Methods that are called externally on the game scene by an external controller

    #region InMethods

    public void Init()
    {
        // Init needed reference on external controller todo

        _goldView.Init();
        _gameInputView.Init();
        _loseGameView.Init();

        SubscribeAtNeedEvents();
    }

    public void ShowGamePlayUserInterface()
    {
        _goldView.Show();
        _gameInputView.Show();
        _loseGameView.Hide();
    }


    public void ShowLoseGameUserInterface()
    {
        _goldView.Hide();
        _gameInputView.Hide();
        _loseGameView.Show();
    }

    #endregion

    #region Private Methods

    private void SubscribeAtNeedEvents()
    {
        _gameInputView.OnClickedMovementControl += NotifyAboutUserClickedOnMoveControl;
        _loseGameView.OnUserClickedBackToMain += NotifyAboutUserWantToBackInMainMenu;
        _loseGameView.OnUserClickedRestartGame += NotifyAboutUserWantToRestartGame;
    }

    private void ChangeQuantityGold(int quantityGold)
    {
        _goldView.Quantity = quantityGold.ToString();
    }

    private void NotifyAboutUserClickedOnMoveControl(string keyId)
    {
        switch (keyId)
        {
            case GameInputNamed.LeftClicked:
                // call the method in external controller todo
                break;
            case GameInputNamed.CenterClicked:
                // call the method in external controller todo
                break;
            case GameInputNamed.RightClicked:
                // call the method in external controller todo
                break;
        }
    }

    private void NotifyAboutUserWantToBackInMainMenu()
    {
        // call method on external controller for user want to back in main menu todo
    }

    private void NotifyAboutUserWantToRestartGame()
    {
        // add call method to controller about a user want to restart the game todo
    }


    private void OnDestroy()
    {
        UnsubscribeSubscribeAtNeedEvents();
    }

    private void UnsubscribeSubscribeAtNeedEvents()
    {
        _gameInputView.OnClickedMovementControl -= NotifyAboutUserClickedOnMoveControl;
        _loseGameView.OnUserClickedBackToMain -= NotifyAboutUserWantToBackInMainMenu;
        _loseGameView.OnUserClickedRestartGame -= NotifyAboutUserWantToRestartGame;
    }

    #endregion
}