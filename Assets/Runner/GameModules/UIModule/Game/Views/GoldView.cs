using PingleStudio.Runner.GameModule.UIModule.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PingleStudio.Runner.GameModule.UIModule.Game
{
    public class GoldView : BaseUiView
    {
        public Sprite Icon
        {
            get { return _icon.sprite; }
            set { _icon.sprite = value; }
        }

        [SerializeField] private Image _icon;

        public string Quantity // that fields need for change info in view
        {
            get { return _quantity.text; }
            set { _quantity.text = value; }
        }

        [SerializeField] private TextMeshProUGUI _quantity;

        public string Header
        {
            get { return _quantity.text; }
            set { _quantity.text = value; }
        }

        [SerializeField] private TextMeshProUGUI _header;

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


        public void UpdateViewInfo(Sprite icon, int quantity, string header) // Method, for full update info about that view
        {
            _icon.sprite = icon;
            _quantity.text = quantity.ToString();
            _header.text = header;
        }
    }
}