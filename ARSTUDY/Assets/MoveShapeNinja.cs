using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShapeNinja : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On!!!");
    }
}
