using UnityEngine;

/// <summary>
/// プレイボタン
/// 
/// 選択スクリーンへ移動するボタン
/// </summary>
public class PlayButton : ButtonBase
{
    #region State
    [SerializeField] StartScreen startScreen; // 開始スクリーン
    [SerializeField] SelectScreen selectScreen; // 開始スクリーン
    #endregion

    public override void OnClick()
    {
        base.OnClick();
        startScreen.SetPlayPressed();
        selectScreen.SetPlayPressed();
    }
}
