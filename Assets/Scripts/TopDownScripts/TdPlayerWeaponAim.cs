using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TdPlayerWeaponAim : MonoBehaviour
{
    
    private Animator aimAnimator;

    public Transform aimTransform;
    public Transform visualsToFlip;

    private void Awake() 
    {
        aimTransform = transform.Find("Aim");
        aimAnimator = aimTransform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Aiming();
        Shooting();

    }

    private void Aiming()
    {

        /*
        Vector3 mousePosition = Input.mousePosition;

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
        Debug.Log(angle);
        */

        /*
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        */


        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        aimTransform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        Vector3 aimLocalScale = Vector3.one;
        if (rotationZ > 90 || rotationZ < -90)
        {
            aimLocalScale.y = -1f;
            //weaponSpriteRenderer.flipX = false;
        } 
        else
        {
            aimLocalScale.y = +1f;   
            //weaponSpriteRenderer.flipX = false; 
        }
        //aimTransform.localScale = aimLocalScale;
        visualsToFlip.localScale = aimLocalScale;

    }

    private void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            aimAnimator.SetTrigger("Shoot");
        }
    }

}
