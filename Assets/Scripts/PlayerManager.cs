using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool usePhysic;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    [SerializeField] private AxisComponent axisComponent;

    private Rigidbody rigidbodyRef;
    
    private void Start()
    {
        if (axisComponent == null) axisComponent = GetComponent<AxisComponent>();
        if (rigidbodyRef == null) rigidbodyRef = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (usePhysic) return;
        
        rigidbodyRef.AddForce(new Vector3(0f, 0f, 1) * (Time.deltaTime * forwardForce));
        
        if (axisComponent.axis.magnitude > 0f)
        {
            transform.position += new Vector3(axisComponent.axis.x, 0f, axisComponent.axis.y) * (Time.deltaTime * sideForce);
        }
    }

    private void FixedUpdate()
    {
        if (!usePhysic) return;

        rigidbodyRef.AddForce(new Vector3(0f, 0f, 1) * (Time.fixedDeltaTime * forwardForce));
        
        if (axisComponent.axis.magnitude > 0f)
        {
            rigidbodyRef.AddForce(new Vector3(axisComponent.axis.x, 0f, axisComponent.axis.y) * (Time.fixedDeltaTime * sideForce));
        }
    }
}
