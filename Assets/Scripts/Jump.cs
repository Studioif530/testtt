using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;  // 점프 강도

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 Player인지 확인
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            // 플레이어의 Rigidbody에 순간적인 힘을 가함
            Rigidbody rb = player.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
