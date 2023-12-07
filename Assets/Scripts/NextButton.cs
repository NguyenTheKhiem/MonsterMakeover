using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    [SerializeField] Text done;
    public Text Done { get => done;  }

    public void ShowBtn(bool show)
    {
        this.gameObject.SetActive(show);
    }
}
