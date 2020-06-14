using UnityEngine;

namespace PingleStudio.Runner.GameModule.UIModule.Base
{
    public abstract class BaseUiView : MonoBehaviour
    {
        [SerializeField] private protected CanvasGroup _canvasGroup;

        private const int SHOWED_VIEW_VALUE = 1;
        private const int HIDED_VIEW_VALUE = 0;

        public virtual void Init()
        {
            if (_canvasGroup == null)
            {
                _canvasGroup = gameObject.AddComponent<CanvasGroup>();
            }

            _canvasGroup.alpha = HIDED_VIEW_VALUE;
            _canvasGroup.interactable = false;
        }

        public virtual void Show()
        {
            _canvasGroup.alpha = SHOWED_VIEW_VALUE;
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;
        }

        public virtual void Hide()
        {
            _canvasGroup.alpha = HIDED_VIEW_VALUE;
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
        }
    }
}