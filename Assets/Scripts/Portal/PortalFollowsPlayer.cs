using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFollowsPlayer : MonoBehaviour
{
    public float distanceFromPlayer = 50f;
    // Start is called before the first frame update
    [SerializeField] private Transform playerTransform;
    private void Update() {
        transform.position = new Vector3(0, 3.5f, playerTransform.position.z + distanceFromPlayer);
        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x, playerTransform.eulerAngles.y, 0);
    }
}
