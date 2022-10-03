using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Wizard")
            GameManager.instance.ShowText("Having trouble fellow trick-or-treater? Check the treasure chest in the corner for clues.", 45, Color.yellow, transform.position, Vector3.up * 10, 6.0f);
    }
}
