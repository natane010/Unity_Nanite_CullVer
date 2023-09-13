#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += speed * Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += speed * Vector3.back * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += speed * Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += speed * Vector3.right * Time.deltaTime;
        }
    }
}
#endif