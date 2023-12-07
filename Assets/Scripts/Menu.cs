using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Sprite[] face;
    [SerializeField] Sprite[] eye;
    [SerializeField] Sprite[] mouth;
    [SerializeField] Sprite[] acc;
    [SerializeField] GameObject g_face;
    [SerializeField] GameObject g_eye;
    [SerializeField] GameObject g_mouth;
    [SerializeField] GameObject g_acc;
    void Start()
    {
        StartCoroutine(randomFace());
        
    }
    private void Update()
    {
        if(GameManager.Ins.GameState == GameManager.state.OptionHead)
        {
            StopAllCoroutines();
        }
    }
    // Update is called once per frame
    IEnumerator randomFace()
    {
        while(GameManager.Ins.GameState == GameManager.state.menu)
        {
 //yield return new WaitForSeconds(0.5f);
        int randxFace = Random.Range(0, face.Length-1); 
        int randxEye = Random.Range(0, eye.Length-1); 
        int randxMouth = Random.Range(0, mouth.Length-1); 
        int randxAcc = Random.Range(0, acc.Length-1);
       
        g_face.GetComponent<Image>().sprite = face[randxFace];
        g_eye.GetComponent<Image>().sprite = eye[randxEye];
        g_mouth.GetComponent<Image>().sprite = mouth[randxMouth];
        g_acc.GetComponent<Image>().sprite = acc[randxAcc];
        yield return new WaitForSeconds(0.5f);
        }
       
    }
}
