using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/Creature")]
public class CreatureCard : CardType
{
    public override void OnSetType(CardViz viz)
    {
        base.OnSetType(viz);

        viz.statsHolderAttack.SetActive(true);
        viz.statsHolderHealth.SetActive(true);
        viz.statsHolderMana.SetActive(true);
    }
}
