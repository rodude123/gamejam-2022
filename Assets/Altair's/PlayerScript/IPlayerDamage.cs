using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerDamage
{
    public void TierOneEnemyTakeDamage();
    public void TierTwoEnemyTakeDamage();
    public void TierThreeEnemyTakeDamage();
    public void TierFourEnemyTakeDamage();
    public void TierFiveEnemyTakeDamage();

    public void EnemyCollisionDamage();

}
