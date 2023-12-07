using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Draggable : MonoBehaviour
{
    Vector3 m_mousePos;
    Vector2 m_distancebetween;
    void GetMousePos()
    {
        m_mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown()
    {
        GetMousePos();
        m_distancebetween = (Vector2)(m_mousePos - transform.position);
    }
   // public virtual void
    public virtual void OnMouseDrag()
    {
       
        GetMousePos();
        transform.position =(Vector2)m_mousePos - m_distancebetween;
    }
}
