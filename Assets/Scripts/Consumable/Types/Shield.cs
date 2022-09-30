using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Consumable
{
    public override string GetConsumableName()
    {
        return "Shield";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.SHIELD;
    }

    public override int GetPremiumCost()
    {
        return 2;
    }

    public override int GetPrice()
    {
        return 500;

    }

}
