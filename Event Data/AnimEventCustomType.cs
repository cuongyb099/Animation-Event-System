using Core.AnimationEventSystem;
using Core.AnimationEventSystem.EventData;
using UnityEngine;

[CreateAssetMenu(menuName = "Animation/Event Custom Type")]
public class AnimEventCustomType : AnimEventSO
{
    public MyCustomType myCustomType;
    
    public override void Raise(AnimationEventReceiver receiver)
    {
        receiver.RaiseEvent(this.Key, myCustomType);
    }
    
    [System.Serializable]
    public class MyCustomType
    {
        public int a;
        public float b;
        public string c;
    }
}