using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour {

    public float minDis = 0.7f;
    public float maxDis = 2.5f;
    public float smooth = 100f;
    Vector3 dir;
    public float distance;

	void Awake () {
        dir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
	}
	
	void Update () {
        Vector3 desiredCamPos = transform.parent.TransformPoint(dir * maxDis);
        RaycastHit hit;

        if (Physics.Linecast (transform.parent.position, desiredCamPos, out hit)) {
            distance = Mathf.Clamp((hit.distance), minDis, maxDis);
        } else {
            distance = maxDis;
        }

        transform.localPosition = Vector3.Lerp(transform.localScale, dir * distance, Time.deltaTime * smooth);
	}
}
