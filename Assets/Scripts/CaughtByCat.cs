using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtByCat : MonoBehaviour {

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Player_Cat")
        {
            //SomeCatScript catScript = GameObject.GetComponent...
            //catScript.AddMouseBonusPoint()
            Destroy(this.gameObject);
        }
    }
}
