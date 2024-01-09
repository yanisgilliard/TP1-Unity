using UnityEngine;

public class Wrap : MonoBehaviour
{
    private void Update()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        Vector3 moveAdjustment = Vector3.zero;
        if (viewportPosition.x < 0)
        {
            moveAdjustment.x += 1;
        }
        else if (viewportPosition.x > 1)
        {
            moveAdjustment.x -= 1;
        }
        else if (viewportPosition.y < 0)
        {
            moveAdjustment.y += 1;
        }
        else if (viewportPosition.y > 1)
        {
            moveAdjustment.y -= 1;
        }

        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition + moveAdjustment);
    }
}