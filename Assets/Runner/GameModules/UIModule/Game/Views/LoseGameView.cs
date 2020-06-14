using System;
using PingleStudio.Runner.GameModule.UIModule.Base;
using UnityEngine;
using UnityEngine.UI;

namespace PingleStudio.Runner.GameModule.UIModule.Game
{
    public class LoseGameView : BaseUiView
    {
        public event Action OnUserClickedBackToMain;
        public event Action OnUserClickedRestartGame;

        [SerializeField] private Button _restartGameButton;
        [SerializeField] private Button _backToMainButton;

        #region Monobehaviour

        private void Start()
        {
            _backToMainButton.onClick.AddListener(NotifyAboutClickBackToMain);
            _restartGameButton.onClick.AddListener(NotifyAboutClickRestartGame);
        }

        #endregion

        #region OverrideMethods

        public override void Init()
        {
            base.Init();
        }

        public override void Show()
        {
            base.Show();
        }

        public override void Hide()
        {
            base.Hide();
        }

        #endregion


        public void NotifyAboutClickBackToMain()
        {
            OnUserClickedBackToMain?.Invoke();
        }

        public void NotifyAboutClickRestartGame()
        {
            OnUserClickedRestartGame?.Invoke();
        }

        private void OnDestroy()
        {
            _backToMainButton.onClick.RemoveAllListeners();
            _restartGameButton.onClick.RemoveAllListeners();
        }
    }
}