using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moselok : MonoBehaviour
{
    // Start is called before the first frame update
    public float mousesencitivity = 100f;
    public Transform playerbody;
    float xrotaion = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X")* mousesencitivity *Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y")* mousesencitivity* Time.deltaTime;


        xrotaion -= mousey;
        xrotaion = Mathf.Clamp(xrotaion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotaion, 0f, 0f);
        playerbody.Rotate(Vector3.up * mousex);
    }

}
