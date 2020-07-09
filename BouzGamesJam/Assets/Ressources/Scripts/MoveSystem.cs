﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private bool shouldSnap;
    private bool isMoving;

    private float startPosX;
    private float startPosY;
    private Vector3 startPos;
    private Vector3 resetPosition;
    private Transform runePosition;
    private Runes rune;
    private MaterialObject material;
    
    static float snapDistance = 1.7f;
    [SerializeField] private Transform[] runePositions;

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
            startPos = new Vector3(startPosX, startPosY);

            isMoving = true;
            shouldSnap = false;
        }
    }

    private void OnMouseUp()
    {
        
        isMoving = false;
        foreach (Transform rp in runePositions)
        {
            float dist = (rp.position - gameObject.transform.localPosition).magnitude;
            if (dist < snapDistance)
            {
                shouldSnap = true;
                runePosition = rp.gameObject.transform;
                rune = rp.gameObject.GetComponent<Runes>();
                break;
            }
        }
    }
}
