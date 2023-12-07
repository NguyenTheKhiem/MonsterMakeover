using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMouthManager : OptionManager
{
    private void Update()
    {
        if (GameManager.Ins.GameState == GameManager.state.OptionMouth && GameManager.Ins.Check == true)
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
