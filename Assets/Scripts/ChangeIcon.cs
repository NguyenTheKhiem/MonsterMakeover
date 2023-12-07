using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class ChangeIcon : MonoBehaviour
{
    [SerializeField] Sprite changeIcon;
    [SerializeField] Sprite defaultIcon;

    public virtual void ChangeIcon1()
    {
        this.GetComponent<Image>().color = Color.green;
    }
    public virtual void ChangeIconComplete()
    {
        this.GetComponent<Image>().color = Color.white;
        this.GetComponent<Image>().sprite = changeIcon;
    }
    public virtual void DefualtfIcon()
    {
        this.GetComponent<Image>().color = Color.white;
        this.GetComponent<Image>().sprite =defaultIcon;
       
    }
}
