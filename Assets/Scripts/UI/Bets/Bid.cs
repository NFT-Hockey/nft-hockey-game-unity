using Near.GameContract;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Bets
{
    public class Bid : MonoBehaviour
    {
        [SerializeField] private Text bid;

        public async void SetBid()
        {
            Actions.MakeAvailable(bid.text);
        }

        public async void CancelTheBid()
        {
            Actions.MakeUnavailable();
        }
    }
}