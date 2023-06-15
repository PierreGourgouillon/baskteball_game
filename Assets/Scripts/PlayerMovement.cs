using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator mAnimator;
    public float walkSpeed;
    public float runSpeed;
    public float turnSpeed;

    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;

    private bool isMoveFront;
    private bool isMoveBack;
    private bool isMoveRight;
    private bool isMoveLeft;

    public Vector3 jumpSpeed;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isMoveFront = Input.GetKey(inputFront);
        isMoveBack = Input.GetKey(inputBack);
        isMoveLeft = Input.GetKey(inputLeft);
        isMoveRight = Input.GetKey(inputRight);

        if (mAnimator != null) {

            if(isMoveFront) {
                mAnimator.SetTrigger("Run");
                transform.Translate(0, 0, walkSpeed * Time.deltaTime);
            }

            if (isMoveBack) {
                transform.Translate(0, 0, -walkSpeed * Time.deltaTime);
            }

            if (isMoveRight) {
                transform.Translate(walkSpeed * Time.deltaTime, 0, 0);

            }

            if (isMoveLeft) {
                transform.Translate(-walkSpeed * Time.deltaTime, 0, 0);

            }

            if (!isMoveFront && !isMoveBack && !isMoveLeft && !isMoveRight) {
                mAnimator.SetBool("Default", true);
            }
        }
    }
}
