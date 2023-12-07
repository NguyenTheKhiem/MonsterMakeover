using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsAccManager : OptionManager
{
    private void Update()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionAcc && GameManager.Ins.Check == true)
        {
            Show();
            GameManager.Ins.Check = false;
        }
    }
    public override void Show()
    {
        base.Show();
    }
}
