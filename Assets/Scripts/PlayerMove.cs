using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    float _oldMousePositionX;
    float _eulerY;
    public float velocity;
    [SerializeField] Animator _animator;
    Vector3 targetPos;
    float laneOffset = 2.5f;
    float laneChangeSpeed = 15;

    // Update is called once per frame
    void Update()
    {
        
    

            if (Input.GetMouseButtonDown(0))
            {
                _oldMousePositionX = Input.mousePosition.x;
                _animator.SetBool("Run", true);

            }

            if (Input.GetMouseButton(0))
            {
                Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
                newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 1.9f);
                transform.position = newPosition;



                float deltaX = Input.mousePosition.x - _oldMousePositionX;
                _oldMousePositionX = Input.mousePosition.x;

                _eulerY += deltaX;
                _eulerY = Mathf.Clamp(_eulerY, -70, 70);
                transform.eulerAngles = new Vector3(0, _eulerY, 0);
            }
            if (Input.GetMouseButtonUp(0))
            {

                _animator.SetBool("Run", false);
            }


        }
    }
