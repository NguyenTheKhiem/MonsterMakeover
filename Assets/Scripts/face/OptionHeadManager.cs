using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionHeadManager : OptionManager
{
    
    public override void Show()
    {
        base.Show();
    }
    private void Update()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionHead && GameManager.Ins.Check ==true)
        {
            Show();
            GameManager.Ins.Check = false;
        }
    }
    //[SerializeField] List<Sprite> OptionsHead = new List<Sprite>();
    // [SerializeField] OptionButton[] optionButtons;

    // private void Start()
    // {
    //     if(OptionsHead.Count > 0)
    //     {
    //         int i = 0;
    //         foreach(var itemp in OptionsHead)
    //         {
    //             optionButtons[i].SetSprite(itemp);
    //            // optionButtons[i].CompBtn.onClick.RemoveAllListeners();
    //            // optionButtons[i].CompBtn.onClick.AddListener(() => Instance(itemp));
    //             i++;
    //         }

    //     }
    // }
    public void Instance(GameObject Item)
    {
       Sprite a = (Sprite)ObjPooling.Ins.GetObject((GameObject)Item);
    }
}
