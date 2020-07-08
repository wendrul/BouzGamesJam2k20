using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    [SerializeField] private bool shouldSnap;
    [SerializeField] private bool isMoving;

    private float startPosX;
    private float startPosY;
    private Vector3 resetPosition;
    private Transform runePosition;
    private Runes rune;
    private MaterialObject material;
    //public GameObject correctForm;


    private void Start()
    {
        material = GetComponent<MaterialObject>();
        resetPosition = this.transform.localPosition;
    }
    
    private void OnElementAdd()
    {
        rune.Element = new Element(material, rune.id);
    }
    private void Update()
    {
       if (isMoving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
         
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
        if (shouldSnap && !isMoving)
        {
            OnElementAdd();
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

            isMoving = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Rune")
        {
                shouldSnap = true;
                runePosition = collision.gameObject.transform;
                rune = collision.gameObject.GetComponent<Runes>();
                //this.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Rune")
        {
            shouldSnap = false;
        }
    }
    private void OnMouseUp()
    {
        
        isMoving = false;

    }
}
