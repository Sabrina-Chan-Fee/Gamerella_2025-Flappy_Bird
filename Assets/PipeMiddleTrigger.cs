using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleTrigger : MonoBehaviour
{
    public LogicManager logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lets this scrip and the logicManager.cs script talk to each other
        logic = GameObject.FindGameObjectWithTag("Logic Manager").GetComponent<LogicManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore(1);
        
    }
}
