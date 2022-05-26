using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedEnemy : MonoBehaviour
{
    private void OnDestroy()
    {
        transform.parent.GetComponent<Spawner>().EnemyOnScene.Remove(this.gameObject);
        GameObject.Find("SceneManager").GetComponent<ScoreCounter>().Score++;
    }
}
