using UnityEngine;

public class test : MonoBehaviour
{
    [Header("移動速度"), Range(1.0f, 10.0f)]
    public float speed = 5.0f;

    [Header("跳躍高度"), Range(1,10)]
    public int Jump = 5;

    [Header("對話內容")]
    public string Talk = "你好，世界!";

    [Header("取得雞蛋")]
    public bool Egg = false;
    void Start()
    {
        print("遊戲開始...");
        if (!string.IsNullOrWhiteSpace(Talk)) print(Talk);
    }

    void Update()
    {
        
    }
}
