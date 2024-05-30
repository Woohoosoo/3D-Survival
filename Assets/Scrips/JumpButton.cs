using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public float jumpForce = 10f;
    public string playerTag = "Player";//�÷��̾ �±��ؾ� �Ѵ�



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag(playerTag))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();//�÷��̾��� rigidbody�� �����;��Ѵ�.
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}



