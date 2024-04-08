using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    public float limitValue = 1.53f;
    public float posOfMouse;
    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            posOfMouse = Input.mousePosition.x;
            MovePlayer(posOfMouse);
        }
    }

    private void MovePlayer(float posOfMouse) {
        float halfScreen = Screen.width / 2;
        float xPos = (posOfMouse - halfScreen)/halfScreen;
        float finalXpos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);
        float newX = Mathf.Clamp(playerTransform.position.x + finalXpos, -1.53f, 1.53f);
        playerTransform.position = new Vector3(newX, playerTransform.position.y, playerTransform.position.z);
    }
}
