using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    private GameObject target;
    public GameObject GetTarget() { return target; }


    private static GameManager inst;
    public static GameManager Inst
    { 
        get
        {
            if (inst == null)
            {
                var go = new GameObject("GameManager");
                inst = go.AddComponent<GameManager>();
            }

            return inst;
        } 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Character CreateCharacter()
    {
        var character = Resources.Load("Character") as GameObject;
        var charInst = Instantiate(character);
        target = charInst;
        return charInst.GetComponent<Character>();
    }

    List<Monster> monsterList = new List<Monster>();
    public void CreateMonster(Vector3 position)
    {
        var monster = Resources.Load("Monster") as GameObject;
        var monsterInst = Instantiate(monster);
        monsterInst.transform.position = position;
        monsterList.Add(monsterInst.GetComponent<Monster>());
    }
}
