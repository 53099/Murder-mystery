using TMPro;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] Stage stage;
    [SerializeField] Transform textPivot;
    [SerializeField] GameObject textPrefab;

    float timer;
    int textiIndex;

    GameObject textGO;
    private int textIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stage.dialogueNodes.Count <= textiIndex) { return; }

        timer += Time.deltaTime;

        if (textGO == null)
        {
            textGO = SpawnText(textIndex);
            timer = 0;
        }

        if (timer > 3f)
        {
            Destroy(textGO);
            textiIndex++;
        }
    }

    GameObject SpawnText(int dialogueNodeIndex)
    {
        GameObject go = Instantiate(textPrefab);
        go.transform.position = textPivot.position;
        TextMeshPro tmp = go.GetComponent<TextMeshPro>();
        tmp.text = stage.dialogueNodes[dialogueNodeIndex].textLines[0].text;
        return go;
    }
}
