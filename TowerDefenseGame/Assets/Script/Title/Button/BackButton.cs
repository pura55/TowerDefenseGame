using UnityEngine;

/// <summary>
/// バックボタン
/// 
/// 戻るボタン
/// </summary>
public class BackButton : ButtonBase
{
    #region State
    [SerializeField] private StartScreen startScreen; // スタートスクリーン
    [SerializeField] private SelectScreen selectScreen; // 選択スクリーン
    #endregion
    public override void OnClick()
    {
        base.OnClick();
        selectScreen.SetBackPressed();
        startScreen.SetBackPressed();
    }
}
