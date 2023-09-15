using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player2 : MonoBehaviour
{

    public Transform transform;
    [SerializeField] private float speed = 5f;


    private float vertical;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0, vertical * speed * Time.deltaTime, 0);

        transform.position = newPosition;

    }

    public void Move(InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<Vector2>().y;
    }


}
