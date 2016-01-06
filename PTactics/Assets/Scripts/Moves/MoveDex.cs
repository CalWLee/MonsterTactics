using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Battle
{
    public enum Category
    {
        Physical,
        Special,
        Status
    }

    public enum PType
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy
    }

    public enum MoveFlags
    {
        ContactFlag,
        ProtectFlag,
        MagicCoatFlag,
        SnatchFlag,
        MirrorMoveFlag,
        KingsRockFlag
    }

    public class MoveDex : ScriptableObject
    {

    }
}
