using UnityEngine;

public class FollowComponent : MonoBehaviour
{
    [Header("Main")]
    public Transform follow;
    
    private Vector3 shift;

    private void Start()
    {
        shift = transform.position - follow.position;
    }

    private void Update()
    {
        transform.position = follow.position + shift;
    }
}
