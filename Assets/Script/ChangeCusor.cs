using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCusor : MonoBehaviour
{
    [SerializeField] Texture2D cursorImg;

    private void Start()
    {
        Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
    }
}
