using UnityEngine;
using UnityEngine.Events;

public class CollisionComponent : MonoBehaviour
{
    public UnityEvent<Collision> onCollisionEnterEvent;
    public UnityEvent<Collision> onCollisionStayEvent;
    public UnityEvent<Collision> onCollisionExitEvent;

    private void OnCollisionEnter(Collision collision)
    {
        onCollisionEnterEvent?.Invoke(collision);
    }

    private void OnCollisionStay(Collision collision)
    {
        onCollisionStayEvent?.Invoke(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        onCollisionExitEvent?.Invoke(collision);
    }
}
