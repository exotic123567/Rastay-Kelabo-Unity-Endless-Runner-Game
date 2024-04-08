using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolderScript : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private void Update() {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x, playerTransform.eulerAngles.y, 0);
    }
}
