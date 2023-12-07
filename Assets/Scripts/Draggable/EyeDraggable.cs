using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDraggable : Draggable
{
    public override void OnMouseDrag()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionEye)
        {
            base.OnMouseDrag();
        }

    }
}
