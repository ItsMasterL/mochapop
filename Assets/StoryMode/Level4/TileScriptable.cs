using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class TileScriptable : ScriptableObject
{
    public TileBase[] tiles;

    public bool orb, blueOrb, pad, bluePad, yellowGravity, blueGravity;
}
