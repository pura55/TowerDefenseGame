using UnityEngine;

/// <summary>
/// セレクトスクリーン
/// 
/// キャラクター選択スクリーンクラス
/// </summary>
public class SelectScreen : StartScreen
{
    void Start()
    {
        myRectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        PressPlayButton();

        PressBackButton();
    }
}
