using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(menuName ="Cards")]
    public class Card : ScriptableObject
{
    public CardType cardType;
    public CardProperties[] properties;
}


