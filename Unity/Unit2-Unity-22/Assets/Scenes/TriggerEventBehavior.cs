using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEvent(Collider Other)
    {
        triggerEnterEvent.Invoke();
    }
}
