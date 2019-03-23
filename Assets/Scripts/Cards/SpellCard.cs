using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/Spell")]
public class SpellCard : CardType
{
    public override void OnSetType(CardViz viz)
    {
        base.OnSetType(viz);

        viz.statsHolderAttack.SetActive(false);
        viz.statsHolderHealth.SetActive(false);
        viz.statsHolderMana.SetActive(true);
    }
}
