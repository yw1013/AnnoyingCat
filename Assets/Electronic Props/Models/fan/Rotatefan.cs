using UnityEngine;

public class Rotatefan : MonoBehaviour 
{
	public float speed = 5f;
	void Update() 
	{
		transform.Rotate (0, 0, speed);
	}
}
