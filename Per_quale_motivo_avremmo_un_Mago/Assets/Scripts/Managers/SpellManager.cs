﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    public static SpellManager Singleton;

    public int i = 1;

    public bool celestialIsCasted;

    private void OnEnable()
    {
        Singleton = this;
    }

    public void CastTheSpell(Spell spellToCast)
    {
        print(spellToCast.spellName);

        if (spellToCast.spellName == "Celestial")
        {
            celestialIsCasted = true;
        }
    }
}
