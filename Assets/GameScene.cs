using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public readonly int MonsterMax = 100000;


    // Start is called before the first frame update
    void Start()
    {
        var character = GameManager.Inst.CreateCharacter();
        var charPos = character.transform.position;

        for(int i = 0; i < MonsterMax; i++)
        {
            float x = Random.Range(1f, 10f) * (Random.Range(0, 2) >= 1 ? 1f : -1f);
            float y = Random.Range(1f, 10f) * (Random.Range(0, 2) >= 1 ? 1f : -1f);
            GameManager.Inst.CreateMonster(charPos + new Vector3(x, y, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
