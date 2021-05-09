using JoostenProductions;
using UnityEngine;
using Tools;

namespace Game.InputLogic
{
    internal sealed class InputTrailView : BaseInputView
    {
        public override void Init(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, float speed)
        {
            base.Init(leftMove, rightMove, speed);
            UpdateManager.SubscribeToUpdate(UpdateTrailPosition);
        }

        private void OnDestroy()
        {
            UpdateManager.UnsubscribeFromUpdate(UpdateTrailPosition);
        }

        private void UpdateTrailPosition()
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = pos;
        }
    }
}

