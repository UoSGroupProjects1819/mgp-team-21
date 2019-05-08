using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour {

    public Texture2D image;
    public CursorMode mode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void OnMouseEnter()
    {
        Cursor.SetCursor(image, hotSpot, mode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, mode);
    }
}
