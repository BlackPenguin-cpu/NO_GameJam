using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couple : BaseObject
{
    public override void OnHammer()
    {
        base.OnHammer();
        Data.Instance.score -= 50;
    }
    public override void OnMetch()
    {
        base.OnMetch();
    }
}
