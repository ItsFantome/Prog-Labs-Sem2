using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharacterStats //This should make CharacterStats the parent
{
    public override void Die() //Overrides the function in the parent class
    {
        base.Die();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
