using UnityEngine;

public class AxisComponent : MonoBehaviour
{
    public Vector2 axis;
    
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        axis = new Vector2(x, y);
    }
}
