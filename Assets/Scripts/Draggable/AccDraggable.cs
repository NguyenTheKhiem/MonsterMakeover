using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccDraggable : Draggable
{
    public override void OnMouseDrag()
    {
        if(GameManager.Ins.GameState == GameManager.state.OptionAcc)
        {
            base.OnMouseDrag();
        }
        
    }
}
