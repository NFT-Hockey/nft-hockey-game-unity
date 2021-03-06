using System.Collections.Generic;
using Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Marketplace
{
    public class MarketplaceInteractor : ViewInteractor
    {
        [SerializeField] private List<Transform> views;
        [SerializeField] private List<TopButton> buttons;

        public override void ChangeView(Transform toView)
        {
            foreach (Transform view in views)
            {
                view.gameObject.SetActive(false);
            }
            
            toView.gameObject.SetActive(true);
        }

        public void ChangeActiveButton(TopButton newActiveButton)
        {
            foreach (TopButton topButton in buttons)
            {
                topButton.image.sprite = topButton.defaultSprite;
                topButton.text.color = Color.white;
            }

            newActiveButton.image.sprite = newActiveButton.activeSprite;
            newActiveButton.text.color = newActiveButton.activeColor;
        }

        public void Back()
        {
            SceneManager.LoadSceneAsync("MainMenu");
        }
    }
}