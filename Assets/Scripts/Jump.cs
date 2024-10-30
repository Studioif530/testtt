using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;  // ���� ����

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ��ü�� Player���� Ȯ��
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            // �÷��̾��� Rigidbody�� �������� ���� ����
            Rigidbody rb = player.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
