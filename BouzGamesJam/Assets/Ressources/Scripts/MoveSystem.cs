using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private bool snap;
    private bool moving;

    private float startPosX;
    private float startPosY;
    private Vector3 resetPosition;
    private Transform runePosition;
    //public GameObject correctForm;


    private void Start()
    {

        resetPosition = this.transform.localPosition;
    }
    private void Update()
    {
       if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
         
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
        if (snap && moving == false)
        {
            this.transform.position = new Vector3(runePosition.transform.position.x, runePosition.transform.position.y, this.transform.position.z);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Rune")
        {
                snap = true;
                runePosition = collision.gameObject.transform;
                //this.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Rune")
        {
            snap = false;
        }
    }
    private void OnMouseUp()
    {
        
        moving = false;

    }
}
