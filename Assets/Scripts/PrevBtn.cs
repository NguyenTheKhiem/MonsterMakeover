using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrevBtn : MonoBehaviour
{
    [SerializeField] Button prev;
    public void ShowBtn(bool show)
    {
        this.gameObject.SetActive(show);
    }
    public void Active(bool show)
    {
        prev.enabled = show;
        this.GetComponent<Image>().color = Color.white;
    }
}
