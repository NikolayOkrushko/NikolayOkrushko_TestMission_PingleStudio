using System;
using PingleStudio.Runner.GameModule.UIModule.Base;
using UnityEngine;
using UnityEngine.UI;

namespace PingleStudio.Runner.GameModule.UIModule.Game
{
    public class GameInputNamed
    {
        public const string LeftClicked = "LeftClicked";
        public const string RightClicked = "RightClicked";
        public const string CenterClicked = "CenterClicked";
    }

    public class GameInputView : BaseUiView
    {
        public event Action<string> OnClickedMovementControl;

        [SerializeField] private Button _leftButtonControl;
        [SerializeField] private Button _centerButtonControl;
        [SerializeField] private Button _rightButtonControl;

        #region OverrideMethods

        public override void Init()
        {
            base.Init();

            _leftButtonControl.onClick.AddListener(() => { UserClickedOnControlButton(GameInputNamed.LeftClicked); });
            _centerButtonControl.onClick.AddListener(() => { UserClickedOnControlButton(GameInputNamed.CenterClicked); });
            _rightButtonControl.onClick.AddListener(() => { UserClickedOnControlButton(GameInputNamed.RightClicked); });
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


        #region Monobehaviour

        private void OnDisable()
        {
            _leftButtonControl.onClick.RemoveAllListeners();
            _centerButtonControl.onClick.RemoveAllListeners();
            _rightButtonControl.onClick.RemoveAllListeners();
        }

        #endregion


        private void UserClickedOnControlButton(string buttonClicked)
        {
            switch (buttonClicked)
            {
                case GameInputNamed.LeftClicked:
                    // Передать на внешний контроллер информацию об нажатии на левую кнопку передвижения
                    OnClickedMovementControl?.Invoke(GameInputNamed.LeftClicked);
                    break;
                case GameInputNamed.CenterClicked:
                    // Передать на внешний контроллер информацию об ноажатии на центральную кнопку движения
                    OnClickedMovementControl?.Invoke(GameInputNamed.CenterClicked);
                    break;
                case GameInputNamed.RightClicked:
                    // Передать на внешний контроллер информацию об нажатии на правую кнопку передвижения
                    OnClickedMovementControl?.Invoke(GameInputNamed.RightClicked);
                    break;
            }
        }
    }
}