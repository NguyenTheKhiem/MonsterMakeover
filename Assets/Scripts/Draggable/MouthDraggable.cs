using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthDraggable : Draggable
{
    public override void OnMouseDrag()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionMouth)
        {
            base.OnMouseDrag();
        }

    }
}
