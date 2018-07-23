using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public float CameraMoveSpeed = 10f;
    public GameObject CamFollowObj;
    public float clampAngle = 8f;
    public float inputSensitivity = 35f;
    public float mouseX;
    public float mouseY;
    private float rotX = 0f;
    private float rotY = 0f;

    private bool freecam;


	void Start () {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotX = rot.x;
        rotY = rot.y;
        freecam = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

	void Update()
	{
        if (Input.GetKeyDown(KeyCode.L))
        {
            freecam = !freecam;
        }

        if (freecam)
        {
            mouseX = Input.GetAxis("Mouse X");
            mouseY = Input.GetAxis("Mouse Y");

            rotY += mouseX * inputSensitivity * Time.deltaTime;
            rotX += mouseY * inputSensitivity * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

            Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0f);
            transform.rotation = localRotation;
        }

        if (!freecam) {
            transform.rotation = CamFollowObj.transform.rotation;
        }
	}

	void LateUpdate () {
        CameraUpdater();
	}

    void CameraUpdater() {
        Transform target = CamFollowObj.transform;
        float step = CameraMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
