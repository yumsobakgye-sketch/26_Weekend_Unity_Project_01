using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    void Update()
    {
        // Y 좌표가 -10보다 낮아지면
        if (transform.position.y < -10f)
        {
            // 좌표를 0, 0, 0으로 초기화
            transform.position = new Vector3(0, 3, -11.57f);
        }
    }
}
