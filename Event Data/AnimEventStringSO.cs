using UnityEngine;

namespace Core.AnimationEventSystem.EventData
{
    [CreateAssetMenu(menuName = "Animation/Event String Param")]
    public class AnimEventStringSO : AnimEventSO
    {
        [SerializeField] protected string value;

        public override void Raise(AnimationEventReceiver receiver)
        {
            receiver.RaiseEvent(this.Key, value);
        }
    }
}
