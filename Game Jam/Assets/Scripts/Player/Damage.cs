using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Damage 
{
    int Healt { get; set; }
    void damage(int damageCount);
}
