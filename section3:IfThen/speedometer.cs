using UnityEngine;

public class SomeClass : MonoBehaviour
{
    private float acceleration = 0;

    void Update()
    {
        HandleMovement();
        MovementAlerts();
    }

    void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            acceleration += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            acceleration -= 1;
        }
    }


    void MovementAlerts()
    {
        if (acceleration >= 20)
        {
            Debug.Log("Too fast");
        }
        else if (acceleration == 0)
        {
            Debug.Log("Stopped");
        }
    }




}
