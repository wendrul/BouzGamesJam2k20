using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private bool snap;
    private bool moving;
    private bool over;
    private bool snapInv;

    private float centerx;
    private float centery;

    private float startPosX;
    private float startPosY;
    private Vector3 resetPosition;
    private Transform runePosition;
    private Transform materialPosition;
    public GameObject inventory;
    public float gridoffsetx;
    public float gridoffsety;
    RectTransform rt;
    //public GameObject correctForm;
    float height;
    float width;
    float inventoryWidth;
    float inventoryHeight;
    //public GameObject correctForm;
    private void Start()
    {
        inventoryWidth= inventory.GetComponent<SpriteRenderer>().bounds.size.x;
        inventoryHeight= inventory.GetComponent<SpriteRenderer>().bounds.size.y;
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        height = GetComponent<SpriteRenderer>().bounds.size.y;
        resetPosition = this.transform.localPosition;
        rt = (RectTransform)inventory.transform;
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

        if (snapInv && moving == false)
        {
           // this.transform.position = new Vector3(materialPosition.transform.position.x, materialPosition.transform.position.y, this.transform.position.z);
            this.transform.position = new Vector3(materialPosition.transform.position.x - inventoryWidth / 2 + width / 2 + gridoffsetx, materialPosition.transform.position.y + inventoryHeight / 2 - height / 2 - gridoffsety, this.transform.position.z);
        }
    }

    private void OnMouseOver()
    {
        if (over == false)
        {
            over = true;
            this.transform.Find("Memo").gameObject.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        if (over == true)
        {
            over = false;
            this.transform.Find("Memo").gameObject.SetActive(false);
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

        if (collision.tag == "Inventory")

        {
            snapInv = true;
            materialPosition = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Rune")
        {
            snap = false;
        }
        if (collision.tag == "Inventory")

        {
            snapInv = false;
        }
    }
    private void OnMouseUp()
    {
        
        moving = false;

    }
}
